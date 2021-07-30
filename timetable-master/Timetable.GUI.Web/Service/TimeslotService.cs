using Google.Protobuf.WellKnownTypes;
using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Text;
using Timetable.SERVER.Protos;

namespace Timetable.GUI.Web.Service
{
    public class TimeslotService : Timeslot.TimeslotClient
    {
        private static Timeslot.TimeslotClient GetService()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            return new Timeslot.TimeslotClient(channel);
        }

        public static DanhSachTimeslot GetTimeslot()
        {
            var client = GetService();
            return client.listTimeslot(new Empty());
        }

        public static ListTimeBusyProf listTBP()
        {
            var client = GetService();
            return client.listTBP(new Empty());
        }
        public static ListTimeBusyProf listTBP(int idcanbo)
        {
            var client = GetService();
            return client.listTimeBusyProf(new RequestID() { Id = idcanbo});
        }
        public static ListTimeBusyRoom listTBR()
        {
            var client = GetService();
            return client.listTBR(new Empty());
        }
        public static HocKi getHocKi(int hocki, string namhoc)
        {
            var client = GetService();
            return client.gethocki(new requestIDHK() { HocKi = hocki, NamHoc = namhoc });
        }
        public static HocKi getHocKi(int hocki)
        {
            var client = GetService();
            return client.gethockiByID(new RequestID() { Id = hocki});
        }
    }
}
