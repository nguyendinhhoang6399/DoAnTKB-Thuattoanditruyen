using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Timetable.GUI.Forms.Model;

namespace Timetable.GUI.Forms
{
    public partial class frmThongKeTKB : Form
    {
        public frmThongKeTKB()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;
            this.BringToFront();
        }
        public bool checkSapXep { set; get; } = false;
        private void frmThongKeTKB_Load(object sender, EventArgs e)
        {
            LoadChart();
            Clashes clashes = new Clashes();
            GA.Timetable timetable = Program.timetable;
            clashes.clashProf = timetable.calcClashes_Professor();
            clashes.clashRoom = timetable.calcClashes_Room();
            clashes.clashRoomCapacity = timetable.calcClashes_CapacityRoom();
            clashes.clashSesionsGroup = timetable.calcClashes_Sessions();
            clashes.clashTGN = timetable.calcClashes_TGN();
            clashes.clashTimeStart = timetable.calcClashes_TimeStart();
            clashes.clashBusyProf = timetable.calcClashes_TBP();
            clashes.clashBusyRoom = timetable.calcClashes_TBR();
            clashes.sumClash = timetable.calcClashesSum();
        
            chart1.Series[0].Points.AddXY("Tổng VP", clashes.sumClash);
            chart1.Series[0].Points.AddXY("Trùng CB", clashes.clashProf);
            chart1.Series[0].Points.AddXY("Trùng PH", clashes.clashRoom);
            chart1.Series[0].Points.AddXY("VP sức chứa", clashes.clashRoomCapacity);
            chart1.Series[0].Points.AddXY("VP buổi học", clashes.clashSesionsGroup);
            chart1.Series[0].Points.AddXY("VP số nhóm GD", clashes.clashTGN);
            chart1.Series[0].Points.AddXY("VP TG bắt đầu", clashes.clashTimeStart);
            chart1.Series[0].Points.AddXY("Trùng lịch bận CB", clashes.clashBusyProf);
            chart1.Series[0].Points.AddXY("Trùng lịch bận PH", clashes.clashBusyRoom);
            if(checkSapXep)
            {
                chart1.Series[1].Points.AddXY("Tổng VP", clashes.sumClash);
                chart1.Series[1].Points.AddXY("Trùng CB", clashes.clashProf);
                chart1.Series[1].Points.AddXY("Trùng PH", clashes.clashRoom);
                chart1.Series[1].Points.AddXY("VP sức chứa", clashes.clashRoomCapacity);
                chart1.Series[1].Points.AddXY("VP buổi học", clashes.clashSesionsGroup);
                chart1.Series[1].Points.AddXY("VP số nhóm GD", clashes.clashTGN);
                chart1.Series[1].Points.AddXY("VP TG bắt đầu", clashes.clashTimeStart);
                chart1.Series[1].Points.AddXY("Trùng lịch bận CB", clashes.clashBusyProf);
                chart1.Series[1].Points.AddXY("Trùng lịch bận PH", clashes.clashBusyRoom);
            }    

        }
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private void LoadChart()
        {
            System.Windows.Forms.DataVisualization.Charting.TextAnnotation textAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.TextAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            textAnnotation1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textAnnotation1.Name = "TextAnnotation1";
            textAnnotation1.Text = "Thống kê vi phạm ràng buộc";
            textAnnotation1.X = 30D;
            textAnnotation1.Y = -1D;
            this.chart1.Annotations.Add(textAnnotation1);
            chartArea1.AxisX.Title = "Ràng buộc";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.Title = "Vi phạm ràng buộc";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY2.Title = "Tỉ lệ thích nghi";
            chartArea1.AxisY2.TitleFont = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            series1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            series1.BorderColor = System.Drawing.Color.Red;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Lime;
            series1.Legend = "Legend1";
            series1.Name = "VPRangBuoc";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series2.Legend = "Legend1";
            series2.Name = "TiLeThichNghi";
            series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1000, 568);
            this.chart1.Dock = DockStyle.Fill;
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.Controls.Add(chart1);
        }

    }
}
