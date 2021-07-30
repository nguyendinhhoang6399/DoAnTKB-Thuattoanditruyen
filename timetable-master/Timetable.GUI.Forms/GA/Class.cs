using System;
using System.Collections.Generic;
using System.Text;

namespace Timetable.GUI.Forms.GA
{
    public class Class
    {
        private int classId;
        private int groupId;
        private string moduleId;
        private int professorId;
        private int timeslotId;
        private int roomId;
        private int soTiet;
        private int vipham;

        public Class(int classId, int groupId, string moduleId)
        {
            this.classId = classId;
            this.moduleId = moduleId;
            this.groupId = groupId;
        }

        public Class(int classId, int groupId, string moduleId,int professorId, int timeId, int roomid, int sotiet, int vp)
        {
            this.classId = classId;
            this.moduleId = moduleId;
            this.groupId = groupId;
            this.professorId = professorId;
            this.roomId = roomid;
            this.timeslotId = timeId;
            this.soTiet = sotiet;
            this.vipham = vp;
        }

        public int ClassId { get => classId; set => classId = value; }
        public int GroupId { get => groupId; set => groupId = value; }
        public string ModuleId { get => moduleId; set => moduleId = value; }
        public int ProfessorId { get => professorId; set => professorId = value; }
        public int TimeslotId { get => timeslotId; set => timeslotId = value; }
        public int RoomId { get => roomId; set => roomId = value; }
        public int SoTiet { get => soTiet; set => soTiet = value; }
        public int Vipham { get => vipham; set => vipham = value; }
    }
}
