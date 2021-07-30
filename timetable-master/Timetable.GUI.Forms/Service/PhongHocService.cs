using Google.Protobuf.WellKnownTypes;
using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Text;
using Timetable.SERVER.Protos;

namespace Timetable.GUI.Forms.Service
{
    public class PhongHocService : PhongHoc.PhongHocClient
    {
        private static PhongHoc.PhongHocClient GetService()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            return new PhongHoc.PhongHocClient(channel);
        }

        public static DanhSachPhongHoc GetListPhongHoc()
        {
            var client = GetService();
            return client.DSPhongHoc(new Empty());
        }
        
        public static DanhSachNhaHoc GetListNhaHoc()
        {
            var client = GetService();
            return client.DSNhaHoc(new Empty());
        }
    }
}
