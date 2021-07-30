using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Text;
using Timetable.SERVER.Protos;

namespace Timetable.GUI.Forms.Service
{
    public class KHHTService
    {
        private static KHHT.KHHTClient GetKHHTService()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            return new KHHT.KHHTClient(channel);
        }

        public static DanhSachKHHT Sum_KHHT(int hocki, string namhoc)
        {
            var client = GetKHHTService();
            return client.DSTongHopKHHT(new requestIDHK() { HocKi= hocki, NamHoc = namhoc });
        }
    }
}
