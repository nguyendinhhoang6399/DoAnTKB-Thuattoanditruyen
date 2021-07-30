using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Timetable.GUI.Forms.Service;
using Timetable.SERVER.Protos;
using Timetable.GUI.Forms.Model;
using Timetable.GUI.Forms.GA;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;
using System.Numerics;

namespace Timetable.GUI.Forms
{
    public partial class frSapXepTKB : Form
    {
        public frSapXepTKB()
        {
            InitializeComponent();
        }

        //private int hocki { set; get; }
        //private string namhoc { set; get; }

        private int populationSize;
        private double mutationRate;
        private double crossoverRate;
        private int elitismCount;
        protected int tournamentSize;

        private int generation = 0;
        private bool Running = true;
        private double heso;
        private int genergationCount;
        private bool checkIncreasePopSize = false;
        private double clashRoom, clashProf, clashCapacity, clashSession, clashTimeStart, clashBusyRoom, clashBusyProf, clashTGN;

        private GA.Timetable timetable;
        private GA.GeneticAlgorithm ga;
        private GA.Population population;

        private DataTable dtKQ, dtTheHe;


        private void frSapXepTKB_Load(object sender, EventArgs e)
        {
            DanhSachDonVi dsKhoa = DonViService.GetDanhSachDonVi(1);
            List<Item> items = new List<Item>();
            items.Add(new Item() { id = 0, code = "", name = "-----------Chọn Khoa----------" });
            foreach (var i in dsKhoa.ListDonVi)
            {
                items.Add(new Item() { id = i.MaDonVi, code = i.MaDinhDanh, name = i.TenDonVi });
            }
            cbChonHocKi.Items.Add("1");
            cbChonHocKi.Items.Add("2");
            cbChonHocKi.Items.Add("3");
            cbChonHocKi.SelectedIndex = 0;

            for (int i = 0; i < 3; i++)
            {
                int year = DateTime.Now.Year - 1 + i;
                string nk = year + " - " + (year + 1);
                cbChonNienKhoa.Items.Add(nk);
            }
            cbChonNienKhoa.SelectedIndex = 0;

            btnStart.Enabled = false;
            btnTiepTuc.Enabled = false;
            btnTamNgung.Enabled = false;
            btnKetThuc.Enabled = false;
            btnXemTKB.Enabled = false;

            //GeneticAlgorithm ga = new GeneticAlgorithm()
            dtKQ = new DataTable();
            dtKQ.Columns.Add("ID", System.Type.GetType("System.Int32"));
            dtKQ.Columns.Add("TheHe", System.Type.GetType("System.Int32"));
            dtKQ.Columns.Add("HeSoThichNghi", System.Type.GetType("System.Double"));
            dtKQ.Columns.Add("PopulationSize", System.Type.GetType("System.String"));
            dtKQ.Columns.Add("TongVP", System.Type.GetType("System.String"));
            dtKQ.Columns.Add("VPRoom", System.Type.GetType("System.Int32"));
            dtKQ.Columns.Add("VPProf", System.Type.GetType("System.Int32"));
            dtKQ.Columns.Add("VPCapacity", System.Type.GetType("System.Int32"));
            dtKQ.Columns.Add("VPTimeStart", System.Type.GetType("System.Int32"));
            dtKQ.Columns.Add("VPSession", System.Type.GetType("System.Int32"));
            dtKQ.Columns.Add("VPBusyRoom", System.Type.GetType("System.Int32"));
            dtKQ.Columns.Add("VPBusyProf", System.Type.GetType("System.Int32"));
            dtKQ.Columns.Add("VPTGN", System.Type.GetType("System.Int32"));

            dgvKetQua.DataSource = dtKQ;
            dgvKetQua.Columns["ID"].HeaderText = "STT";
            dgvKetQua.Columns["TheHe"].HeaderText = "Thế hệ";
            dgvKetQua.Columns["HeSoThichNghi"].HeaderText = "Hệ số thích nghi";
            dgvKetQua.Columns["PopulationSize"].HeaderText = "Kích thước quần thể";
            dgvKetQua.Columns["TongVP"].HeaderText = "Tổng VP";
            dgvKetQua.Columns["VPRoom"].HeaderText = "VP trùng PH";
            dgvKetQua.Columns["VPProf"].HeaderText = "VP trùng CB";
            dgvKetQua.Columns["VPCapacity"].HeaderText = "VP sức chứa";
            dgvKetQua.Columns["VPTimeStart"].HeaderText = "VP thời gian BĐ";
            dgvKetQua.Columns["VPSession"].HeaderText = "VP buổi học";
            dgvKetQua.Columns["VPBusyRoom"].HeaderText = "VP lịch bận PH";
            dgvKetQua.Columns["VPBusyProf"].HeaderText = "VP lịch bận CB";
            dgvKetQua.Columns["VPTGN"].HeaderText = "VP số nhóm GD";

            dgvKetQua.Columns["ID"].Width = 80;
            dgvKetQua.Columns["VPRoom"].Width = 95;
            dgvKetQua.Columns["VPProf"].Width = 95;
            dgvKetQua.Columns["VPCapacity"].Width = 95;
            dgvKetQua.Columns["VPTimeStart"].Width = 100;
            dgvKetQua.Columns["VPSession"].Width = 95;
            dgvKetQua.Columns["VPBusyRoom"].Width = 95;
            dgvKetQua.Columns["VPBusyProf"].Width = 95;
            dgvKetQua.Columns["VPTGN"].Width = 115;

            dgvKetQua.Columns["VPRoom"].DefaultCellStyle.BackColor = Color.Red;
            dgvKetQua.Columns["VPProf"].DefaultCellStyle.BackColor = Color.Blue;
            dgvKetQua.Columns["VPCapacity"].DefaultCellStyle.BackColor = Color.Yellow;
            dgvKetQua.Columns["VPTimeStart"].DefaultCellStyle.BackColor = Color.Green;
            dgvKetQua.Columns["VPSession"].DefaultCellStyle.BackColor = Color.Pink;
            dgvKetQua.Columns["VPBusyRoom"].DefaultCellStyle.BackColor = Color.Brown;
            dgvKetQua.Columns["VPBusyProf"].DefaultCellStyle.BackColor = Color.Lime;
            dgvKetQua.Columns["VPTGN"].DefaultCellStyle.BackColor = Color.Purple;

            dtTheHe = new DataTable();
            dtTheHe.Columns.Add("TheHe", System.Type.GetType("System.Int32"));
            dtTheHe.Columns.Add("HeSoThichNghi", System.Type.GetType("System.String"));
            dgvTheHe.DataSource = dtTheHe;
            dgvTheHe.Columns["TheHe"].HeaderText = "Thế hệ";
            dgvTheHe.Columns["HeSoThichNghi"].HeaderText = "Hệ số thích nghi";
            addTheHe(0, 0);

            LoadChart();
        }

        private void btnSettingVP_Click(object sender, EventArgs e)
        {
            SetThongSoVP();
            MessageBox.Show("Thiết lập hệ số ràng buộc thành công!!");

        }
        private void btnSettingGA_Click(object sender, EventArgs e)
        {
            SetThongSoGA();
            MessageBox.Show("Thiết lập thông số cho thuật toán thành công!!");
        }

        private void btnXemDuLieu_Click(object sender, EventArgs e)
        {
            string hk = cbChonHocKi.SelectedItem.ToString().Trim();
            HK.namhoc = cbChonNienKhoa.SelectedItem.ToString().Trim();
            HK.hocki = int.Parse(hk);
            timetable = initializeTimetable();
            int sonhomhp = timetable.Groups.ListNhomHP.Count;
            int soLop = timetable.getNumClasses();
            int soTiet = 0;
            foreach (NhomHPData nhomhp in timetable.Groups.ListNhomHP)
                soTiet += nhomhp.TongTietHoc;
            if (sonhomhp != 0)
            {
                lblSapXep.Text = "Số nhóm học phần cần xếp: " + sonhomhp + " nhóm. \t Tổng số buổi học: " + soLop + " buổi.\t Tổng số tiết: " + soTiet + " tiết.";
                btnStart.Enabled = true;
            }
            else
            {
                lblSapXep.Text = "Chưa có dữ liệu phân nhóm học phần cho học kì này.";
                btnStart.Enabled = false;
            }
        }

        private void cbChonHocKi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string hk = cbChonHocKi.SelectedItem.ToString().Trim();
            HK.hocki = int.Parse(hk);
        }

        private void cbChonNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            HK.namhoc = cbChonNienKhoa.SelectedItem.ToString().Trim();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            generation = 1;
            Running = true;
            btnTamNgung.Enabled = true;
            btnKetThuc.Enabled = true;
            btnTiepTuc.Enabled = false;
            btnStart.Enabled = false;
            if (population != null)
            {
                DialogResult result = MessageBox.Show("Chương trình đã có kết quả.\n Bạn muốn khởi chạy lại từ đầu?", "Cảnh báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);
                switch (result)
                {
                    case DialogResult.Cancel:
                        break;
                    case DialogResult.OK:
                        {
                            population = null;
                            dtTheHe.Clear();
                            dtKQ.Clear();
                            DelChartColunm();
                            break;
                        }
                    default:
                        break;
                }
            }
            timer1.Enabled = true;
            StartGA(0);

        }

        private void btnTamNgung_Click(object sender, EventArgs e)
        {
            Running = false;
            timer1.Enabled = false;
            btnTiepTuc.Enabled = true;
            btnKetThuc.Enabled = true;
            btnTamNgung.Enabled = false;
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            Running = true;
            btnTiepTuc.Enabled = false;
            btnTamNgung.Enabled = true;
            btnKetThuc.Enabled = true;
            timer1.Enabled = true;
            StartGA(0);

        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            Running = false;
            timer1.Enabled = false;
            secs = 0;
            btnTiepTuc.Enabled = false;
            btnTamNgung.Enabled = false;
            btnKetThuc.Enabled = false;
            btnStart.Enabled = true;
            generation = 1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXemTKB_Click(object sender, EventArgs e)
        {
            frmTKB frm = new frmTKB();
            frm.flagCheck = true;
            Program.timetable.createClasses(population.getFittest(dgvKetQua.CurrentRow.Index));
            Program.timetable.calcClashesSum();
            frm.ShowDialog();
        }

        private GA.Timetable initializeTimetable()
        {
            // Create timetable
            GA.Timetable timetable = new GA.Timetable();

            // Set up rooms
            timetable.Rooms = PhongHocService.GetListPhongHoc();
            timetable.Professors = CanBoService.GetListCanBo();
            timetable.Teaches = GiangDayService.GetListGiangDay(HK.hocki, HK.namhoc);
            timetable.Modules = HocPhanService.GetListHocPhan();
            timetable.Groups = NhomHocPhanService.GetListNhomHP(HK.hocki, HK.namhoc);
            timetable.Timeslots = TimeslotService.GetTimeslot();
            timetable.ListTBP = TimeslotService.listTBP();
            timetable.ListTBR = TimeslotService.listTBR();
            Program.timetable = timetable;
            return timetable;
        }

        public void SetThongSoGA()
        {
            populationSize = (int)checkThongSo(txtPopSize, "kích thước quần thể.");
            mutationRate = checkThongSo(txtMutationRate, "tỷ lệ đột biến.");
            crossoverRate = checkThongSo(txtCrossoverRate, "tỷ lệ lai ghép.");
            elitismCount = (int)checkThongSo(txtElitismCount, "hệ số tinh hoa.");
            heso = checkThongSo(txtHeSo, "ngưỡng hệ số thích nghi.");
            if (chkGenerationMax.Checked)
                genergationCount = int.MaxValue;
            else
                genergationCount = (int)checkThongSo(txtGenerationCount, "số lượng thế hệ.");
            tournamentSize = 10;
            //checkIncreasePopSize = chkIncreasePopSize.Checked;
        }
        public void SetThongSoVP()
        {
            clashRoom = checkThongSo(txtClashRoom, "hệ số vi phạm trùng giờ phòng học.");
            clashProf = checkThongSo(txtClashRoom, "hệ số vi phạm trùng giờ cán bộ.");
            clashCapacity = checkThongSo(txtClashcapacity, "hệ số vi phạm sức chứa phòng học.");
            clashSession = checkThongSo(txtClashSession, "hệ số vi phạm buổi học.");
            clashTimeStart = checkThongSo(txtClashTimeStart, "hệ số vi phạm thời gian bắt đầu.");
            clashBusyProf = checkThongSo(txtClashBusyProf, "hệ số vi phạm trùng lịch bận cán bộ.");
            clashBusyRoom = checkThongSo(txtClashBusyRoom, "hệ số vi phạm trùng lịch bận phòng học.");
            clashTGN = checkThongSo(txtClashTGN, "hệ số vi phạm số nhóm giảng dạy.");

        }
        private double checkThongSo(NumericUpDown textbox, string name)
        {

            if (textbox.Value < 0)
            {
                MessageBox.Show("Vui lòng nhập lại " + name, "Lỗi");
                textbox.Focus();
            }
            return (double)textbox.Value;
        }

        public void StartGA(int id)
        {
            SetThongSoGA();
            SetThongSoVP();
            if (timetable == null)
                timetable = initializeTimetable();
            ga = new GeneticAlgorithm(populationSize, mutationRate, crossoverRate, elitismCount, tournamentSize);
            ga.RoomCoe = clashRoom;
            ga.ProfCoe = clashProf;
            ga.CapacityRoomCoe = clashCapacity;
            ga.SessionGroupCoe = clashSession;
            ga.TimeStartCoe = clashTimeStart;
            ga.BusyProfCoe = clashBusyProf;
            ga.BusyRoomCoe = clashBusyRoom;
            ga.TGNCoe = clashTGN;

            if (population == null)
                population = ga.initPopulation(timetable);

            // Evaluate population
            ga.evalPopulation(population, timetable);

            // Keep track of current generation
            double newSize = population.size();

            // Start evolution loop
            while (ga.isTerminationConditionMet(generation, genergationCount) == false
                && ga.isTerminationConditionMet(population, heso, timetable) == false && Running)
            {
                newSize = newSize * (1 + (double)numTangKT.Value / 100.0);
                //Console.WriteLine("G" + generation + " Best fitness: " + population.getFittest(0).getFitness());
                if ((int)newSize > population.size() && chkIncreasePopSize.Checked)
                {
                    Population pop = population;
                    populationSize = (int)newSize;
                    population = new Population(pop, (int)newSize, timetable);
                }
                // Apply crossover
                population = ga.crossoverPopulation(population);

                // Apply mutation
                population = ga.mutatePopulation(population, timetable);

                // Evaluate population
                ga.evalPopulation(population, timetable);

                // Print fitness
                if (id == 0)
                {
                    addTheHe(generation, population.getFittest(0).getFitness());
                    ForcusLastRow();
                    timetable.createClasses(population.getFittest(0));
                    AddChartColunm(generation, clash(timetable));
                }

                // Increment the current generation
                generation++;
                Application.DoEvents();

            }

            dtKQ.Clear();

            btnTamNgung.Enabled = false;
            btnXemTKB.Enabled = true;
            timer1.Enabled = false;
            // Print fitness
            int cathe = 0;
            if (int.TryParse(txtPopCount.Text, out cathe))
                for (int i = 0; i < cathe; i++)
                {
                    timetable.createClasses(population.getFittest(i));
                    addKetQua(i, (generation - 1), (int)populationSize, population.getFittest(i).getFitness(), clash(timetable));
                }

            Program.population = population;

        }

        private Clashes clash(GA.Timetable timetable)
        {
            Clashes clashes = new Clashes()
            {
                clashRoom = timetable.calcClashes_Room(),
                clashProf = timetable.calcClashes_Professor(),
                clashRoomCapacity = timetable.calcClashes_CapacityRoom(),
                clashSesionsGroup = timetable.calcClashes_Sessions(),
                clashTimeStart = timetable.calcClashes_TimeStart(),
                clashBusyProf = timetable.calcClashes_TBP(),
                clashBusyRoom = timetable.calcClashes_TBR(),
                clashTGN = timetable.calcClashes_TGN(),
                sumClash = timetable.calcClashesSum()
            };
            return clashes;
        }
        public void addTheHe(int gener, double fitness)
        {
            DataRow row = dtTheHe.NewRow();
            row["TheHe"] = gener;
            row["HeSoThichNghi"] = fitness.ToString("0.000");
            dtTheHe.Rows.Add(row);
        }

        public void addKetQua(int id, int thehe, int popsize, double heso, Clashes clash)
        {
            DataRow row = dtKQ.NewRow();
            row["ID"] = (id + 1);
            row["TheHe"] = thehe;
            row["HeSoThichNghi"] = heso.ToString("0.000");
            row["Populationsize"] = popsize.ToString();
            row["TongVP"] = clash.sumClash;
            row["VPRoom"] = clash.clashRoom;
            row["VPProf"] = clash.clashProf;
            row["VPCapacity"] = clash.clashRoomCapacity;
            row["VPTimeStart"] = clash.clashTimeStart;
            row["VPSession"] = clash.clashSesionsGroup;
            row["VPBusyRoom"] = clash.clashBusyRoom;
            row["VPBusyProf"] = clash.clashBusyProf;
            row["VPTGN"] = clash.clashTGN;
            dtKQ.Rows.Add(row);
        }

        private void ForcusLastRow()
        {
            int nRowIndex = dgvTheHe.Rows.Count - 1;
            int nColumnIndex = 1;

            dgvTheHe.Rows[nRowIndex].Selected = true;
            dgvTheHe.Rows[nRowIndex].Cells[nColumnIndex].Selected = true;

            //In case if you want to scroll down as well.
            dgvTheHe.FirstDisplayedScrollingRowIndex = nRowIndex;
        }

        private void chkProf_CheckedChanged(object sender, EventArgs e)
        {
            checkClash(chkProf, txtClashProf);
        }

        private void chkRoom_CheckedChanged(object sender, EventArgs e)
        {
            checkClash(chkRoom, txtClashRoom);
        }

        private void chkCapacity_CheckedChanged(object sender, EventArgs e)
        {
            checkClash(chkCapacity, txtClashcapacity);
        }

        private void chkTime_CheckedChanged(object sender, EventArgs e)
        {
            checkClash(chkTime, txtClashTimeStart);
        }

        private void chksession_CheckedChanged(object sender, EventArgs e)
        {
            checkClash(chksession, txtClashSession);
        }

        private void chkBusyProf_CheckedChanged(object sender, EventArgs e)
        {
            checkClash(chkBusyProf, txtClashBusyProf);
        }

        private void chkBusyRoom_CheckedChanged(object sender, EventArgs e)
        {
            checkClash(chkBusyRoom, txtClashBusyRoom);
        }
        private void chkClashTGN_CheckedChanged(object sender, EventArgs e)
        {
            checkClash(chkClashTGN, txtClashTGN);
        }

        private void checkClash(CheckBox check, NumericUpDown text)
        {
            if (check.Checked)
            {
                text.Value = 1;
                text.Enabled = false;
            }
            else
            {
                text.Enabled = true;
            }
        }

        private void chkGenerationMax_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGenerationMax.Checked)
            {
                txtGenerationCount.Value = int.MaxValue;
                txtGenerationCount.Enabled = false;
            }
            else
            {
                txtGenerationCount.Enabled = true;
            }
        }

        private void chkIncreasePopSize_CheckedChanged(object sender, EventArgs e)
        {

        }
        int hours = 0, mins = 0, secs = 0;


        private void timer1_Tick(object sender, EventArgs e)
        {
            secs++;
            //if (seconds == 60)
            //{
            //    mins++;
            //    seconds = 0;
            //}
            //if(mins==60)
            //{
            //    hours++;
            //    mins = 0;
            //}    
            lblTimer.Text = (secs / 60).ToString("00") + ":" + (secs % 60).ToString("00");
        }

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        System.Windows.Forms.DataVisualization.Charting.TextAnnotation textAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.TextAnnotation();
        System.Windows.Forms.DataVisualization.Charting.TextAnnotation textAnnotation2 = new System.Windows.Forms.DataVisualization.Charting.TextAnnotation();
        System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
        System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
        System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
        System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
        System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
        System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
        System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
        System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
        System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
        System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
        System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();

        private void LoadChart()
        {
            /// <summary>
            /// Required method for Designer support - do not modify
            /// the contents of this method with the code editor.
            /// </summary>


            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chart1);
            // 
            // chart1
            // 
            textAnnotation1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textAnnotation1.IsSizeAlwaysRelative = false;
            textAnnotation1.Name = "TextAnnotation2";
            textAnnotation1.Text = "Số vi phạm";
            textAnnotation1.X = 4D;
            textAnnotation1.Y = 4D;
            textAnnotation2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textAnnotation2.Name = "TextAnnotation1";
            textAnnotation2.Text = "Thế hệ";
            textAnnotation2.X = 90D;
            textAnnotation2.Y = 94D;
            this.chart1.Annotations.Add(textAnnotation1);
            this.chart1.Annotations.Add(textAnnotation2);
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.None;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Trùng giờ PH";
            series1.Color = Color.Red;
            series1.YValuesPerPoint = 3;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Trùng giờ CB";
            series2.Color = Color.Blue;
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "VP sức chứa PH";
            series3.Color = Color.Yellow;
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "VP buổi học";
            series4.Color = Color.Pink;
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "Trùng lịch bận PH";
            series5.Color = Color.Brown;
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "Trùng lịch CB";
            series6.Color = Color.Lime;
            series7.BorderWidth = 2;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Legend = "Legend1";
            series7.Name = "VP TG bắt đầu học";
            series7.Color = Color.Green;
            series8.BorderWidth = 2;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Legend = "Legend1";
            series8.Name = "VP số nhóm giảng dạy";
            series8.Color = Color.Purple;

            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Vi phạm ràng buộc";
            this.chart1.Titles.Add(title1);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
        }

        private void AddChartColunm(int thehe, Clashes clashes)
        {
            DataPoint col1 = new DataPoint(thehe, clashes.clashRoom);
            chart1.Series[0].Points.Add(col1);
            DataPoint col2 = new DataPoint(thehe, clashes.clashProf);
            chart1.Series[1].Points.Add(col2);
            DataPoint col3 = new DataPoint(thehe, clashes.clashRoomCapacity);
            chart1.Series[2].Points.Add(col3);
            DataPoint col4 = new DataPoint(thehe, clashes.clashSesionsGroup);
            chart1.Series[3].Points.Add(col4);
            DataPoint col5 = new DataPoint(thehe, clashes.clashBusyRoom);
            chart1.Series[4].Points.Add(col5);
            DataPoint col6 = new DataPoint(thehe, clashes.clashBusyProf);
            chart1.Series[5].Points.Add(col6);
            DataPoint col7 = new DataPoint(thehe, clashes.clashTimeStart);
            chart1.Series[6].Points.Add(col7);
            DataPoint col8 = new DataPoint(thehe, clashes.clashTGN);
            chart1.Series[7].Points.Add(col8);

        }
        private void DelChartColunm()
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            chart1.Series[3].Points.Clear();
            chart1.Series[4].Points.Clear();
            chart1.Series[5].Points.Clear();
            chart1.Series[6].Points.Clear();
            chart1.Series[7].Points.Clear();
        }
    }
}
