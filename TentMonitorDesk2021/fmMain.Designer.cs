
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbDialog = new System.Windows.Forms.ListBox();
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
            this.button1 = new System.Windows.Forms.Button();
            this.tentLogTableAdapter = new TentMonitorDesk2021.TentConrolDataSetTableAdapters.TentLogTableAdapter();
            this.lbCurrRange = new System.Windows.Forms.Label();
            this.lblCurrTemp = new System.Windows.Forms.Label();
            this.lblAvg = new System.Windows.Forms.Label();
            this.lblHighVPD = new System.Windows.Forms.Label();
            this.lblLowVPD = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Hourly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tentLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tentConrolDataSet)).BeginInit();
            this.Daily.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbDialog);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 430);
            this.panel1.TabIndex = 0;
            // 
            // lbDialog
            // 
            this.lbDialog.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDialog.FormattingEnabled = true;
            this.lbDialog.ItemHeight = 24;
            this.lbDialog.Location = new System.Drawing.Point(0, 0);
            this.lbDialog.Name = "lbDialog";
            this.lbDialog.Size = new System.Drawing.Size(759, 436);
            this.lbDialog.TabIndex = 0;
            // 
            // lblAC2
            // 
            this.lblAC2.AutoSize = true;
            this.lblAC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAC2.Location = new System.Drawing.Point(795, 525);
            this.lblAC2.Name = "lblAC2";
            this.lblAC2.Size = new System.Drawing.Size(49, 24);
            this.lblAC2.TabIndex = 1;
            this.lblAC2.Text = "AC2";
            // 
            // lblHumid
            // 
            this.lblHumid.AutoSize = true;
            this.lblHumid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumid.Location = new System.Drawing.Point(925, 484);
            this.lblHumid.Name = "lblHumid";
            this.lblHumid.Size = new System.Drawing.Size(105, 24);
            this.lblHumid.TabIndex = 2;
            this.lblHumid.Text = "Humidifier";
            // 
            // lblAC1
            // 
            this.lblAC1.AutoSize = true;
            this.lblAC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAC1.Location = new System.Drawing.Point(795, 484);
            this.lblAC1.Name = "lblAC1";
            this.lblAC1.Size = new System.Drawing.Size(49, 24);
            this.lblAC1.TabIndex = 3;
            this.lblAC1.Text = "AC1";
            // 
            // btnRUN
            // 
            this.btnRUN.BackColor = System.Drawing.Color.Lime;
            this.btnRUN.Location = new System.Drawing.Point(799, 12);
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
            this.lblDehumidifier.Location = new System.Drawing.Point(925, 526);
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
            this.lblSessionCount.Location = new System.Drawing.Point(798, 89);
            this.lblSessionCount.Name = "lblSessionCount";
            this.lblSessionCount.Size = new System.Drawing.Size(87, 13);
            this.lblSessionCount.TabIndex = 6;
            this.lblSessionCount.Text = "Session Count: 0";
            // 
            // lblTargetTemp
            // 
            this.lblTargetTemp.AutoSize = true;
            this.lblTargetTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetTemp.Location = new System.Drawing.Point(804, 309);
            this.lblTargetTemp.Name = "lblTargetTemp";
            this.lblTargetTemp.Size = new System.Drawing.Size(130, 24);
            this.lblTargetTemp.TabIndex = 7;
            this.lblTargetTemp.Text = "Target Temp";
            // 
            // lblTargetRH
            // 
            this.lblTargetRH.AutoSize = true;
            this.lblTargetRH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetRH.Location = new System.Drawing.Point(804, 348);
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
            this.lblWaitSecs.Location = new System.Drawing.Point(926, 89);
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
            this.lbActionList.Location = new System.Drawing.Point(1171, 133);
            this.lbActionList.Name = "lbActionList";
            this.lbActionList.Size = new System.Drawing.Size(353, 224);
            this.lbActionList.TabIndex = 10;
            // 
            // lblVPD
            // 
            this.lblVPD.AutoSize = true;
            this.lblVPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVPD.Location = new System.Drawing.Point(804, 123);
            this.lblVPD.Name = "lblVPD";
            this.lblVPD.Size = new System.Drawing.Size(155, 24);
            this.lblVPD.TabIndex = 11;
            this.lblVPD.Text = "CURRENT VPD";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 576);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1567, 300);
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
            this.tabControl1.Size = new System.Drawing.Size(1567, 300);
            this.tabControl1.TabIndex = 0;
            // 
            // Hourly
            // 
            this.Hourly.Controls.Add(this.chart1);
            this.Hourly.Location = new System.Drawing.Point(4, 22);
            this.Hourly.Name = "Hourly";
            this.Hourly.Padding = new System.Windows.Forms.Padding(3);
            this.Hourly.Size = new System.Drawing.Size(1559, 274);
            this.Hourly.TabIndex = 0;
            this.Hourly.Text = "Hourly";
            this.Hourly.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea3.AxisX.IsReversed = true;
            chartArea3.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.DataSource = this.tentLogBindingSource;
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "VPD";
            series3.XValueMember = "LogDate";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series3.YValueMembers = "VPD";
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(1553, 268);
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
            this.Daily.Size = new System.Drawing.Size(1559, 274);
            this.Daily.TabIndex = 1;
            this.Daily.Text = "Daily";
            this.Daily.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            this.chart2.DataSource = this.tentLogBindingSource;
            this.chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(3, 3);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(1553, 268);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Fuchsia;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(958, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 49);
            this.button1.TabIndex = 13;
            this.button1.Text = "RESET";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tentLogTableAdapter
            // 
            this.tentLogTableAdapter.ClearBeforeFill = true;
            // 
            // lbCurrRange
            // 
            this.lbCurrRange.AutoSize = true;
            this.lbCurrRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrRange.Location = new System.Drawing.Point(804, 425);
            this.lbCurrRange.Name = "lbCurrRange";
            this.lbCurrRange.Size = new System.Drawing.Size(114, 24);
            this.lbCurrRange.TabIndex = 15;
            this.lbCurrRange.Text = "Current RH";
            // 
            // lblCurrTemp
            // 
            this.lblCurrTemp.AutoSize = true;
            this.lblCurrTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrTemp.Location = new System.Drawing.Point(804, 384);
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
            this.lblAvg.Location = new System.Drawing.Point(804, 166);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(135, 24);
            this.lblAvg.TabIndex = 18;
            this.lblAvg.Text = "Average VPD";
            // 
            // lblHighVPD
            // 
            this.lblHighVPD.AutoSize = true;
            this.lblHighVPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighVPD.ForeColor = System.Drawing.Color.Red;
            this.lblHighVPD.Location = new System.Drawing.Point(804, 245);
            this.lblHighVPD.Name = "lblHighVPD";
            this.lblHighVPD.Size = new System.Drawing.Size(101, 24);
            this.lblHighVPD.TabIndex = 19;
            this.lblHighVPD.Text = "High VPD";
            // 
            // lblLowVPD
            // 
            this.lblLowVPD.AutoSize = true;
            this.lblLowVPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowVPD.ForeColor = System.Drawing.Color.Red;
            this.lblLowVPD.Location = new System.Drawing.Point(804, 210);
            this.lblLowVPD.Name = "lblLowVPD";
            this.lblLowVPD.Size = new System.Drawing.Size(95, 24);
            this.lblLowVPD.TabIndex = 20;
            this.lblLowVPD.Text = "Low VPD";
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1567, 876);
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
            this.Name = "fmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.fmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Hourly.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tentLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tentConrolDataSet)).EndInit();
            this.Daily.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label lblAvg;
        private System.Windows.Forms.Label lblHighVPD;
        private System.Windows.Forms.Label lblLowVPD;
    }
}

