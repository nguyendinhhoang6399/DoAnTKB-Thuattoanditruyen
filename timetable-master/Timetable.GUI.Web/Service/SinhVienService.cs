using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timetable.GUI.Web.IService;
using Timetable.SERVER.Protos;

namespace Timetable.GUI.Web.Service
{
    public class SinhVienService : SinhVien.SinhVienClient, ISinhVienService
    {
        private static SinhVien.SinhVienClient GetService()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            return new SinhVien.SinhVienClient(channel);
        }
        /// <summary>
        /// Login
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>
        /// Return info canbi login
        /// </returns>
        public static SinhVienData LoginSV(string username, string password)
        {
            var client = GetService();
            return client.LoginSV(new RequestLogin() { Username = username, Password = password });
        }
        public static async Task<SinhVienData> GetInfoSinVien(string maSV)
        {
            var client = GetService();
            return await client.GetSinhVienAsync(new RequestMaSo() { Maso = maSV });
        }

        public IEnumerable<SinhVienData> GetAllSinhVien()
        {
            throw new NotImplementedException();
        }

        public SinhVienData GetInfoSinhVien(string masinhvien)
        {
            var client = GetService();
            return client.GetSinhVien(new RequestMaSo() { Maso = masinhvien });
        }

        public bool AddSinhVien(SinhVienData sv)
        {
            var client = GetService();
            return client.insertSinhVien(sv).Status;
        }

        public bool UpdateSinhVien(SinhVienData sv)
        {
            var client = GetService();
            return client.updateSinhVien(sv).Status;
        }

        public bool DeleteSinhVien(string maSinhVien)
        {
            var client = GetService();
            return client.deleteSinhVien(new RequestMaSo() { Maso = maSinhVien }).Status;
        }
    }
}
