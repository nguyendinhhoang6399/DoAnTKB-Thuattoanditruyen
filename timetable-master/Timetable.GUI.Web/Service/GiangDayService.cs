using Google.Protobuf.WellKnownTypes;
using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Text;
using Timetable.SERVER.Protos;

namespace Timetable.GUI.Web.Service
{
    public class GiangDayService : GiangDay.GiangDayClient
    {
        private static GiangDay.GiangDayClient GetService()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            return new GiangDay.GiangDayClient(channel);
        }

        public static DanhSachGiangDay GetListGiangDay(string maHP)
        {
            var client = GetService();
            return client.DSGiangDayHP(new RequestMaSo() { Maso = maHP });
        }

        public static DanhSachGiangDay GetListGiangDay(int macb)
        {
            var client = GetService();
            return client.DSGiangDayGV(new RequestID() { Id = macb });
        }

        public static DanhSachGiangDay GetListGiangDay()
        {
            var client = GetService();
            return client.DSGiangDay(new Empty());
        }

        public static DanhSachGiangDay GetListGiangDay(int hocki, string namhoc)
        {
            var client = GetService();
            return client.DSGiangDayHK(new requestIDHK { HocKi = hocki, NamHoc = namhoc });
        }

        public static bool InsertGiangDay(GiangDayData gd)
        {
            var client = GetService();
            return client.insertGiangDay(gd).Status;
        }
        public static bool UpdateGiangDay(GiangDayData gd)
        {
            var client = GetService();
            return client.updateGiangDay(gd).Status;
        }
        public static bool DeleteGiangDay(RequestGD req)
        {
            var client = GetService();
            return client.deleteGiangDay(req).Status;
        }
    }
}
