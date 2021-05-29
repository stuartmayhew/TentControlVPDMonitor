using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            this.tentLogTableAdapter.Fill(this.tentConrolDataSet.TentLog);
            settings = db.Settings.FirstOrDefault();
            MasterDeviceList = new DeviceList();
            MasterDeviceList.deviceList = SetupDevices();
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

        public void runSession()
        {
            
            SessionCount++;
            if (SessionCount == 60)
            {
                Reset();
                return;
            }
            probeData = new ProbeData();
            LogData(probeData);
            AddDialog("Probe Data: Temp = " + probeData.Temp + " RH = " + probeData.Humidity);

            if(probeData.Temp > 86.00M)
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

            if (probeData.Humidity > 66.0M)
            {
                LowerHeat("humidity too high");
            }


            if (probeData.VPD < 1M || probeData.VPD > 1.3M)
            {
                GetBestTemp();
                GetBestHumidity();
            }
            if (probeData.VPD > .8M && probeData.VPD < 1.35M)
            {
                inRangeCount++;
                CheckHumidity();
            }
            else
            {
                outRangeCount++;
            }





            SetLabels();

            if (lbActionList.Items.Count > 5)
                lbActionList.Items.Clear();
            foreach(var act in probeData.ActionList)
            {
                lbActionList.Items.Add(act);
            }


            chart1.DataBind();
            chart1.Refresh();

            chart2.DataBind();
            chart2.Refresh();
        }

        private void CheckHumidity()
        {
            var lowRH = GetLowRH(probeData.Temp);
            var highRH = GetHighRH(probeData.Temp);
            var avg = ((highRH + lowRH) / 2);
            if (probeData.Humidity < avg)
            {
                RaiseRH("Check Humidity");
            }
            else
            {
                LowerRH("Check Humidity");
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
                if (Humidifier.State == 0 && Dehumid.State == 1)
                {
                    var newTarget = GetNewTemp(probeData.Humidity);
                    RethinkTargetTemp(newTarget);
                }
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

            if (targetTemp > 0)
                tryTemp = targetTemp;
            else
                tryTemp = settings.optTempDay;

            if (probeData.Temp < tryTemp)
            { //toocold
                // see if humidity too high. 
                lowRH = GetLowRH(tryTemp);
                highRH = GetHighRH(tryTemp);
                if (probeData.Humidity < highRH && probeData.Humidity > lowRH)
                {
                    LowerRH("Get Best Temp");
                }
                RaiseHeat("Get Best Temp");
            }
            else if (probeData.Temp >= tryTemp)
            { //too hot
                LowerHeat("Get Best Temp");
                lowRH = GetLowRH(tryTemp);
                highRH = GetHighRH(tryTemp);
                
                if (probeData.Humidity < highRH && probeData.Humidity > lowRH)
                {
                    RaiseRH("Get Best Temp");
                }
                else if (probeData.Humidity > highRH && probeData.Temp < (tryTemp - 2))
                {
                    LowerRH("Get Best Temp");
                }
            }
            if (probeData.VPD < .9M)
                RethinkTargetTemp();
            else if (probeData.VPD > 1.3M)
                RethinkTargetTemp();
            SetLabels();

        }

        private void RethinkTargetTemp(decimal target = 0)
        {
            if (target == 0)
                target = settings.optTempDay;
            if (target > 0 && target <= 85)
                targetTemp = (int)Math.Floor(target);
            else
                targetTemp = 85;

            lowRH = GetLowRH(targetTemp);
            highRH = GetHighRH(targetTemp);

            var dList = new DeviceList();
            if (probeData.Temp <= targetTemp - 1)
            {
                RaiseHeat("RethinkTargetTemp");
            }
            else if (probeData.Temp > targetTemp + 2)
            {
                LowerHeat("RethinkTargetTemp");
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
            if (lbDialog.Items.Count > 10)
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
            if (currVPD < .9M || currVPD > 1.35M)
                vpdOutOfRange = true;

            lblCurrTemp.Text = "Current Temp: " + probeData.Temp.ToString();
            var lRH = GetLowRH(probeData.Temp);
            var hRH = GetHighRH(probeData.Temp);
            lbCurrRange.Text = "Curr RH Range: " + lRH + " to " + hRH;

            var dList = new DeviceList();

          
            lblAvg.Text = "Average VPD: " + db.TentLogs.Average(x => x.VPD).ToString();
            lblLowVPD.Text = "Low VPD:" + db.TentLogs.Min(x => x.VPD).ToString();
            lblHighVPD.Text = "High VPD:" + db.TentLogs.Max(x => x.VPD).ToString();


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
            lblVPD.Text = "VPD = " + currVPD.ToString();
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
            chart1.DataSource = tentLogTableAdapter.Fill(this.tentConrolDataSet.TentLog);
            chart2.DataSource = tentLogTableAdapter.FillBy(this.tentConrolDataSet.TentLog);

            chart1.DataBind();
            chart2.DataBind();
        }
        private decimal GetHighRH(decimal temp)
        {
            var intTemp = (int)Math.Floor(temp);
            var lookups = db.TempRHRange.ToList();
            lookups = lookups.Where(x => x.Temp >= (temp - 2)).ToList();
            foreach(var look in lookups)
            {
                if (((int)look.Temp) <= intTemp)
                    continue;
                else
                    return look.HighRH;
            }
            return 65.0M;
        }

        private decimal GetLowRH(decimal temp)
        {
            var intTemp = (int)Math.Floor(temp);
            var lookups = db.TempRHRange.ToList();
            lookups = lookups.Where(x => x.Temp >= (temp - 2)).ToList();
            foreach (var look in lookups)
            {
                if (((int)look.Temp) <= temp)
                    continue;
                else
                    return look.LowRH;
            }
            return 55.0M;
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
                tt.TargetHumid = isNight == true ? settings.optRHNight : settings.optRHDay;
                tt.TargetTemp = isNight == true ? settings.optTempNight : settings.optTempDay;
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
            Reset();
        }

        public void Reset()
        {
            targetTemp = (int)settings.optTempDay;
            runSession();
        }

        public void RaiseHeat(string source)
        {
            if (targetTemp > 0 && probeData.Temp < targetTemp)
                return;
            if (MasterDeviceList.GetState(AC1) == 0)
            {
                MasterDeviceList.SetState(AC1, 1, probeData);
                probeData.ActionList.Add("Turned on AC in " + source);
            }
        }
        public void LowerHeat(string source)
        {
            if (targetTemp > 0 && probeData.Temp > targetTemp)
                return;
            if (MasterDeviceList.GetState(AC1) == 1)
            {
                MasterDeviceList.SetState(AC1, 0, probeData);
                probeData.ActionList.Add("Turned off AC in " + source);
            }
        }

        public void RaiseRH(string source)
        {
            if (MasterDeviceList.GetState(Humidifier) == 0)
            {
                MasterDeviceList.SetState(Humidifier, 1, probeData);
                probeData.ActionList.Add("Turned on Humidifier in " + source);
            }

            if (MasterDeviceList.GetState(Dehumid) == 1)
            {
                MasterDeviceList.SetState(Dehumid, 0, probeData);
                probeData.ActionList.Add("Turned off deHumidifier in " + source);
            }
        }
        public void LowerRH(string source)
        {

            if (MasterDeviceList.GetState(Humidifier) == 1)
            {
                MasterDeviceList.SetState(Humidifier, 0, probeData);
                probeData.ActionList.Add("Turned off Humidifier in " + source);
            }

            if (MasterDeviceList.GetState(Dehumid) == 0)
            {
                MasterDeviceList.SetState(Dehumid, 1, probeData);
                probeData.ActionList.Add("Turned on deHumidifier in " + source);
            }
        }

    }
}
