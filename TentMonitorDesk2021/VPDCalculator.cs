using TentMonitorDesk2021.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace TentMonitorDesk2021
{

    public static class VPDCalculator
    {

        public static VPDLookup CalcVPD(decimal Temp, decimal Humidity)
        {
            var db = new TentData();

            var TempI = (int)Math.Floor(Temp);
            var Humidity1 = (int)Math.Floor(Humidity);

            int hum = ConvertHumToClosets(Humidity1);
            int temp = ConvertTempToClosest(TempI, hum);

            var LPD = (decimal)db.Settings.FirstOrDefault().lightsLPD;

            Temp = Temp + LPD;

            Decimal vpd = 0.0M;
            vpd = TryCalcVPD(Temp, Humidity);

            return new VPDLookup()
            {
                Temp = (int)Temp,
                RH = (int)Humidity,
                VPD = vpd
            };
       }

        private static int ConvertHumToClosets(int humidity)
        {

            if (humidity >= 55 && humidity <= 60)
                return 55;
            if (humidity > 60 && humidity <= 65)
                return 65;
            return 0;
        }

        private static int ConvertTempToClosest(int temp, int hum)
        {

            switch (hum)
            {
                case 55:
                    if (temp < 72 || temp > 79)
                        return 0;
                    else if (temp >= 72 && temp <= 79)
                        return (int)temp;
                    break;
                case 65:
                    if (temp < 68 || temp > 74)
                        return 0;
                    else if (temp >= 68 && temp <= 72)
                        return (int)temp;
                    break;
            }
            return 0;
        }

        private static double GetLPDFactor()
        {
            var LPDFactor = GetLPD(1);
            return (double)LPDFactor;
        }

        private static decimal GetLPD(int dayNight)
        {
            var db = new TentData();
            var settings = db.Settings.FirstOrDefault();
            if (dayNight == 0)
            {
                return settings.darkLPD;
            }
            else
            {
                return settings.lightsLPD;
            }
            
        }

        private static decimal TryCalcVPD(decimal Temp, decimal Humidity)
        {

            var tempFactor = 0;
            if (Temp > 65 && Temp <= 70)
                tempFactor = 22;
            if (Temp > 70 && Temp <= 73)
                tempFactor = 24;
            if (Temp > 73 && Temp <= 75)
                tempFactor = 23;
            if (Temp > 75 && Temp <= 77)
                tempFactor = 25;
            if (Temp > 77 && Temp <= 79)
                tempFactor = 26;
            if (Temp > 79 && Temp <= 81)
                tempFactor = 27;
            if (Temp > 81 && Temp <= 82)
                tempFactor = 28;
            if (Temp > 82 && Temp <= 86)
                tempFactor = 29;
            if (Temp > 86 && Temp <= 88)
                tempFactor = 30;




            var connStr = ConfigurationManager.ConnectionStrings["TentData2"].ConnectionString;
            var dg = new clsDataGetter(connStr);
            dg.conn.Open();


            List<SqlParameter> parms = new List<SqlParameter>();
            var parm = new SqlParameter("@dHum", Humidity);
            parms.Add(parm);
            parm = new SqlParameter("@dTemp", Temp);
            parms.Add(parm);
            var vpd = 0.0M;

            var x = dg.GetDataReaderSP("spLookupVPD", parms);
            x.Read();
            decimal.TryParse(x[0].ToString(),out vpd);

            

            //var cTemp = (double)(Temp - 32) * (5 / 9);

            double LPD = GetLPDFactor();
            var tempFactorD = (double)tempFactor;

            //var PlantSVP = (610.78 * Math.Exp((cTemp + LPD) / ((cTemp + LPD) + 238.3) * 17.2694));
            //var AirSVP = (610.78 * Math.Exp((cTemp) / ((cTemp) + 238.3) * 17.2694));

            //var VPD = PlantSVP - (AirSVP * ((double)Humidity / 100));

            //return (decimal)VPD;

            if (vpd > 0)
                return vpd;
            else
            {
                var expFactA = (610.78 * Math.Exp((tempFactor + LPD) / ((tempFactor + LPD) + 238.3) * 17.2694));
                expFactA = expFactA / 1000;
                var expFactB = -(610.78 * Math.Exp((tempFactor) / (tempFactor + 238.3) * 17.2694) / 1000 * (double)Humidity / 100);
                var retTempFactor = expFactA + expFactB;
                return (decimal)retTempFactor;

            }
        }


        private static int? GetClosestValue(Dictionary<decimal, int> tempMatrix, decimal Temp, decimal Humidity)
        {
            int ret = 0;
            KeyValuePair<decimal, int>? lastMember = null;
            foreach (var member in tempMatrix)
            {
                var x = member.Key;
                ret = tempMatrix[x];
                if (Temp < x)
                    return lastMember?.Value;
                else
                {
                    if (lastMember != null)
                    {
                        if (lastMember?.Value < Temp)
                        {
                            lastMember = member;
                            continue;
                        }
                    }
                    else
                    {
                        lastMember = member;
                    }
                }


            }
            return ret;
        }
    }
}








