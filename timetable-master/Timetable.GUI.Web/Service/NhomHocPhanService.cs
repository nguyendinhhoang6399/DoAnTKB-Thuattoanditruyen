using Google.Protobuf.WellKnownTypes;
using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Text;
using Timetable.SERVER.Protos;

namespace Timetable.GUI.Web.Service
{
    public class NhomHocPhanService
    {
        private static NhomHocPhan.NhomHocPhanClient GetService()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            return new NhomHocPhan.NhomHocPhanClient(channel);
        }
        public static NhomHPData GetInfoNhomHP(int manhom)
        {
            var client = GetService();
            return client.GetInfoNhomHP(new RequestID() {Id = manhom });
        }
        public static DanhSachNhomHP GetListNhomHP(int hocki, string namhoc)
        {
            var client = GetService();
            return client.DSNhomHP(new requestIDHK() { HocKi = hocki, NamHoc = namhoc });
        }
        public static bool InsertNhomHP(NhomHPData nhomHP)
        {
            var client = GetService();
            return client.InsertNhomHP(nhomHP).Status;
        }

        public static bool UpdateNhomHP(NhomHPData nhomHP)
        {
            var client = GetService();
            return client.UpdateNhomHP(nhomHP).Status;
        }

        public static bool DeleteAllNhomHP(int hocki, string namhoc)
        {
            var client = GetService();
            return client.DelNhomHP(new requestIDHK() { HocKi = hocki, NamHoc = namhoc }).Status;
        }
        public static bool DeleteNhomHP(int manhomHP)
        {
            var client = GetService();
            return client.DeleteNhomHP(new RequestID() { Id = manhomHP }).Status;
        }
    }
}
