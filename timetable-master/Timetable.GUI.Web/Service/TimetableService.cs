using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Text;
using Timetable.SERVER.Protos;

namespace Timetable.GUI.Forms.Service
{
    public class TimetableService
    {
        private static SERVER.Protos.Timetable.TimetableClient GetService()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            return new SERVER.Protos.Timetable.TimetableClient(channel);
        }
        public static Timetables timetables(int hocki, string namhoc)
        {
            var client = GetService();
            return client.listTimetable(new requestIDHK() { HocKi = hocki, NamHoc = namhoc });
        }
        public static Timetables timetables(int idcanbo, int hocki, string namhoc)
        {
            var client = GetService();
            return client.TimetableOfTeacher(
                new RequestTimetableTeacher() { 
                    HocKi = new requestIDHK()
                    {
                        HocKi = hocki,
                        NamHoc = namhoc
                    },
                    IdCanBo = new RequestID()
                    {
                        Id = idcanbo
                    }
            });
        }
        
        public static Timetables timetables_room(int idroom, int hocki, string namhoc)
        {
            var client = GetService();
            return client.TimetableOfRoom(
                new RequestTimetableTeacher() { 
                    HocKi = new requestIDHK()
                    {
                        HocKi = hocki,
                        NamHoc = namhoc
                    },
                    IdCanBo = new RequestID()
                    {
                        Id = idroom
                    }
            });
        }
        public static TimetableData getTimtableInfo(int manhomhp, int tiet, int thu)
        {
            var client = GetService();
            return client.getInfoTimetable(new RequestGetInfoTimetable() { MaNhomHp = manhomhp, Tiet = tiet, Thu = thu });
        }
        public static TimetableData getTimtableInfo(int idtkb)
        {
            var client = GetService();
            return client.getInfoTimetableById(new RequestID() { Id = idtkb });
        }
        public static bool InsertTimetable(TimetableData timetable)
        {
            var client = GetService();
            return client.insertTimetable(timetable).Status;
        }
        public static bool UpdateTimetable(TimetableData timetable)
        {
            var client = GetService();
            return client.updateTimetable(timetable).Status;
        }

        public static bool DeleteAllTimetale(int hocki, string namhoc)
        {
            var client = GetService();
            return client.deleteAllTimetable(new requestIDHK() { HocKi = hocki, NamHoc = namhoc }).Status;
        }
        public static bool DeleteTimetale(int manhomHP)
        {
            var client = GetService();
            return client.deleteTimetable(new RequestID() { Id = manhomHP }).Status;
        }
    }
}
