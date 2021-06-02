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
            var dTemp = (double)Temp;
            var dHum = (double)Humidity;
            var TempI = (int)Math.Floor(Temp);
            var Humidity1 = (int)Math.Floor(Humidity);

            int hum = ConvertHumToClosets(Humidity1);
            int temp = ConvertTempToClosest(TempI, hum);

            var LPD = (decimal)db.Settings.FirstOrDefault().lightsLPD;

            Temp = Temp + LPD;

            Double vpd = 0.0;
            //vpd = TryCalcVPD(Temp, Humidity);

            //public static double CalculateVpd(double airTemp, double leafTempOffset, double rh)
            //{
                vpd = 3.386 * (Math.Exp(17.863 - 9621 / ((dTemp - 4) + 460)) - (dHum / 100) * Math.Exp(17.863 - 9621 / (dTemp + 460)));

            //}

            var decVPD = decimal.Parse(vpd.ToString());


            return new VPDLookup()
            {
                Temp = (int)Temp,
                RH = (int)Humidity,
                VPD = decVPD
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
            return settings.lightsLPD;
           
        }

        private static decimal TryCalcVPD(decimal Temp, decimal Humidity)
        {
            var intHum = GetIntHumidityForLookup(Humidity);
            var intTemp = GetIntTempForLookup(Temp);

            var db = new TentData();
            var tVP  = (decimal)db.Database.SqlQuery<double>($"EXEC spLookupVPD {intHum},{intTemp}").FirstOrDefault();
            return tVP;
        }

        private static int GetIntTempForLookup(decimal Temp)
        {
            if (Temp < 66)
                return 66;
            if (Temp >= 66 && Temp < 68M)
                return 66;
            if (Temp >= 68 && Temp < 70M)
                return 68;
            if (Temp >= 70 && Temp < 72M)
                return 66;
            if (Temp >= 72 && Temp < 73M)
                return 72;
            if (Temp >= 73  && Temp < 75M)
                return 73;
            if (Temp >= 75 && Temp < 77M)
                return 75;
            if (Temp >= 77 && Temp < 79M)
                return 77;
            if (Temp >= 79 && Temp < 80M)
                return 79;
            if (Temp >= 80 && Temp < 82M)
                return 80;
            if (Temp >= 82 && Temp < 84M)
                return 82;
            if (Temp >= 84 && Temp < 76M)
                return 84;
            else
                return (int)Math.Floor(Temp);

        }

        private static object GetIntHumidityForLookup(decimal humidity)
        {
            if (humidity < 38)
                return 38;
            if (humidity >= 38 && humidity < 40)
                return 38;
            if (humidity >= 40 && humidity < 42)
                return 40;
            if (humidity >= 42 && humidity < 44)
                return 42;
            if (humidity >= 44 && humidity < 46)
                return 44;
            if (humidity >= 46 && humidity < 48)
                return 46;
            if (humidity >= 48 && humidity < 50)
                return 48;
            if (humidity >= 50 && humidity < 52)
                return 50;
            if (humidity >= 52 && humidity < 54)
                return 52;
            if (humidity >= 54 && humidity < 56)
                return 54;
            if (humidity >= 56 && humidity < 58)
                return 56;
            if (humidity >= 58 && humidity < 60)
                return 58;
            if (humidity >= 60 && humidity < 62)
                return 60;
            if (humidity >= 62 && humidity < 64)
                return 62;
            if (humidity >= 64 && humidity < 66)
                return 64;
            if (humidity >= 66 && humidity < 68)
                return 66;
            if (humidity >= 68 && humidity < 70)
                return 68;
            if (humidity >= 70 && humidity < 72)
                return 70;
            if (humidity >= 72 && humidity < 74)
                return 72;
            if (humidity >= 74 && humidity < 76)
                return 74;
            if (humidity >= 76 && humidity < 78)
                return 76;
            if (humidity >= 78 && humidity < 80)
                return 78;
            if (humidity >= 80 && humidity < 82)
                return 80;
            if (humidity >= 82 && humidity < 84)
                return 82;
            if (humidity >= 84 && humidity < 86)
                return 84;
            else
                return (int)Math.Floor(humidity);
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








