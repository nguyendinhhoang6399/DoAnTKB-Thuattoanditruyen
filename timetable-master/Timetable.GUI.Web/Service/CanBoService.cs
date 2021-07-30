using Google.Protobuf.WellKnownTypes;
using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Text;
using Timetable.SERVER.Protos;

namespace Timetable.GUI.Web.Service
{
    public class CanBoService : CanBo.CanBoClient
    {
        private static CanBo.CanBoClient GetService()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            return new CanBo.CanBoClient(channel);
        }
        /// <summary>
        /// Login
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>
        /// Return info canbi login
        /// </returns>
        public static CanBoData Login(string username, string password)
        {
            var client = GetService();
            return client.Login(new RequestLogin() { Username = username, Password = password });
        }
        public static DanhSachCanBo GetListCanBo()
        {
            var client = GetService();
            return client.DSCanBo(new Empty());
        }

        public static CanBoData FindCanBo(int idcanbo)
        {
            var client = GetService();
            return client.FindCanBo(new FindCanBoRequest() { Idcanbo = idcanbo });
        }

        public static DanhSachCanBo FindCanBoDV(int madonvi)
        {
            var client = GetService();
            return client.FindCanBoDV(new RequestID() { Id = madonvi });
        }

        public static DanhSachTonGiao GetListTonGiao()
        {
            var client = GetService();
            return client.DSTonGiao(new Empty());
        }
        public static DanhSachDanToc GetListDanToc()
        {
            var client = GetService();
            return client.DSDanToc(new Empty());
        }
    }
}
