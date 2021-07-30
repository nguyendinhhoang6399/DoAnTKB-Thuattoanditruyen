using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timetable.SERVER.Models;
using Timetable.SERVER.Protos;
using Timetable.SERVER.Repositories;

namespace Timetable.SERVER.Services
{
    public class SinhVienService : SinhVien.SinhVienBase
    {
        public override Task<SinhVienData> GetSinhVien(RequestMaSo request, ServerCallContext context)
        {
            SinhVienData sv = SinhVienRepository.TT_GET_INFO_SV(request.Maso);
            return Task.FromResult(sv);
        }
        public override Task<SinhVienData> LoginSV(RequestLogin request, ServerCallContext context)
        {
            /* SinhVienData sv = SinhVienRepository.TT_LOGIN_SV(request.Username, request.Password);
             return Task.FromResult(sv);*/
            //luc dau no co 2 dong nay thoy t code mo duoi cho giong canbo
            SinhVienData item = SinhVienRepository.TT_LOGIN_SV(request.Username, request.Password);
            System.Console.WriteLine("másv:" + item.MaDanToc);
            /* SinhVienData sinhVien = new SinhVienData();
             System.Console.WriteLine("másv:" + item.Dia_chi);
             if (item != null)
                 sinhVien = new SinhVienData
                 {
                     MaSinhVien = item.Ma_sinh_vien,
                     TenSinhVien = item.Ten_sinh_vien,
                     GioiTinh = item.Gioi_tinh,
                     NgaySinh = item.Ngay_sinh,
                     Sdt = item.Sdt,
                     DiDong = item.Di_dong,
                     Email = item.Email,
                     DiaChi = item.Dia_chi,
                     Avatar = item.Avatar,
                     MaDanToc = item.Ma_dan_toc,
                     MaTonGiao = item.Ma_ton_giao,
                     MaNganh = sinhVien.MaNganh
                 };*/
            return Task.FromResult(item);

        }
        
    }
}
