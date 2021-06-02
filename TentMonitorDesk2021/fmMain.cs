using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TentMonitorDesk2021.Helpers;


namespace TentMonitorDesk2021
{
    public partial class fmMain : Form
    {
        public TentData db = new TentData();
        public Device AC1 = null;
        public Device AC2 = null;
        public Device Humidifier = null;
        public Device Dehumid = null;

        public ProbeData probeData;
        public DeviceList MasterDeviceList;

        public Settings settings;

        public int targetTemp = 0;
        public decimal lowRH = 0;
        public decimal highRH = 0;

        public int SessionCount = 0;

        public int inRangeCount = 0;
        public int outRangeCount = 0;


        public fmMain()
        {
            InitializeComponent();
        }

        private void fmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tentConrolDataSet.Settings' table. You can move, or remove it, as needed.
            this.settingsTableAdapter.Fill(this.tentConrolDataSet.Settings);
            ////this.tentLogTableAdapter.GetCurrent(this.tentConrolDataSet.TentLog);
            //chart1.DataSource = tentLogTableAdapter.GetCurrent(this.tentConrolDataSet.TentLog);
            //chart2.DataSource = tentLogTableAdapter.GetDaily(this.tentConrolDataSet.TentLog);
            //chart1.DataBind();
            //chart2.DataBind();
            RefreshCharts();
            settings = db.Settings.FirstOrDefault();
            MasterDeviceList = new DeviceList();
            MasterDeviceList.deviceList = SetupDevices();
        }

        private void RefreshCharts()
        {
            var connStr = ConfigurationManager.ConnectionStrings["TentData2"].ConnectionString;
            var dg = new clsDataGetter(connStr);
            string sql = "SELECT TOP (50) LogDate, VPD FROM TentLog ORDER BY LogDate DESC";
            DataSet ds = dg.GetDataSet(sql);
            chart1.DataSource = ds;
            chart1.DataBind();


            sql = "SELECT CAST(LogDate AS date) AS LogDate, AVG(VPD) AS VPD FROM TentLog GROUP BY CAST(LogDate AS date) ORDER BY LogDate DESC";
            var ds2 = dg.GetDataSet(sql);
            chart2.DataSource = ds2;
            chart2.DataBind();
        }


        private void btnRUN_Click(object sender, EventArgs e)
        {
            try
            {
                runSession();
            }
            catch(Exception ex)
            {
                AddDialog(ex.Message);
            }
            waitTimer.Enabled = true;
            passTimer.Start();
        }

        private void DoNight()
        {

            probeData = new ProbeData();

            MasterDeviceList = new DeviceList();
            MasterDeviceList.deviceList = SetupDevices();

            if (probeData.Humidity > settings.maxNightRH)
                LowerRH("Do Night");
            else
                RaiseRH("Do Night");

            AddDialog("Temp: " + probeData.Temp + "  RH: " + probeData.Humidity);
            if (probeData.Temp > settings.maxNightTemp)
                TurnOnAC("Do Night");
            else
            {
                TurnOffAC("Do Night");
            }
            SetLabels();
            lblVPD.Text = "NIGHT MODE DON'T CARE";
        }

        public void runSession()
        {
            bool nightMode = false;
            bool wakeUp = false;
            var milTimeStr = DateTime.Now.ToString("HHmm");
            var settingsStartStr = settings.nightStart.ToString("##.");
            var settingsEndStr = settings.nightEnd.ToString("##.");


            var currTimeInt = int.Parse(milTimeStr);
            var startTimeInt = int.Parse(settingsStartStr);
            var endTimeInt = int.Parse(settingsEndStr);
            var wakeTimeInt = endTimeInt - 70;

            if (currTimeInt >= startTimeInt && currTimeInt < wakeTimeInt)
            {
                nightMode = true;
            }

            if (nightMode)
            {
                DoNight();
                lblVPD.Text = "NIGHT MODE DON'T CARE";
                return;
            }
                
            SessionCount++;
            if (SessionCount % 60 == 0)
            {
                Reset();
                return;
            }
            probeData = new ProbeData();
            LogData(probeData);
            AddDialog("Probe Data: Temp = " + probeData.Temp + " RH = " + probeData.Humidity);

            if(probeData.Temp > 86 )
            {
                if (AC1.State == 0)
                {
                    MasterDeviceList.SetState(AC1, 1, probeData);
                    probeData.ActionList.Add("Turned on AC because temp > 86");
                    if (Humidifier.State == 0)
                    {
                        MasterDeviceList.SetState(Humidifier, 1, probeData);
                        probeData.ActionList.Add("Turned on Humidifier because temp > 86");
                        MasterDeviceList.SetState(Dehumid, 0, probeData);
                        probeData.ActionList.Add("Turned off deHumidifier because temp > 86");
                    }
                    SetLabels();
                    return;
                }
            }

            if (probeData.Humidity > 68.0M)
            {
                TurnOnAC("humidity too high");
                LowerRH("humidity too high");
            }

            if (probeData.VPD < settings.minVPD || probeData.VPD > settings.maxVPD)
            {
                if (VPDRangeLow(probeData.VPD))
                {
                    RaiseVPD();
                }

                else if (VPDRangeHigh(probeData.VPD))
                {
                    LowerVPD();
                }
            }
            CheckHumidity();



            //if (probeData.VPD < settings.minVPD || probeData.VPD > settings.maxVPD)
            //{
            //    GetBestTemp();
            //    GetBestHumidity();
            //}
            //if (probeData.VPD > settings.minVPD && probeData.VPD < settings.maxVPD)
            //{
            //    CheckHumidity();
            //}

            //if (probeData.Temp < settings.optTempDay + 2 && probeData.Humidity > GetHighRH(probeData.Temp))
            //{
            //    RaiseHeat("temp too low, humid too high");
            //}
            //else
            //{
            //    LowerHeat("temp is good, rh is good, ac on");
            //}





            SetLabels();

            //if (lbActionList.Items.Count > 5)
            //    lbActionList.Items.Clear();
            foreach(var act in probeData.ActionList)
            {
                lbActionList.Items.Add(act);
            }
            lbActionList.SelectedIndex = lbActionList.Items.Count - 1;

            chart1.DataSource = tentLogTableAdapter.GetCurrent(this.tentConrolDataSet.TentLog);
            chart2.DataSource = tentLogTableAdapter.GetDaily(this.tentConrolDataSet.TentLog);

            chart1.DataBind();
            chart1.Refresh();

            chart2.DataBind();
            chart2.Refresh();
        }

        private void LowerVPD()
        {
            RaiseRH("Lower VPD");
            if (probeData.Temp < 85)
                TurnOffAC("Lower VPD");
        }

        private void RaiseVPD()
        {
            LowerRH("Raise VPD");
            if (probeData.Temp > 65)
                TurnOnAC("RaiseVPD");
        }

        private bool VPDRangeHigh(decimal vPD)
        {
            var vpdRange = settings.maxVPD + settings.minVPD;
            var mid = vpdRange / 2;
            if (vPD > (mid))
                return true;
            else return false;
        }

        private bool VPDRangeLow(decimal vPD)
        {
            var vpdRange = settings.maxVPD + settings.minVPD;
            var mid = vpdRange / 2;
            if (vPD < (mid))
                return true;
            else return false;
        }

        private void CheckHumidity()
        {
            var lowRH = GetLowRH(probeData.Temp);
            var highRH = GetHighRH(probeData.Temp);
            var avg = ((highRH + lowRH) / 2);
            if (probeData.Humidity < avg)
            {
                RaiseRH("Check Humidity");
                TurnOnAC("Check Humidity");
            }
            else
            {
                LowerRH("Check Humidity");
                TurnOffAC("Check Humidity");
            }
        }

        private void GetBestHumidity()
        {
            var dList = new DeviceList();
            var temp = probeData.Temp;
            lowRH = GetLowRH(targetTemp);
            highRH = GetHighRH(targetTemp);
            var highRHCurrent = GetHighRH(probeData.Temp);
            if (probeData.Humidity > highRHCurrent)
            {
                LowerRH("Get Best Humidity");
                //if (Humidifier.State == 0 && Dehumid.State == 1)
                //{
                //    var newTarget = GetNewTemp(probeData.Humidity);
                //    RethinkTargetTemp(newTarget);
                //}
            }
            if (probeData.Humidity < lowRH)
            {
                RaiseRH("Get Best Humidity");
            }

        }
        private void GetBestTemp()
        {
            var dList = new DeviceList();
            decimal startSessionTemp = 0;
            decimal tryTemp = 0;
            if (startSessionTemp == 0)
                startSessionTemp = probeData.Temp;

            tryTemp = probeData.Temp;

            if (probeData.Temp < tryTemp)
            { //toocold
                // see if humidity too high. 
                lowRH = GetLowRH(tryTemp);
                highRH = GetHighRH(tryTemp);
                if (probeData.Humidity > highRH)
                {
                    LowerRH("Get Best Temp");
                }
                else if (probeData.Humidity < lowRH)
                {
                    RaiseRH("Get Best Temp");
                }
                    
                TurnOffAC("Get Best Temp");
            }
            else if (probeData.Temp >= tryTemp)
            { //too hot
                TurnOnAC("Get Best Temp");
                lowRH = GetLowRH(tryTemp);
                highRH = GetHighRH(tryTemp);

                if (probeData.Humidity > highRH)
                {
                    LowerRH("Get Best Temp");
                }
                else if (probeData.Humidity < lowRH)
                {
                    RaiseRH("Get Best Temp");
                }
            }
            //if (probeData.VPD < settings.minVPD)
            //    RethinkTargetTemp();
            //else if (probeData.VPD > settings.maxVPD)
            //    RethinkTargetTemp();
            SetLabels();

        }

        private void RethinkTargetTemp(decimal target = 0)
        {
            if (target == 0)
                target = settings.optTempDay;
            if (target > 0 && target <= 85)
                targetTemp = (int)Math.Floor(target);
            else if (probeData.Humidity > settings.optRHDay)
                targetTemp = 85;
            else
                targetTemp = 80;

            lowRH = GetLowRH(targetTemp);
            highRH = GetHighRH(targetTemp);

            var dList = new DeviceList();
            if (probeData.Temp <= targetTemp)
            {
                TurnOffAC("RethinkTargetTemp");
            }
            else if (probeData.Temp > targetTemp)
            {
                TurnOnAC("RethinkTargetTemp");
            }
            SetLabels();
       }

        private List<Device> SetupDevices()
        {
            var deviceList = new DeviceList();
            
            var devices = deviceList.GetDevices();
            AC1 = devices.Where(x => x.alias == "ac plug").FirstOrDefault();
            var hum = devices.Where(x => x.alias == "humidity").FirstOrDefault();
            //AC2 = devices.Where(x => x.alias == "ac plug2").FirstOrDefault();
            Dehumid = devices.Where(x => x.alias == "dehumid").FirstOrDefault();
            Humidifier = devices.Where(x => x.alias == "humidity").FirstOrDefault();
            return devices;
        }

        private void AddDialog(string v)
        {
            AddListBoxText(v);
        }

        private void AddListBoxText(string v)
        {
            if (lbDialog.Items.Count > 5)
                lbDialog.Items.Clear();
            lbDialog.Items.Add(v);
        }


        private void SetLabels()
        {
            if (targetTemp == 0)
                targetTemp = (int)Math.Floor(settings.optTempDay);
            lblTargetTemp.Text = "Target Temp: " + targetTemp;
            lowRH = GetLowRH(targetTemp);
            highRH = GetHighRH(targetTemp);

            var vpdOutOfRange = false;
            var currVPD = probeData.VPD;
            if (currVPD < (settings.minVPD - .1M)  || currVPD > (settings.maxVPD + .1M))
                vpdOutOfRange = true;

            lblCurrTemp.Text = "Current Temp: " + probeData.Temp.ToString("#.##");
            var lRH = GetLowRH(probeData.Temp);
            var hRH = GetHighRH(probeData.Temp);
            lbCurrRange.Text = "Curr RH Range: " + lRH + " to " + hRH;

            var dList = new DeviceList();


            var vpdavg = db.TentLogs.Average(x => x.VPD);
            lblAvg.Text = "Average VPD: " + vpdavg.ToString();

            var connStr = ConfigurationManager.ConnectionStrings["TentData2"].ConnectionString;
            var dg = new clsDataGetter(connStr);

            int badSession = dg.GetScalarInteger("select count(*) FROM TentLog WHERE VPD < " + (settings.minVPD - .1M).ToString() + "  OR VPD > " + (settings.maxVPD + .1M).ToString());
            int goodSession = dg.GetScalarInteger("select count(*) FROM TentLog WHERE VPD >" + (settings.minVPD - .1M).ToString() + "  AND VPD  < " + (settings.maxVPD + .1M).ToString());
            int sessionCount = badSession + goodSession;
            var diff = (decimal)badSession / sessionCount;
            var percent = 100 - (diff * 100);

            lblLowVPD.Text = "Minutes out of VPD range: " + badSession.ToString();
            lblHighVPD.Text = "Minutes in VPD range: " + goodSession.ToString();
            lblPercent.Text = "Batting Avg: " + percent.ToString("#.##") + "%";


            AC1.State = dList.GetState(AC1);
            Humidifier.State = dList.GetState(Humidifier);
            Dehumid.State = dList.GetState(Dehumid);

            if (AC1.State == 1)
                lblAC1.ForeColor = Color.Green;
            else
                lblAC1.ForeColor = Color.Red;

            //if (AC2.State == 1)
            //    lblAC2.ForeColor = Color.Green;
            //else
            //    lblAC2.ForeColor = Color.Red;

            if (Humidifier.State == 1)
                lblHumid.ForeColor = Color.Green;
            else
                lblHumid.ForeColor = Color.Red;

            if (Dehumid.State == 1)
                lblDehumidifier.ForeColor = Color.Green;
            else
                lblDehumidifier.ForeColor = Color.Red;

            lblSessionCount.Text = "Session Count: " + SessionCount;
            lblTargetRH.Text = "RH Range: " + lowRH + " to " + highRH;

            lblVPD.ForeColor = Color.Red;
            lblVPD.Text = "VPD = " + currVPD.ToString("#.##");
            if (vpdOutOfRange == false)
                lblVPD.ForeColor = Color.Green;
        }

        private void tryTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                runSession();
            }
            catch (Exception ex)
            {
                AddDialog(ex.Message);
            }
            RefreshCharts();
        }
        private decimal GetLowRH(decimal temp)
        {
            double dTemp = convertToDouble(temp);

            double dHum = 0;

            var vpd = .8;

            double minVPDd = convertToDouble(settings.minVPD);
            double maxVPDd = convertToDouble(settings.maxVPD);

            for (double i = 90; i > 30; i--)
            {
                dHum = i;
                vpd = 3.386 * (Math.Exp(17.863 - 9621 / ((dTemp - 4) + 460)) - (dHum / 100) * Math.Exp(17.863 - 9621 / (dTemp + 460)));
                if (Math.Round(vpd,1) == maxVPDd )
                    return convertToDecimal(dHum);

            }
            return 65.0M;
        }

        private decimal GetHighRH(decimal temp)
        {
            double dTemp = convertToDouble(temp);

            double dHum = 0;

            var vpd = .8;

            double minVPDd = convertToDouble(settings.minVPD);
            double maxVPDd = convertToDouble(settings.maxVPD);

            for (double i = 90;i > 30; i--)
            {
                dHum = i;
                vpd = 3.386 * (Math.Exp(17.863 - 9621 / ((dTemp - 4) + 460)) - (dHum / 100) * Math.Exp(17.863 - 9621 / (dTemp + 460)));
                if (Math.Round(vpd, 1) == minVPDd)
                    return convertToDecimal(dHum);

            }

            return 55M;
        }

        private double convertToDouble(decimal dec)
        {
            var decStr = dec.ToString();
            return double.Parse(decStr);
        }

        private decimal convertToDecimal (double dub)
        {
            var dubStr = dub.ToString();
            return decimal.Parse(dubStr);
        }

        private decimal GetNewTemp(decimal RH)
        {
            var intRH = (int)Math.Floor(RH);
            var lookups = db.TempRHRange.ToList();
            foreach (var look in lookups)
            {
                if (((int)look.HighRH) <= intRH)
                    continue;
                else
                    return look.Temp;
            }
            return 85M;
        }

        private void waitTimer_Tick(object sender, EventArgs e)
        {
            lblWaitSecs.Text = DateTime.Now.Second.ToString();
            if (DateTime.Now.Second == 1)
            {
                runSession();
            }
        }


        private void LogData(ProbeData data)
        {
            var devList = MasterDeviceList.deviceList;

            
            var hum = devList.Where(x => x.alias == "humidity").FirstOrDefault();
            var ac = devList.Where(x => x.alias == "ac plug").FirstOrDefault();
            var dehumid = devList.Where(x => x.alias == "dehumid").FirstOrDefault();

            var tt = new TentLog();
            tt.AcON = ac.State == 1;
            tt.HumidON = hum.State == 1;
            tt.DehumidON = dehumid.State == 1;

            var logHour = DateTime.Now.Hour;
            var logMin = DateTime.Now.Minute / 100;
            var newLogDate = (decimal)logHour + logMin;
            tt.LogDate = DateTime.Now;

            tt.Temp = data.Temp;
            tt.Humid = data.Humidity;
            tt.VPD = data.VPD;

            using (var db = new TentData())
            {
                var settings = db.Settings.FirstOrDefault();
                var nightStart = settings.nightStart;
                var nightEnd = settings.nightEnd;
                var timeNow = int.Parse(DateTime.Now.ToString("HH")) * 100;
                var isNight = (timeNow > nightStart && timeNow < nightEnd);
                tt.LightsOff = isNight;
                tt.TargetHumid = settings.optRHDay;
                tt.TargetTemp = settings.optTempDay;
                try
                {
                    if (tt.VPD > 0)
                    {
                        db.TentLogs.Add(tt);
                        db.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    data.ActionList.Add(ex.Message);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var connStr = ConfigurationManager.ConnectionStrings["TentData2"].ConnectionString;
            var dg = new clsDataGetter(connStr);
            dg.RunCommand("DELETE FROM TENTLOG WHERE LOGID > 1");
            dg.RunCommand("UPDATE TentLog SET LogDate = GetDate()");

        }

        public void Reset()
        {
            targetTemp = (int)settings.optTempDay;
            runSession();
        }

        public bool TurnOffAC(string source)
        {
            if (MasterDeviceList.GetState(AC1) == 1)
            {
                MasterDeviceList.SetState(AC1, 0, probeData);
                probeData.ActionList.Add("Turned off AC in " + source);
                return true;
            }
            return false;
        }
        public bool TurnOnAC(string source)
        {
            if (MasterDeviceList.GetState(AC1) == 0)
            {
                MasterDeviceList.SetState(AC1, 1, probeData);
                probeData.ActionList.Add("Turned on AC in " + source);
                return true;
            }
            return false;
        }

        public bool RaiseRH(string source)
        {
            var retVal = false;
            if (MasterDeviceList.GetState(Humidifier) == 0)
            {
                MasterDeviceList.SetState(Humidifier, 1, probeData);
                probeData.ActionList.Add("Turned on Humidifier in " + source);
                retVal = true;
            }

            if (MasterDeviceList.GetState(Dehumid) == 1)
            {
                MasterDeviceList.SetState(Dehumid, 0, probeData);
                probeData.ActionList.Add("Turned off deHumidifier in " + source);
                retVal = true;
            }
            return retVal;
        }
        public bool LowerRH(string source)
        {
            var retVal = false;

            if (MasterDeviceList.GetState(Humidifier) == 1)
            {
                MasterDeviceList.SetState(Humidifier, 0, probeData);
                probeData.ActionList.Add("Turned off Humidifier in " + source);
                retVal = true;
            }

            if (MasterDeviceList.GetState(Dehumid) == 0)
            {
                MasterDeviceList.SetState(Dehumid, 1, probeData);
                probeData.ActionList.Add("Turned on deHumidifier in " + source);
                retVal = true;
            }
            if (retVal && probeData.Temp < (settings.optTempDay + 3))
            {
                TurnOffAC("Lower RH");
            }
            return retVal;
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playSimpleSound();
        }


        private void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"c:\TentMonitor\Alert.wav");
            simpleSound.Play();
        }

        private void btnSetSettings_Click(object sender, EventArgs e)
        {
            List<SettingsGuy> settingsList = new List<SettingsGuy>();
            foreach (Control c in panel3.Controls)
            {
                if (c is TextBox)
                {
                    if (string.IsNullOrEmpty(c.Text))
                    {
                        c.Text = "0";
                    }
                        
                    settingsList.Add(new SettingsGuy(c.Name,c.Text));
                }
            }

            var connStr = ConfigurationManager.ConnectionStrings["TentData2"].ConnectionString;
            var dg = new clsDataGetter(connStr);

            string UPDATEsql = "INSERT INTO  Settings (";
            string INSERTsql = "VALUES (";

            foreach(var tSetting in settingsList)
            {
                UPDATEsql += tSetting.columnName.Replace("TextBox","") + ",";
                INSERTsql += tSetting.stringVal + ",";
            }

            UPDATEsql = UPDATEsql.Substring(0, UPDATEsql.Length - 1);
            UPDATEsql += ")";

            INSERTsql = INSERTsql.Substring(0, INSERTsql.Length - 1);
            INSERTsql += ")";

            dg.RunCommand("TRUNCATE TABLE Settings");

            var sql = UPDATEsql + INSERTsql;

            dg.RunCommand(sql);
            settingsTableAdapter.Fill(this.tentConrolDataSet.Settings);
            settings = db.Settings.FirstOrDefault();
        }

        public class SettingsGuy
        {
            public string columnName { get; set; }
            public string stringVal { get; set; }
            public SettingsGuy(string col, string txt)
            {
                columnName = col;
                stringVal = txt;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
