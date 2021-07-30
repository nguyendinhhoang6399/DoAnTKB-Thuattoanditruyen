using Google.Protobuf.WellKnownTypes;
using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Text;
using Timetable.SERVER.Protos;

namespace Timetable.GUI.Web.Service
{
    public class HocPhanService : HocPhan.HocPhanClient
    {
        private static HocPhan.HocPhanClient GetService()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            return new HocPhan.HocPhanClient(channel);
        }

        public static HocPhanData GetHocPhan(string maHP)
        {
            var client = GetService();
            return client.GetHocPhan(new RequestMaHP() { MaHocPhan = maHP });
        }

        public static DanhSachHocPhan GetListHocPhan()
        {
            var client = GetService();
            return client.DSHocPhan(new Empty());
        }
    }
}
