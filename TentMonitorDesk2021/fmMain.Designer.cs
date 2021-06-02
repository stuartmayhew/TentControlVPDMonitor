
namespace TentMonitorDesk2021
{
    partial class fmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label maxVPDLabel;
            System.Windows.Forms.Label minVPDLabel;
            System.Windows.Forms.Label nightStartLabel;
            System.Windows.Forms.Label nightEndLabel;
            System.Windows.Forms.Label tempRangeFactorLabel;
            System.Windows.Forms.Label rHRangeFactorLabel;
            System.Windows.Forms.Label tempCalFactorLabel;
            System.Windows.Forms.Label rHCalFactorLabel;
            System.Windows.Forms.Label maxNightRHLabel;
            System.Windows.Forms.Label alertTempLabel;
            System.Windows.Forms.Label alertRHLabel;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea23 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend23 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea24 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend24 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.Label optTempDayLabel;
            System.Windows.Forms.Label optRHDayLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbDialog = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAC2 = new System.Windows.Forms.Label();
            this.lblHumid = new System.Windows.Forms.Label();
            this.lblAC1 = new System.Windows.Forms.Label();
            this.btnRUN = new System.Windows.Forms.Button();
            this.lblDehumidifier = new System.Windows.Forms.Label();
            this.passTimer = new System.Windows.Forms.Timer(this.components);
            this.lblSessionCount = new System.Windows.Forms.Label();
            this.lblTargetTemp = new System.Windows.Forms.Label();
            this.lblTargetRH = new System.Windows.Forms.Label();
            this.waitTimer = new System.Windows.Forms.Timer(this.components);
            this.lblWaitSecs = new System.Windows.Forms.Label();
            this.lbActionList = new System.Windows.Forms.ListBox();
            this.lblVPD = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Hourly = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tentLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tentConrolDataSet = new TentMonitorDesk2021.TentConrolDataSet();
            this.Daily = new System.Windows.Forms.TabPage();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tentLogBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.lbCurrRange = new System.Windows.Forms.Label();
            this.lblCurrTemp = new System.Windows.Forms.Label();
            this.lblAvg = new System.Windows.Forms.Label();
            this.lblHighVPD = new System.Windows.Forms.Label();
            this.lblLowVPD = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.alertRHTextBox = new System.Windows.Forms.TextBox();
            this.settingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alertTempTextBox = new System.Windows.Forms.TextBox();
            this.maxNightTempTextBox = new System.Windows.Forms.TextBox();
            this.maxNightRHTextBox = new System.Windows.Forms.TextBox();
            this.rHCalFactorTextBox = new System.Windows.Forms.TextBox();
            this.tempCalFactorTextBox = new System.Windows.Forms.TextBox();
            this.rHRangeFactorTextBox = new System.Windows.Forms.TextBox();
            this.tempRangeFactorTextBox = new System.Windows.Forms.TextBox();
            this.nightEndTextBox = new System.Windows.Forms.TextBox();
            this.nightStartTextBox = new System.Windows.Forms.TextBox();
            this.minVPDTextBox = new System.Windows.Forms.TextBox();
            this.maxVPDTextBox = new System.Windows.Forms.TextBox();
            this.tentLogTableAdapter = new TentMonitorDesk2021.TentConrolDataSetTableAdapters.TentLogTableAdapter();
            this.settingsTableAdapter = new TentMonitorDesk2021.TentConrolDataSetTableAdapters.SettingsTableAdapter();
            this.tableAdapterManager = new TentMonitorDesk2021.TentConrolDataSetTableAdapters.TableAdapterManager();
            this.btnSetSettings = new System.Windows.Forms.Button();
            this.optTempDayTextBox = new System.Windows.Forms.TextBox();
            this.optRHDayTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lightsLPDTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            maxVPDLabel = new System.Windows.Forms.Label();
            minVPDLabel = new System.Windows.Forms.Label();
            nightStartLabel = new System.Windows.Forms.Label();
            nightEndLabel = new System.Windows.Forms.Label();
            tempRangeFactorLabel = new System.Windows.Forms.Label();
            rHRangeFactorLabel = new System.Windows.Forms.Label();
            tempCalFactorLabel = new System.Windows.Forms.Label();
            rHCalFactorLabel = new System.Windows.Forms.Label();
            maxNightRHLabel = new System.Windows.Forms.Label();
            alertTempLabel = new System.Windows.Forms.Label();
            alertRHLabel = new System.Windows.Forms.Label();
            optTempDayLabel = new System.Windows.Forms.Label();
            optRHDayLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Hourly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tentLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tentConrolDataSet)).BeginInit();
            this.Daily.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tentLogBindingSource1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // maxVPDLabel
            // 
            maxVPDLabel.AutoSize = true;
            maxVPDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maxVPDLabel.Location = new System.Drawing.Point(25, 20);
            maxVPDLabel.Name = "maxVPDLabel";
            maxVPDLabel.Size = new System.Drawing.Size(211, 68);
            maxVPDLabel.TabIndex = 0;
            maxVPDLabel.Text = "The maximum VPD you want\r\n\r\n\r\n\r\n";
            // 
            // minVPDLabel
            // 
            minVPDLabel.AutoSize = true;
            minVPDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            minVPDLabel.Location = new System.Drawing.Point(507, 23);
            minVPDLabel.Name = "minVPDLabel";
            minVPDLabel.Size = new System.Drawing.Size(208, 17);
            minVPDLabel.TabIndex = 2;
            minVPDLabel.Text = "The minimum VPD you want";
            // 
            // nightStartLabel
            // 
            nightStartLabel.AutoSize = true;
            nightStartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nightStartLabel.Location = new System.Drawing.Point(38, 83);
            nightStartLabel.Name = "nightStartLabel";
            nightStartLabel.Size = new System.Drawing.Size(154, 17);
            nightStartLabel.TabIndex = 8;
            nightStartLabel.Text = "Time the lights go OUT";
            // 
            // nightEndLabel
            // 
            nightEndLabel.AutoSize = true;
            nightEndLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nightEndLabel.Location = new System.Drawing.Point(314, 83);
            nightEndLabel.Name = "nightEndLabel";
            nightEndLabel.Size = new System.Drawing.Size(163, 17);
            nightEndLabel.TabIndex = 10;
            nightEndLabel.Text = "Time the lights come ON";
            // 
            // tempRangeFactorLabel
            // 
            tempRangeFactorLabel.AutoSize = true;
            tempRangeFactorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tempRangeFactorLabel.Location = new System.Drawing.Point(39, 331);
            tempRangeFactorLabel.Name = "tempRangeFactorLabel";
            tempRangeFactorLabel.Size = new System.Drawing.Size(182, 17);
            tempRangeFactorLabel.TabIndex = 12;
            tempRangeFactorLabel.Text = "Add(+ or -) to Temp in tests";
            // 
            // rHRangeFactorLabel
            // 
            rHRangeFactorLabel.AutoSize = true;
            rHRangeFactorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rHRangeFactorLabel.Location = new System.Drawing.Point(343, 331);
            rHRangeFactorLabel.Name = "rHRangeFactorLabel";
            rHRangeFactorLabel.Size = new System.Drawing.Size(166, 17);
            rHRangeFactorLabel.TabIndex = 14;
            rHRangeFactorLabel.Text = "Add(+ or -) to RH in tests";
            // 
            // tempCalFactorLabel
            // 
            tempCalFactorLabel.AutoSize = true;
            tempCalFactorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tempCalFactorLabel.Location = new System.Drawing.Point(684, 129);
            tempCalFactorLabel.Name = "tempCalFactorLabel";
            tempCalFactorLabel.Size = new System.Drawing.Size(116, 17);
            tempCalFactorLabel.TabIndex = 18;
            tempCalFactorLabel.Text = "Temp Cal Factor:";
            // 
            // rHCalFactorLabel
            // 
            rHCalFactorLabel.AutoSize = true;
            rHCalFactorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rHCalFactorLabel.Location = new System.Drawing.Point(684, 100);
            rHCalFactorLabel.Name = "rHCalFactorLabel";
            rHCalFactorLabel.Size = new System.Drawing.Size(96, 17);
            rHCalFactorLabel.TabIndex = 20;
            rHCalFactorLabel.Text = "RHCal Factor:";
            // 
            // maxNightRHLabel
            // 
            maxNightRHLabel.AutoSize = true;
            maxNightRHLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maxNightRHLabel.Location = new System.Drawing.Point(850, 464);
            maxNightRHLabel.Name = "maxNightRHLabel";
            maxNightRHLabel.Size = new System.Drawing.Size(98, 17);
            maxNightRHLabel.TabIndex = 22;
            maxNightRHLabel.Text = "max Night RH:";
            maxNightRHLabel.Visible = false;
            // 
            // alertTempLabel
            // 
            alertTempLabel.AutoSize = true;
            alertTempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            alertTempLabel.Location = new System.Drawing.Point(25, 231);
            alertTempLabel.Name = "alertTempLabel";
            alertTempLabel.Size = new System.Drawing.Size(80, 17);
            alertTempLabel.TabIndex = 26;
            alertTempLabel.Text = "alert Temp:";
            // 
            // alertRHLabel
            // 
            alertRHLabel.AutoSize = true;
            alertRHLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            alertRHLabel.Location = new System.Drawing.Point(246, 234);
            alertRHLabel.Name = "alertRHLabel";
            alertRHLabel.Size = new System.Drawing.Size(64, 17);
            alertRHLabel.TabIndex = 28;
            alertRHLabel.Text = "alert RH:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbDialog);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 194);
            this.panel1.TabIndex = 0;
            // 
            // lbDialog
            // 
            this.lbDialog.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDialog.FormattingEnabled = true;
            this.lbDialog.ItemHeight = 24;
            this.lbDialog.Location = new System.Drawing.Point(0, 24);
            this.lbDialog.Name = "lbDialog";
            this.lbDialog.Size = new System.Drawing.Size(995, 196);
            this.lbDialog.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(995, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // lblAC2
            // 
            this.lblAC2.AutoSize = true;
            this.lblAC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAC2.Location = new System.Drawing.Point(1322, 391);
            this.lblAC2.Name = "lblAC2";
            this.lblAC2.Size = new System.Drawing.Size(49, 24);
            this.lblAC2.TabIndex = 1;
            this.lblAC2.Text = "AC2";
            // 
            // lblHumid
            // 
            this.lblHumid.AutoSize = true;
            this.lblHumid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumid.Location = new System.Drawing.Point(1419, 351);
            this.lblHumid.Name = "lblHumid";
            this.lblHumid.Size = new System.Drawing.Size(105, 24);
            this.lblHumid.TabIndex = 2;
            this.lblHumid.Text = "Humidifier";
            // 
            // lblAC1
            // 
            this.lblAC1.AutoSize = true;
            this.lblAC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAC1.Location = new System.Drawing.Point(1322, 351);
            this.lblAC1.Name = "lblAC1";
            this.lblAC1.Size = new System.Drawing.Size(49, 24);
            this.lblAC1.TabIndex = 3;
            this.lblAC1.Text = "AC1";
            // 
            // btnRUN
            // 
            this.btnRUN.BackColor = System.Drawing.Color.Lime;
            this.btnRUN.Location = new System.Drawing.Point(1005, 12);
            this.btnRUN.Name = "btnRUN";
            this.btnRUN.Size = new System.Drawing.Size(131, 49);
            this.btnRUN.TabIndex = 4;
            this.btnRUN.Text = "RUN";
            this.btnRUN.UseVisualStyleBackColor = false;
            this.btnRUN.Click += new System.EventHandler(this.btnRUN_Click);
            // 
            // lblDehumidifier
            // 
            this.lblDehumidifier.AutoSize = true;
            this.lblDehumidifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDehumidifier.Location = new System.Drawing.Point(1419, 391);
            this.lblDehumidifier.Name = "lblDehumidifier";
            this.lblDehumidifier.Size = new System.Drawing.Size(128, 24);
            this.lblDehumidifier.TabIndex = 5;
            this.lblDehumidifier.Text = "Dehumidifier";
            // 
            // passTimer
            // 
            this.passTimer.Interval = 60000;
            this.passTimer.Tick += new System.EventHandler(this.tryTimer_Tick);
            // 
            // lblSessionCount
            // 
            this.lblSessionCount.AutoSize = true;
            this.lblSessionCount.Location = new System.Drawing.Point(1004, 89);
            this.lblSessionCount.Name = "lblSessionCount";
            this.lblSessionCount.Size = new System.Drawing.Size(87, 13);
            this.lblSessionCount.TabIndex = 6;
            this.lblSessionCount.Text = "Session Count: 0";
            // 
            // lblTargetTemp
            // 
            this.lblTargetTemp.AutoSize = true;
            this.lblTargetTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetTemp.Location = new System.Drawing.Point(1036, 460);
            this.lblTargetTemp.Name = "lblTargetTemp";
            this.lblTargetTemp.Size = new System.Drawing.Size(130, 24);
            this.lblTargetTemp.TabIndex = 7;
            this.lblTargetTemp.Text = "Target Temp";
            // 
            // lblTargetRH
            // 
            this.lblTargetRH.AutoSize = true;
            this.lblTargetRH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetRH.Location = new System.Drawing.Point(1036, 499);
            this.lblTargetRH.Name = "lblTargetRH";
            this.lblTargetRH.Size = new System.Drawing.Size(105, 24);
            this.lblTargetRH.TabIndex = 8;
            this.lblTargetRH.Text = "Target RH";
            // 
            // waitTimer
            // 
            this.waitTimer.Interval = 1000;
            this.waitTimer.Tick += new System.EventHandler(this.waitTimer_Tick);
            // 
            // lblWaitSecs
            // 
            this.lblWaitSecs.AutoSize = true;
            this.lblWaitSecs.Location = new System.Drawing.Point(1132, 89);
            this.lblWaitSecs.Name = "lblWaitSecs";
            this.lblWaitSecs.Size = new System.Drawing.Size(86, 13);
            this.lblWaitSecs.TabIndex = 9;
            this.lblWaitSecs.Text = "Wait Seconds: 0";
            // 
            // lbActionList
            // 
            this.lbActionList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActionList.FormattingEnabled = true;
            this.lbActionList.ItemHeight = 20;
            this.lbActionList.Location = new System.Drawing.Point(1314, 12);
            this.lbActionList.Name = "lbActionList";
            this.lbActionList.Size = new System.Drawing.Size(353, 224);
            this.lbActionList.TabIndex = 10;
            // 
            // lblVPD
            // 
            this.lblVPD.AutoSize = true;
            this.lblVPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVPD.Location = new System.Drawing.Point(1011, 131);
            this.lblVPD.Name = "lblVPD";
            this.lblVPD.Size = new System.Drawing.Size(155, 24);
            this.lblVPD.TabIndex = 11;
            this.lblVPD.Text = "CURRENT VPD";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 577);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1688, 300);
            this.panel2.TabIndex = 12;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Hourly);
            this.tabControl1.Controls.Add(this.Daily);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1688, 300);
            this.tabControl1.TabIndex = 0;
            // 
            // Hourly
            // 
            this.Hourly.Controls.Add(this.chart1);
            this.Hourly.Location = new System.Drawing.Point(4, 22);
            this.Hourly.Name = "Hourly";
            this.Hourly.Padding = new System.Windows.Forms.Padding(3);
            this.Hourly.Size = new System.Drawing.Size(1680, 274);
            this.Hourly.TabIndex = 0;
            this.Hourly.Text = "Hourly";
            this.Hourly.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea23.AxisX.IsReversed = true;
            chartArea23.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea23.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea23.InnerPlotPosition.Auto = false;
            chartArea23.InnerPlotPosition.Height = 84.27526F;
            chartArea23.InnerPlotPosition.Width = 90.2298F;
            chartArea23.InnerPlotPosition.Y = 3.90957F;
            chartArea23.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea23);
            this.chart1.DataSource = this.tentLogBindingSource;
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend23.Name = "Legend1";
            this.chart1.Legends.Add(legend23);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series23.Legend = "Legend1";
            series23.Name = "VPD";
            series23.XValueMember = "LogDate";
            series23.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series23.YValueMembers = "VPD";
            series23.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart1.Series.Add(series23);
            this.chart1.Size = new System.Drawing.Size(1674, 268);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // tentLogBindingSource
            // 
            this.tentLogBindingSource.DataMember = "TentLog";
            this.tentLogBindingSource.DataSource = this.tentConrolDataSet;
            // 
            // tentConrolDataSet
            // 
            this.tentConrolDataSet.DataSetName = "TentConrolDataSet";
            this.tentConrolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Daily
            // 
            this.Daily.Controls.Add(this.chart2);
            this.Daily.Location = new System.Drawing.Point(4, 22);
            this.Daily.Name = "Daily";
            this.Daily.Padding = new System.Windows.Forms.Padding(3);
            this.Daily.Size = new System.Drawing.Size(1680, 274);
            this.Daily.TabIndex = 1;
            this.Daily.Text = "Daily";
            this.Daily.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            chartArea24.AxisX.IsReversed = true;
            chartArea24.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea24.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea24.InnerPlotPosition.Auto = false;
            chartArea24.InnerPlotPosition.Height = 84.27526F;
            chartArea24.InnerPlotPosition.Width = 90.2298F;
            chartArea24.InnerPlotPosition.Y = 3.90957F;
            chartArea24.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea24);
            this.chart2.DataSource = this.tentLogBindingSource1;
            this.chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            legend24.Name = "Legend1";
            this.chart2.Legends.Add(legend24);
            this.chart2.Location = new System.Drawing.Point(3, 3);
            this.chart2.Name = "chart2";
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series24.Legend = "Legend1";
            series24.Name = "VPD";
            series24.XValueMember = "LogDate";
            series24.YValueMembers = "VPD";
            this.chart2.Series.Add(series24);
            this.chart2.Size = new System.Drawing.Size(1674, 268);
            this.chart2.TabIndex = 2;
            this.chart2.Text = "chart2";
            // 
            // tentLogBindingSource1
            // 
            this.tentLogBindingSource1.DataMember = "TentLog";
            this.tentLogBindingSource1.DataSource = this.tentConrolDataSet;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Fuchsia;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(1164, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 49);
            this.button1.TabIndex = 13;
            this.button1.Text = "RESET LOG";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbCurrRange
            // 
            this.lbCurrRange.AutoSize = true;
            this.lbCurrRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrRange.Location = new System.Drawing.Point(1311, 501);
            this.lbCurrRange.Name = "lbCurrRange";
            this.lbCurrRange.Size = new System.Drawing.Size(114, 24);
            this.lbCurrRange.TabIndex = 15;
            this.lbCurrRange.Text = "Current RH";
            // 
            // lblCurrTemp
            // 
            this.lblCurrTemp.AutoSize = true;
            this.lblCurrTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrTemp.Location = new System.Drawing.Point(1311, 460);
            this.lblCurrTemp.Name = "lblCurrTemp";
            this.lblCurrTemp.Size = new System.Drawing.Size(139, 24);
            this.lblCurrTemp.TabIndex = 14;
            this.lblCurrTemp.Text = "Current Temp";
            // 
            // lblAvg
            // 
            this.lblAvg.AutoSize = true;
            this.lblAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvg.ForeColor = System.Drawing.Color.Teal;
            this.lblAvg.Location = new System.Drawing.Point(1016, 173);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(135, 24);
            this.lblAvg.TabIndex = 18;
            this.lblAvg.Text = "Average VPD";
            // 
            // lblHighVPD
            // 
            this.lblHighVPD.AutoSize = true;
            this.lblHighVPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighVPD.ForeColor = System.Drawing.Color.Green;
            this.lblHighVPD.Location = new System.Drawing.Point(1025, 291);
            this.lblHighVPD.Name = "lblHighVPD";
            this.lblHighVPD.Size = new System.Drawing.Size(141, 24);
            this.lblHighVPD.TabIndex = 19;
            this.lblHighVPD.Text = "Good Session";
            // 
            // lblLowVPD
            // 
            this.lblLowVPD.AutoSize = true;
            this.lblLowVPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowVPD.ForeColor = System.Drawing.Color.Red;
            this.lblLowVPD.Location = new System.Drawing.Point(1025, 257);
            this.lblLowVPD.Name = "lblLowVPD";
            this.lblLowVPD.Size = new System.Drawing.Size(126, 24);
            this.lblLowVPD.TabIndex = 20;
            this.lblLowVPD.Text = "Bad Session";
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercent.ForeColor = System.Drawing.Color.Green;
            this.lblPercent.Location = new System.Drawing.Point(1024, 358);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(135, 26);
            this.lblPercent.TabIndex = 21;
            this.lblPercent.Text = "Batting Avg";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.btnSetSettings);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(alertRHLabel);
            this.panel3.Controls.Add(this.alertRHTextBox);
            this.panel3.Controls.Add(alertTempLabel);
            this.panel3.Controls.Add(this.alertTempTextBox);
            this.panel3.Controls.Add(this.maxNightTempTextBox);
            this.panel3.Controls.Add(maxNightRHLabel);
            this.panel3.Controls.Add(this.maxNightRHTextBox);
            this.panel3.Controls.Add(rHCalFactorLabel);
            this.panel3.Controls.Add(this.rHCalFactorTextBox);
            this.panel3.Controls.Add(tempCalFactorLabel);
            this.panel3.Controls.Add(this.tempCalFactorTextBox);
            this.panel3.Controls.Add(this.lightsLPDTextBox);
            this.panel3.Controls.Add(rHRangeFactorLabel);
            this.panel3.Controls.Add(this.rHRangeFactorTextBox);
            this.panel3.Controls.Add(tempRangeFactorLabel);
            this.panel3.Controls.Add(this.tempRangeFactorTextBox);
            this.panel3.Controls.Add(nightEndLabel);
            this.panel3.Controls.Add(this.nightEndTextBox);
            this.panel3.Controls.Add(nightStartLabel);
            this.panel3.Controls.Add(this.nightStartTextBox);
            this.panel3.Controls.Add(optRHDayLabel);
            this.panel3.Controls.Add(this.optRHDayTextBox);
            this.panel3.Controls.Add(optTempDayLabel);
            this.panel3.Controls.Add(this.optTempDayTextBox);
            this.panel3.Controls.Add(minVPDLabel);
            this.panel3.Controls.Add(this.minVPDTextBox);
            this.panel3.Controls.Add(maxVPDLabel);
            this.panel3.Controls.Add(this.maxVPDTextBox);
            this.panel3.Location = new System.Drawing.Point(0, 200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(995, 379);
            this.panel3.TabIndex = 22;
            // 
            // alertRHTextBox
            // 
            this.alertRHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "alertRH", true));
            this.alertRHTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertRHTextBox.Location = new System.Drawing.Point(313, 231);
            this.alertRHTextBox.Name = "alertRHTextBox";
            this.alertRHTextBox.Size = new System.Drawing.Size(88, 23);
            this.alertRHTextBox.TabIndex = 29;
            // 
            // settingsBindingSource
            // 
            this.settingsBindingSource.DataMember = "Settings";
            this.settingsBindingSource.DataSource = this.tentConrolDataSet;
            // 
            // alertTempTextBox
            // 
            this.alertTempTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "alertTemp", true));
            this.alertTempTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertTempTextBox.Location = new System.Drawing.Point(111, 228);
            this.alertTempTextBox.Name = "alertTempTextBox";
            this.alertTempTextBox.Size = new System.Drawing.Size(88, 23);
            this.alertTempTextBox.TabIndex = 27;
            // 
            // maxNightTempTextBox
            // 
            this.maxNightTempTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "maxNightTemp", true));
            this.maxNightTempTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxNightTempTextBox.Location = new System.Drawing.Point(845, 464);
            this.maxNightTempTextBox.Name = "maxNightTempTextBox";
            this.maxNightTempTextBox.Size = new System.Drawing.Size(100, 23);
            this.maxNightTempTextBox.TabIndex = 25;
            this.maxNightTempTextBox.Visible = false;
            // 
            // maxNightRHTextBox
            // 
            this.maxNightRHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "maxNightRH", true));
            this.maxNightRHTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxNightRHTextBox.Location = new System.Drawing.Point(845, 461);
            this.maxNightRHTextBox.Name = "maxNightRHTextBox";
            this.maxNightRHTextBox.Size = new System.Drawing.Size(100, 23);
            this.maxNightRHTextBox.TabIndex = 23;
            this.maxNightRHTextBox.Visible = false;
            // 
            // rHCalFactorTextBox
            // 
            this.rHCalFactorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "RHCalFactor", true));
            this.rHCalFactorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rHCalFactorTextBox.Location = new System.Drawing.Point(801, 100);
            this.rHCalFactorTextBox.Name = "rHCalFactorTextBox";
            this.rHCalFactorTextBox.Size = new System.Drawing.Size(100, 23);
            this.rHCalFactorTextBox.TabIndex = 21;
            // 
            // tempCalFactorTextBox
            // 
            this.tempCalFactorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "TempCalFactor", true));
            this.tempCalFactorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempCalFactorTextBox.Location = new System.Drawing.Point(806, 126);
            this.tempCalFactorTextBox.Name = "tempCalFactorTextBox";
            this.tempCalFactorTextBox.Size = new System.Drawing.Size(100, 23);
            this.tempCalFactorTextBox.TabIndex = 19;
            // 
            // rHRangeFactorTextBox
            // 
            this.rHRangeFactorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "RHRangeFactor", true));
            this.rHRangeFactorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rHRangeFactorTextBox.Location = new System.Drawing.Point(515, 325);
            this.rHRangeFactorTextBox.Name = "rHRangeFactorTextBox";
            this.rHRangeFactorTextBox.Size = new System.Drawing.Size(100, 23);
            this.rHRangeFactorTextBox.TabIndex = 15;
            // 
            // tempRangeFactorTextBox
            // 
            this.tempRangeFactorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "tempRangeFactor", true));
            this.tempRangeFactorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempRangeFactorTextBox.Location = new System.Drawing.Point(227, 328);
            this.tempRangeFactorTextBox.Name = "tempRangeFactorTextBox";
            this.tempRangeFactorTextBox.Size = new System.Drawing.Size(100, 23);
            this.tempRangeFactorTextBox.TabIndex = 13;
            // 
            // nightEndTextBox
            // 
            this.nightEndTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "nightEnd", true));
            this.nightEndTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightEndTextBox.Location = new System.Drawing.Point(494, 80);
            this.nightEndTextBox.Name = "nightEndTextBox";
            this.nightEndTextBox.Size = new System.Drawing.Size(100, 23);
            this.nightEndTextBox.TabIndex = 11;
            // 
            // nightStartTextBox
            // 
            this.nightStartTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "nightStart", true));
            this.nightStartTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightStartTextBox.Location = new System.Drawing.Point(208, 77);
            this.nightStartTextBox.Name = "nightStartTextBox";
            this.nightStartTextBox.Size = new System.Drawing.Size(100, 23);
            this.nightStartTextBox.TabIndex = 9;
            // 
            // minVPDTextBox
            // 
            this.minVPDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "minVPD", true));
            this.minVPDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minVPDTextBox.Location = new System.Drawing.Point(735, 23);
            this.minVPDTextBox.Name = "minVPDTextBox";
            this.minVPDTextBox.Size = new System.Drawing.Size(100, 23);
            this.minVPDTextBox.TabIndex = 3;
            // 
            // maxVPDTextBox
            // 
            this.maxVPDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "maxVPD", true));
            this.maxVPDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxVPDTextBox.Location = new System.Drawing.Point(258, 20);
            this.maxVPDTextBox.Name = "maxVPDTextBox";
            this.maxVPDTextBox.Size = new System.Drawing.Size(100, 23);
            this.maxVPDTextBox.TabIndex = 1;
            // 
            // tentLogTableAdapter
            // 
            this.tentLogTableAdapter.ClearBeforeFill = true;
            // 
            // settingsTableAdapter
            // 
            this.settingsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.SettingsTableAdapter = this.settingsTableAdapter;
            this.tableAdapterManager.UpdateOrder = TentMonitorDesk2021.TentConrolDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnSetSettings
            // 
            this.btnSetSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetSettings.Location = new System.Drawing.Point(774, 290);
            this.btnSetSettings.Name = "btnSetSettings";
            this.btnSetSettings.Size = new System.Drawing.Size(132, 39);
            this.btnSetSettings.TabIndex = 30;
            this.btnSetSettings.Text = "Save Settings";
            this.btnSetSettings.UseVisualStyleBackColor = true;
            this.btnSetSettings.Click += new System.EventHandler(this.btnSetSettings_Click);
            // 
            // optTempDayTextBox
            // 
            this.optTempDayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "optTempDay", true));
            this.optTempDayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optTempDayTextBox.Location = new System.Drawing.Point(875, 198);
            this.optTempDayTextBox.Name = "optTempDayTextBox";
            this.optTempDayTextBox.Size = new System.Drawing.Size(100, 23);
            this.optTempDayTextBox.TabIndex = 5;
            // 
            // optTempDayLabel
            // 
            optTempDayLabel.AutoSize = true;
            optTempDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            optTempDayLabel.Location = new System.Drawing.Point(628, 198);
            optTempDayLabel.Name = "optTempDayLabel";
            optTempDayLabel.Size = new System.Drawing.Size(231, 17);
            optTempDayLabel.TabIndex = 4;
            optTempDayLabel.Text = "The Temp you want in your dreams";
            // 
            // optRHDayTextBox
            // 
            this.optRHDayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "optRHDay", true));
            this.optRHDayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optRHDayTextBox.Location = new System.Drawing.Point(875, 243);
            this.optRHDayTextBox.Name = "optRHDayTextBox";
            this.optRHDayTextBox.Size = new System.Drawing.Size(100, 23);
            this.optRHDayTextBox.TabIndex = 7;
            // 
            // optRHDayLabel
            // 
            optRHDayLabel.AutoSize = true;
            optRHDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            optRHDayLabel.Location = new System.Drawing.Point(628, 240);
            optRHDayLabel.Name = "optRHDayLabel";
            optRHDayLabel.Size = new System.Drawing.Size(215, 17);
            optRHDayLabel.TabIndex = 6;
            optRHDayLabel.Text = "The RH you want in your dreams";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(627, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "I will probably ignore these values";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkViolet;
            this.label2.Location = new System.Drawing.Point(28, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(516, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "When do you turn the light off MILITARY TIME WITH THE 00";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkViolet;
            this.label3.Location = new System.Drawing.Point(24, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(516, 39);
            this.label3.TabIndex = 33;
            this.label3.Text = "DIFFERENCE BETWEEN LEAF TEMP AND ROOM TEMP";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkViolet;
            this.label4.Location = new System.Drawing.Point(24, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(633, 26);
            this.label4.TabIndex = 34;
            this.label4.Text = "IF YOU WANT SOME VARIATION + OR - FOR THE TEMP OR RH TEST.";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkViolet;
            this.label5.Location = new System.Drawing.Point(616, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(349, 26);
            this.label5.TabIndex = 35;
            this.label5.Text = "TO CALIBRATE CHEESY EQUIPMENT";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkViolet;
            this.label6.Location = new System.Drawing.Point(28, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(349, 26);
            this.label6.TabIndex = 36;
            this.label6.Text = "WHEN TO SOUND THE ALARM";
            // 
            // lightsLPDTextBox
            // 
            this.lightsLPDTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lightsLPDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "lightsLPD", true));
            this.lightsLPDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lightsLPDTextBox.Location = new System.Drawing.Point(208, 165);
            this.lightsLPDTextBox.Name = "lightsLPDTextBox";
            this.lightsLPDTextBox.Size = new System.Drawing.Size(100, 23);
            this.lightsLPDTextBox.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(1295, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(349, 26);
            this.label7.TabIndex = 36;
            this.label7.Text = "DEVICE STATUS";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1688, 877);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.lblLowVPD);
            this.Controls.Add(this.lblHighVPD);
            this.Controls.Add(this.lblAvg);
            this.Controls.Add(this.lbCurrRange);
            this.Controls.Add(this.lblCurrTemp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblVPD);
            this.Controls.Add(this.lbActionList);
            this.Controls.Add(this.lblWaitSecs);
            this.Controls.Add(this.lblTargetRH);
            this.Controls.Add(this.lblTargetTemp);
            this.Controls.Add(this.lblSessionCount);
            this.Controls.Add(this.lblDehumidifier);
            this.Controls.Add(this.btnRUN);
            this.Controls.Add(this.lblAC1);
            this.Controls.Add(this.lblHumid);
            this.Controls.Add(this.lblAC2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.fmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Hourly.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tentLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tentConrolDataSet)).EndInit();
            this.Daily.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tentLogBindingSource1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbDialog;
        private System.Windows.Forms.Label lblAC2;
        private System.Windows.Forms.Label lblHumid;
        private System.Windows.Forms.Label lblAC1;
        private System.Windows.Forms.Button btnRUN;
        private System.Windows.Forms.Label lblDehumidifier;
        private System.Windows.Forms.Timer passTimer;
        private System.Windows.Forms.Label lblSessionCount;
        private System.Windows.Forms.Label lblTargetTemp;
        private System.Windows.Forms.Label lblTargetRH;
        private System.Windows.Forms.Timer waitTimer;
        private System.Windows.Forms.Label lblWaitSecs;
        private System.Windows.Forms.ListBox lbActionList;
        private System.Windows.Forms.Label lblVPD;
        private System.Windows.Forms.Panel panel2;
        private TentConrolDataSet tentConrolDataSet;
        private System.Windows.Forms.BindingSource tentLogBindingSource;
        private TentConrolDataSetTableAdapters.TentLogTableAdapter tentLogTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Hourly;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage Daily;
        private System.Windows.Forms.Label lbCurrRange;
        private System.Windows.Forms.Label lblCurrTemp;
        private System.Windows.Forms.Label lblAvg;
        private System.Windows.Forms.Label lblHighVPD;
        private System.Windows.Forms.Label lblLowVPD;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.BindingSource tentLogBindingSource1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.BindingSource settingsBindingSource;
        private TentConrolDataSetTableAdapters.SettingsTableAdapter settingsTableAdapter;
        private TentConrolDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox rHCalFactorTextBox;
        private System.Windows.Forms.TextBox tempCalFactorTextBox;
        private System.Windows.Forms.TextBox rHRangeFactorTextBox;
        private System.Windows.Forms.TextBox tempRangeFactorTextBox;
        private System.Windows.Forms.TextBox nightEndTextBox;
        private System.Windows.Forms.TextBox nightStartTextBox;
        private System.Windows.Forms.TextBox minVPDTextBox;
        private System.Windows.Forms.TextBox maxVPDTextBox;
        private System.Windows.Forms.TextBox alertRHTextBox;
        private System.Windows.Forms.TextBox alertTempTextBox;
        private System.Windows.Forms.TextBox maxNightTempTextBox;
        private System.Windows.Forms.TextBox maxNightRHTextBox;
        private System.Windows.Forms.Button btnSetSettings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox optRHDayTextBox;
        private System.Windows.Forms.TextBox optTempDayTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lightsLPDTextBox;
        private System.Windows.Forms.Label label7;
    }
}

