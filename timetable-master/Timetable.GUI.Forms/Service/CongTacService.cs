using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Text;
using Timetable.SERVER.Protos;

namespace Timetable.GUI.Forms.Service
{
    public class CongTacService
    {
        private static CongTac.CongTacClient  GetService()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            return new CongTac.CongTacClient(channel);
        }

        public static DanhSachCongTac GetCongTac(int idcanbo)
        {
            var client = GetService();
            return client.DSCongTacCB(new RequestID() { Id = idcanbo });
        }
    }
}
