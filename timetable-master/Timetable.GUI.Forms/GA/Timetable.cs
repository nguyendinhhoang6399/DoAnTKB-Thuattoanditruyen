using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Timetable.GUI.Forms.Model;
using Timetable.SERVER.Protos;

namespace Timetable.GUI.Forms.GA
{
    public class Timetable
    {
        private DanhSachPhongHoc rooms;
        private DanhSachCanBo professors;
        private DanhSachGiangDay teaches;
        private DanhSachHocPhan modules;
        private DanhSachNhomHP groups;
        private DanhSachTimeslot timeslots;
        private ListTimeBusyProf listTBP;
        private ListTimeBusyRoom listTBR;
        private Class[] classes;

        private int numClasses = 0;

        public DanhSachPhongHoc Rooms { get => rooms; set => rooms = value; }
        public DanhSachCanBo Professors { get => professors; set => professors = value; }
        public DanhSachGiangDay Teaches { get => teaches; set => teaches = value; }
        public DanhSachHocPhan Modules { get => modules; set => modules = value; }
        public DanhSachNhomHP Groups { get => groups; set => groups = value; }
        public DanhSachTimeslot Timeslots { get => timeslots; set => timeslots = value; }
        public Class[] Classes { get => classes; set => classes = value; }
        public ListTimeBusyProf ListTBP { get => listTBP; set => listTBP = value; }
        public ListTimeBusyRoom ListTBR { get => listTBR; set => listTBR = value; }

        public Timetable()
        {
            this.rooms = new DanhSachPhongHoc();
            this.professors = new DanhSachCanBo();
            this.modules = new DanhSachHocPhan();
            this.teaches = new DanhSachGiangDay();
            this.groups = new DanhSachNhomHP();
            this.timeslots = new DanhSachTimeslot();
            this.listTBP = new ListTimeBusyProf();
            this.listTBR = new ListTimeBusyRoom();
            this.numClasses = 0;
            //this.busyTimes = new List<BusyTime>();
        }

        public Timetable(Timetable cloneable)
        {
            this.rooms = cloneable.Rooms;
            this.professors = cloneable.Professors;
            this.teaches = cloneable.Teaches;
            this.modules = cloneable.Modules;
            this.groups = cloneable.Groups;
            this.timeslots = cloneable.Timeslots;
            this.listTBP = cloneable.ListTBP;
            this.listTBR = cloneable.ListTBR;
            this.numClasses = cloneable.numClasses;
            //this.busyTimes = cloneable.BusyTimes;
        }

        // public List<BusyTime> BusyTimes { get => busyTimes; }

        //Create class
        public void createClasses(Individual individual)
        {
            Class[] classes = new Class[this.getNumClasses()];

            // Get individual's chromosome
            int[] chromosome = individual.getChromosome();
            int chromosomePos = 0;
            int classIndex = 0;

            foreach (HocPhanData module in this.Modules.ListHocPhan)
            {
                //Bỏ qua học phần không sắp thời khóa biểu
                if (module.IsScheduled != 0)
                    continue;
                foreach (var group in this.getGroupModules(module.MaHocPhan.Trim()))
                {
                    //Lặp số buổi học trong group
                    for (int i = 0; i < group.TongBuoiHoc; i++)
                    {
                        classes[classIndex] = new Class(classIndex, group.MaNhomHp, module.MaHocPhan);

                        // Add timeslot
                        classes[classIndex].TimeslotId = chromosome[chromosomePos];
                        chromosomePos++;

                        // Add room
                        classes[classIndex].RoomId = chromosome[chromosomePos];
                        chromosomePos++;

                        // Add professor
                        classes[classIndex].ProfessorId = chromosome[chromosomePos];
                        chromosomePos++;

                        //Add số tiết
                        classes[classIndex].SoTiet = chromosome[chromosomePos];
                        chromosomePos++;

                        //Add vi pham
                        classes[classIndex].Vipham = ViPham.KhongVP;

                        classIndex++;
                    }
                }
            }

            this.Classes = classes;
        }


        public PhongHocData getRoom(int roomId)
        {
            PhongHocData room = this.Rooms.ListPhongHoc.Where(x => x.IdPhongHoc == roomId).FirstOrDefault();
            if (room == null)
            {
                Console.WriteLine("Rooms doesn't contain key " + roomId);
            }
            return room;
        }

        public PhongHocData getRandomRoom()
        {
            Object[] roomsArray = this.Rooms.ListPhongHoc.ToArray();
            Random rnd = new Random();
            PhongHocData room = (PhongHocData)roomsArray[(int)(roomsArray.Length * rnd.NextDouble())];
            return room;
        }

        public CanBoData getProfessor(int idcanbo)
        {
            return this.Professors.ListCanBo.Where(x => x.IdCanBo == idcanbo).FirstOrDefault();
        }

        public HocPhanData getModule(string mahp)
        {
            return this.Modules.ListHocPhan.Where(x => x.MaHocPhan.Trim() == mahp).FirstOrDefault();
        }

        public List<NhomHPData> getGroupModules(string mahp)
        {
            List<NhomHPData> nhomHP = this.Groups.ListNhomHP.Where(x => x.MaHocPhan == mahp).ToList();
            return nhomHP;
        }

        public NhomHPData getGroup(int maNhomHP)
        {
            return this.Groups.ListNhomHP.Where(x => x.MaNhomHp == maNhomHP).FirstOrDefault();
        }

        public TimeslotData getTimeslot(int timeslotId)
        {
            return this.Timeslots.Lst.Where(x => x.TimeslotID == timeslotId).FirstOrDefault();
        }

        //public ListTimeBusyProf GetTimeBusyProf(int id_can_bo)
        //{
        //    return this.ListTBP.ListTimeBusyProf_.Where(x => x.IdCanBo == id_can_bo);
        //}

        //public ListTimeBusyRoom GetTimeBusyRoom(int id)
        //{
        //    return this.ListTBR.ListTimeBusyRoom_.Where(x => x.IdPhongHoc == id);
        //}
        //public BusyTime getBusyTime(int BTid)
        //{
        //    return (BusyTime)this.busyTimes.Where(x => x.IdBT == BTid).FirstOrDefault();
        //}
        /**
         * Get random timeslotId
         * 
         * @return timeslot
         */
        public TimeslotData getRandomTimeslot()
        {
            Random rnd = new Random();
            int RndID = (int)(rnd.NextDouble() * this.Timeslots.Lst.Count);
            TimeslotData timeslot = this.Timeslots.Lst.Where(x => x.TimeslotID == RndID).FirstOrDefault();
            return timeslot;
        }

        //get professor for module
        public List<GiangDayData> getListProfessor(string mahp)
        {
            List<GiangDayData> ds = new List<GiangDayData>();
            ds = this.Teaches.ListGiangDay.Where(x => x.MaHocPhan.Trim() == mahp.Trim()).ToList();
            return ds;
        }
        //get random professor
        public int getRandomProfessor(string mahp)
        {
            Random rnd = new Random();
            List<GiangDayData> ds = getListProfessor(mahp);
            if (ds.Count != 0)
            {
                int RndID = (int)(rnd.NextDouble() * ds.Count);
                return ds[RndID].IdCanBo;
            }
            return 0;
        }
        public int getNumClasses()
        {
            if (this.numClasses > 0)
            {
                return this.numClasses;
            }
            int numClasses = 0;
            foreach (NhomHPData group in Groups.ListNhomHP)
            {
                if (this.getModule(group.MaHocPhan.Trim()).IsScheduled != 0)
                    continue;
                else
                    numClasses += group.TongBuoiHoc;
            }
            this.numClasses = numClasses;
            return this.numClasses;
        }

        public int calcClashesSum()
        {
            return calcClashes_Room() + calcClashes_Professor() + calcClashes_TimeStart() + calcClashes_CapacityRoom() + calcClashes_Sessions() + calcClashes_TBP() + calcClashes_TBR() + calcClashes_TGN();
        }
        public int calcClashes_Room()
        {
            int clashes = 0;
            // Check if room is taken
            /** 
             * Kiểm tra cùng phòng học cùng thời gian
             * Lớp A: gồm môn A, timeslot(thời gian bắt đầu): Thứ 2 tiết 1
             *        số tiết: 3, phòng A1
             * Kiểm tra từng tiết của lớp A: tiết 1, tiết 2, tiết 3.
             * Nếu có bất kì Lớp nào được xếp cùng phòng với lớp A mà trùng 1 trong các tiết trên
             * thì đều không hợp lệ.
             */
            foreach (Class classA in this.Classes)
            {
                if (classA.RoomId == 0)
                    continue;
                foreach (Class classB in this.Classes)
                {
                    bool flag = false;
                    int tietA = classA.TimeslotId;
                    for (int i = 0; i < classA.SoTiet; i++)
                    {
                        if (classA.RoomId == classB.RoomId && tietA == classB.TimeslotId
                                && classA.ClassId != classB.ClassId)
                        {
                            clashes++;
                            this.Classes[classB.ClassId].Vipham = ViPham.TrungLichPhong;
                            flag = true;
                            break;
                        }
                        tietA++;
                    }
                    if (flag)
                        break;
                }
            }
            return clashes;
        }

        public int calcClashes_Professor()
        {
            int clashes = 0;
            // Check if professor is taken
            /** 
             * Kiểm tra trùng thời gian giảng viên
             *
             */
            foreach (Class classA in this.Classes)
                if (classA.ProfessorId != 0)
                    foreach (Class classB in this.Classes)
                    {
                        bool flag = false;
                        int tietA = classA.TimeslotId;
                        for (int i = 0; i < classA.SoTiet; i++)
                        {
                            if (classA.ProfessorId == classB.ProfessorId && tietA == classB.TimeslotId
                                    && classA.ClassId != classB.ClassId)
                            {
                                clashes++;
                                this.Classes[classB.ClassId].Vipham = ViPham.TrungLichCanBo;
                                flag = true;
                                break;
                            }
                            tietA++;
                        }
                        if (flag)
                            break;
                    }
            return clashes;
        }
        public int calcClashes_CapacityRoom()
        {
            int clashes = 0;
            foreach (Class classA in this.Classes)
            {
                // Check room capacity
                if (classA.RoomId == 0)
                    continue;
                int roomCapacity = this.getRoom(classA.RoomId).SucChua;
                int groupSize = this.getGroup(classA.GroupId).SiSo;

                if (roomCapacity < groupSize)
                {
                    clashes++;
                    this.Classes[classA.ClassId].Vipham = ViPham.VPSucChuaPhong;
                }
            }
            return clashes;
        }

        public int calcClashes_TimeStart()
        {
            int clashes = 0;
            foreach (Class classA in this.Classes)
            {
                if (classA.TimeslotId == -1)
                    continue;
                //Kiểm tra tiết bắt đầu học + số tiết học của module trong 1 buổi có vượt qua tiết 5 hoặc tiết 9
                //Ví dụ môn A có 3 tiết/buổi, nếu tiết bắt đầu là tiết 4 sẽ ko hợp lệ.
                int timeslotID = classA.TimeslotId;
                TimeslotData timeSlot = getTimeslot(timeslotID);
                int check = timeSlot.VTiet.IdTiet + classA.SoTiet - 1;
                if ((check > 5 && timeSlot.VTiet.IdTiet < 6) || check > 9)
                {
                    clashes++;
                    this.Classes[classA.ClassId].Vipham = ViPham.VPThoiGianBatDau;
                }
            }
            return clashes;
        }

        //public int calcClashes_LTG()
        //{
        //    int clashes = 0;
        //    int groupID = 0;
        //    foreach (Class classA in this.Classes)
        //    {
        //        /**
        //         * Kiểm tra 1 nhóm học phần nếu có nhiều buổi học 
        //         * thì các buổi học đó cùng 1 giáo viên dạy
        //         * và không được xếp học trong cùng 1 thứ
        //         */
        //        int soBuoi = this.getGroup(classA.GroupId).TongBuoiHoc;

        //        if (soBuoi != 1 && groupID != classA.GroupId)
        //        {
        //            for (int i = 1; i < soBuoi; i++)
        //            {
        //                Class classB = this.Classes[(classA.ClassId + i)];
        //                if (classA.ProfessorId != classB.ProfessorId)
        //                    clashes++;
        //            }
        //            groupID = classA.GroupId;
        //        }
        //    }

        //    return clashes;
        //}
        //Tính vi phạm về số nhóm giảng dạy : teaching group numbers
        public int calcClashes_TGN()
        {
            int clashes = 0;
            foreach (var canbo in this.Professors.ListCanBo)
            {
                var listGiangDay = this.Teaches.ListGiangDay.Where(x => x.IdCanBo == canbo.IdCanBo);
                foreach (var gd in listGiangDay)
                {
                    int sonhom = 0;
                    int groupID = 0;
                    foreach (Class classA in this.Classes)
                    {
                        /**
                         * Kiểm tra số nhóm giảng dạy được sắp lịch
                         * có phù hợp với số nhóm giảng dạy được phân công?
                         */
                        if (groupID == classA.GroupId || !gd.MaHocPhan.Trim().Equals(classA.ModuleId.Trim()) || gd.IdCanBo != classA.ProfessorId)
                            continue;
                        else
                        {
                            sonhom++;
                            if (sonhom > gd.SoNhomGiangDay)
                                this.Classes[classA.ClassId].Vipham = ViPham.VPSoNhomGiangDay;
                            groupID = classA.GroupId;
                        }
                    }
                    if (sonhom > gd.SoNhomGiangDay)
                        clashes++;
                }
            }
            return clashes;
        }

        public int calcClashes_Sessions()
        {
            int clashes = 0;
            int groupID = 0;
            foreach (Class classA in this.Classes)
            {
                /**
                 * Kiểm tra 1 nhóm học phần nếu có nhiều buổi học 
                 * các buổi học cùng 1 thứ hay không?
                 * và có cùng 1 cán bộ giảng dạy
                 */
                int soBuoi = this.getGroup(classA.GroupId).TongBuoiHoc;

                if (soBuoi != 1 && groupID != classA.GroupId)
                {
                    for (int i = 1; i < soBuoi; i++)
                    {
                        Class classB = this.Classes[(classA.ClassId + i)];
                        //
                        TimeslotData timeA = this.getTimeslot(classA.TimeslotId);
                        TimeslotData timeB = this.getTimeslot(classB.TimeslotId);
                        if (timeA.VThu.IdThu == timeB.VThu.IdThu || (classA.ProfessorId != classB.ProfessorId && classA.ProfessorId != 0))
                        {
                            clashes++;
                            this.Classes[classA.ClassId].Vipham = ViPham.VPBuoiHoc;
                        }
                    }
                    groupID = classA.GroupId;
                }
            }

            return clashes;
        }

        //Kiểm tra trùng giờ với thời gian bận của giảng viên
        public int calcClashes_TBP()
        {
            int clashes = 0;
            TimeslotData timeslot;
            foreach (Class classA in this.Classes)
            {
                int professorId = classA.ProfessorId;
                List<TimeBusyProf> list = listTBP.ListTimeBusyProf_.Where(x => x.IdCanBo == professorId).ToList();
                if (list != null)
                {
                    timeslot = getTimeslot(classA.TimeslotId);
                    for (int i = 0; i < classA.SoTiet; i++)
                    {
                        int thu = timeslot.VThu.IdThu;
                        int tiet = timeslot.VTiet.IdTiet + i;
                        int count = list.Where(x => x.IdTiet == tiet && x.IdThu == thu).Count();
                        if (count > 0)
                        {
                            clashes++;
                            this.Classes[classA.ClassId].Vipham = ViPham.TrungLichBanCB;
                            break;
                        }
                    }
                }
            }
            return clashes;
        }

        //Kiểm tra trùng giờ với thời gian bận của phongf hoc
        public int calcClashes_TBR()
        {
            int clashes = 0;
            TimeslotData timeslot;
            foreach (Class classA in this.Classes)
            {
                int roomid = classA.RoomId;
                List<TimeBusyRoom> list = listTBR.ListTimeBusyRoom_.Where(x => x.IdPhongHoc == roomid).ToList();
                if (list != null)
                {
                    timeslot = getTimeslot(classA.TimeslotId);
                    for (int i = 0; i < classA.SoTiet; i++)
                    {
                        int thu = timeslot.VThu.IdThu;
                        int tiet = timeslot.VTiet.IdTiet + i;
                        int count = list.Where(x => x.IdTiet == tiet && x.IdThu == thu).Count();
                        if (count > 0)
                        {
                            clashes++;
                            this.Classes[classA.ClassId].Vipham = ViPham.TrungLichBanPH;
                            break;
                        }
                    }
                }
            }
            return clashes;
        }
    }
}
