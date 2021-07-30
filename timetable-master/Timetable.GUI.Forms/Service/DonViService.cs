using Google.Protobuf.WellKnownTypes;
using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Text;
using Timetable.SERVER.Protos;

namespace Timetable.GUI.Forms.Service
{
    public class DonViService
    {
        private static DonVi.DonViClient GetDonViService()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            return new DonVi.DonViClient(channel);
        }

        public static DanhSachDonVi GetDanhSachDonVi()
        {
            var client = GetDonViService();
            return client.DSAllDonVi(new Empty());
        }
        public static DanhSachDonVi GetDanhSachDonVi(int id)
        {
            var client = GetDonViService();
            return client.DSDonVi(new RequestID(){Id = id });
        }
        public static DanhSachDonVi GetDanhSachBoMon(int id)
        {
            var client = GetDonViService();
            return client.DSBoMon(new RequestID() { Id = id });
        } 
        public static DonViData GetInfoDonVi(int id)
        {
            var client = GetDonViService();
            return client.DonViInfo(new RequestID() { Id = id });
        }
    }
}
