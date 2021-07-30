using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Text;
using Timetable.SERVER.Protos;

namespace Timetable.GUI.Web.Service
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
        
        public static KHHT_SinhVien FindKHHT(int id)
        {
            var client = GetKHHTService();
            return client.FindKhhtSV(new RequestID() { Id = id});
        }
        
        public static DanhSachKHHT GetAllKHHTSV(string MSSV)
        {
            var client = GetKHHTService();
            return client.GetAllKhhtSV(new RequestMaSo() { Maso = MSSV });
        }

         public static DanhSachKHHT GetKHHTSV(string MSSV, int hocki, string namhoc)
        {
            var client = GetKHHTService();
            return client.GetKhhtSV(new requestKHTTSV()
            {
                HocKi = new requestIDHK()
                {
                    HocKi = hocki,
                    NamHoc = namhoc
                },
                MSSV = new RequestMaSo() { Maso = MSSV}
            });
        }
        public static DanhSachKHHT SearchKHHT(string MSSV, string mahocphan)
        {
            var client = GetKHHTService();
            return client.SearchKHHT(new RequestSearchKHHT() { Mahocphan = mahocphan, Masinhvien = MSSV });
        } 
        public static bool InsertKHHT(KHHT_SinhVien khht)
        {
            var client = GetKHHTService();
            return client.InsertKHHT(khht).Status;
        } 
        public static bool UpdateKHHT(KHHT_SinhVien khht)
        {
            var client = GetKHHTService();
            return client.UpdateKHHT(khht).Status;
        }
        public static bool DeleteKHHT(int idkhht)
        {
            var client = GetKHHTService();
            return client.DeleteKHHT(new RequestID() {Id =idkhht }).Status;
        }
    }
}
