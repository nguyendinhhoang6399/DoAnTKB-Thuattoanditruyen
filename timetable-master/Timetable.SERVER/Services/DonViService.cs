
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timetable.SERVER.Models;
using Timetable.SERVER.Protos;
using Timetable.SERVER.Repositories;
using Google.Protobuf.WellKnownTypes;

namespace Timetable.SERVER.Services
{
    public class DonViService : DonVi.DonViBase
    {
        #region Liet le danh sach tat ca don vi 
        public override Task<DanhSachDonVi> DSAllDonVi(Empty request, ServerCallContext context)
        {
            List<DonViModel> list = DonViRepository.TT_DS_DONVI();
            DanhSachDonVi dsDonVi = new DanhSachDonVi();
            foreach ( var item in list)
            {
                DonViData dv = new DonViData()
                {
                    MaDonVi = item.ma_don_vi,
                    MaDinhDanh = item.ma_dinh_danh,
                    TenDonVi = item.ten_don_vi,
                    DiaChi = item.dia_chi,
                    Email = item.email,
                    Sdt = item.sdt,
                    Domain = item.domain,
                    Fax = item.fax,
                    GioiThieu = item.gioi_thieu,
                    NgayThanhLap = item.ngay_thanh_lap,
                    MaDonViCha = item.ma_don_vi_cha,
                    IdLoaiDonVi = item.id_loai_don_vi
                };
                dsDonVi.ListDonVi.Add(dv);
            }
            return Task.FromResult(dsDonVi);
        }
        #endregion
        #region Thong tin don vi
        public override Task<DonViData> DonViInfo(RequestID request, ServerCallContext context)
        {
            DonViModel item = DonViRepository.TT_DON_VI_INFO(request.Id);

            DonViData dv = new DonViData()
            {
                MaDonVi = item.ma_don_vi,
                MaDinhDanh = item.ma_dinh_danh,
                TenDonVi = item.ten_don_vi,
                DiaChi = item.dia_chi,
                Email = item.email,
                Sdt = item.sdt,
                Domain = item.domain,
                Fax = item.fax,
                GioiThieu = item.gioi_thieu,
                NgayThanhLap = item.ngay_thanh_lap,
                MaDonViCha = item.ma_don_vi_cha,
                IdLoaiDonVi = item.id_loai_don_vi
            };
            return Task.FromResult(dv);
        }
        #endregion
        #region Liet le danh sach don vi theo loai don vi(khoa, bo mon)
        public override Task<DanhSachDonVi> DSDonVi(RequestID request, ServerCallContext context)
        {
            List<DonViModel> list = DonViRepository.TT_DS_DONVI(request.Id);
            DanhSachDonVi dsDonVi = new DanhSachDonVi();
            foreach ( var item in list)
            {
                DonViData dv = new DonViData()
                {
                    MaDonVi = item.ma_don_vi,
                    MaDinhDanh = item.ma_dinh_danh,
                    TenDonVi = item.ten_don_vi,
                    DiaChi = item.dia_chi,
                    Email = item.email,
                    Sdt = item.sdt,
                    Domain = item.domain,
                    Fax = item.fax,
                    GioiThieu = item.gioi_thieu,
                    NgayThanhLap = item.ngay_thanh_lap,
                    MaDonViCha = item.ma_don_vi_cha,
                    IdLoaiDonVi = item.id_loai_don_vi
                };
                dsDonVi.ListDonVi.Add(dv);
            }
            return Task.FromResult(dsDonVi);
        }
        #endregion
        #region Liet le danh sach bo mon theo ma khoa
        public override Task<DanhSachDonVi> DSBoMon(RequestID request, ServerCallContext context)
        {
            List<DonViModel> list = DonViRepository.TT_DS_DONVI_CON(request.Id);
            DanhSachDonVi dsDonVi = new DanhSachDonVi();
            foreach (var item in list)
            {
                DonViData dv = new DonViData()
                {
                    MaDonVi = item.ma_don_vi,
                    MaDinhDanh = item.ma_dinh_danh,
                    TenDonVi = item.ten_don_vi,
                    DiaChi = item.dia_chi,
                    Email = item.email,
                    Sdt = item.sdt,
                    Domain = item.domain,
                    Fax = item.fax,
                    GioiThieu = item.gioi_thieu,
                    NgayThanhLap = item.ngay_thanh_lap,
                    MaDonViCha = item.ma_don_vi_cha,
                    IdLoaiDonVi = item.id_loai_don_vi
                };
                dsDonVi.ListDonVi.Add(dv);
            }
            return Task.FromResult(dsDonVi);
        }
        #endregion
    }
}
