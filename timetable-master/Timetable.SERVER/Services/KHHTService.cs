using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timetable.SERVER.Protos;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using Timetable.SERVER.Repositories;
using Timetable.SERVER.Models;
using Google.Protobuf.WellKnownTypes;
using Core.Database;

namespace Timetable.SERVER.Services
{
    public class KHHTService : KHHT.KHHTBase
    {
        public override Task<DanhSachKHHT> DSTongHopKHHT(requestIDHK request, ServerCallContext context)
        {
            List<KHHTModel> lst = HocPhanRepository.TT_SUM_KHHT(request.HocKi, request.NamHoc);
            DanhSachKHHT objItems = new DanhSachKHHT();

            foreach (var item in lst)
            {
                KHHTData tg = new KHHTData()
                {
                    IdThkhht = item.id_thkhht,
                    MaHocPhan = item.ma_hoc_phan,
                    TenHocPhan = item.ten_hoc_phan,
                    SoTinChi = item.so_tin_chi,
                    SoTietMoiTuan = item.so_tiet_moi_tuan,
                    SoBuoiMoiTuan = item.so_buoi_moi_tuan,
                    SiSo = item.si_so,
                    SoLuongDk = item.so_luong_dk,
                    IdHocKi = item.id_hoc_ki
                };
                objItems.ListKHHT.Add(tg);
            }
            return Task.FromResult(objItems);
        }

        public override Task<DanhSachKHHT> GetAllKhhtSV(RequestMaSo request, ServerCallContext context)
        {
            List<KHHTModel> lst = HocPhanRepository.TT_GET_KHHT_SV(request.Maso);
            DanhSachKHHT objItems = new DanhSachKHHT();

            foreach (var item in lst)
            {
                KHHTData tg = new KHHTData()
                {
                    IdThkhht = item.id_thkhht,
                    MaHocPhan = item.ma_hoc_phan,
                    TenHocPhan = item.ten_hoc_phan,
                    SoTinChi = item.so_tin_chi,
                    SoTietMoiTuan = item.so_tiet_moi_tuan,
                    SoBuoiMoiTuan = item.so_buoi_moi_tuan,
                    SiSo = item.si_so,
                    SoLuongDk = item.so_luong_dk,
                    IdHocKi = item.id_hoc_ki
                };
                objItems.ListKHHT.Add(tg);
            }
            return Task.FromResult(objItems);
        }

        public override Task<KHHT_SinhVien> FindKhhtSV(RequestID request, ServerCallContext context)
        {
            KHHTSinhVienModel item = HocPhanRepository.TT_GET_KHHT(request.Id).FirstOrDefault();
            KHHT_SinhVien tg = new KHHT_SinhVien()
            {
                IdKhht = item.id_khht,
                Mahocphan = item.ma_hoc_phan,
                Masinhvien = item.ma_sinh_vien,
                Hocki = item.id_hoc_ki,
                Caithien = item.cai_thien
            };
            return Task.FromResult(tg);
        }

        public override Task<DanhSachKHHT> GetKhhtSV(requestKHTTSV request, ServerCallContext context)
        {
            List<KHHTModel> lst = HocPhanRepository.TT_GET_KHHT_SV(request.MSSV.Maso, request.HocKi.HocKi, request.HocKi.NamHoc);
            DanhSachKHHT objItems = new DanhSachKHHT();

            foreach (var item in lst)
            {
                KHHTData tg = new KHHTData()
                {
                    IdThkhht = item.id_thkhht,
                    MaHocPhan = item.ma_hoc_phan,
                    TenHocPhan = item.ten_hoc_phan,
                    SoTinChi = item.so_tin_chi,
                    SoTietMoiTuan = item.so_tiet_moi_tuan,
                    SoBuoiMoiTuan = item.so_buoi_moi_tuan,
                    SiSo = item.si_so,
                    SoLuongDk = item.so_luong_dk,
                    IdHocKi = item.id_hoc_ki
                };
                objItems.ListKHHT.Add(tg);
            }
            return Task.FromResult(objItems);
        }
        public override Task<DanhSachKHHT> SearchKHHT(RequestSearchKHHT request, ServerCallContext context)
        {
            List<KHHTModel> lst = HocPhanRepository.TT_SEARCH_KHHT(request.Masinhvien, request.Mahocphan);
            DanhSachKHHT objItems = new DanhSachKHHT();

            foreach (var item in lst)
            {
                KHHTData tg = new KHHTData()
                {
                    IdThkhht = item.id_thkhht,
                    MaHocPhan = item.ma_hoc_phan,
                    TenHocPhan = item.ten_hoc_phan,
                    SoTinChi = item.so_tin_chi,
                    SoTietMoiTuan = item.so_tiet_moi_tuan,
                    SoBuoiMoiTuan = item.so_buoi_moi_tuan,
                    SiSo = item.si_so,
                    SoLuongDk = item.so_luong_dk,
                    IdHocKi = item.id_hoc_ki
                };
                objItems.ListKHHT.Add(tg);
            }
            return Task.FromResult(objItems);
        }

        public override Task<StatusResponse> InsertKHHT(KHHT_SinhVien request, ServerCallContext context)
        {
            Response result = HocPhanRepository.TT_INSERT_KHHT(request.Masinhvien, request.Mahocphan, request.Hocki, request.Caithien);

            if (result.resultExecute == 1)

            {
                return Task.FromResult(new StatusResponse()
                {
                    Status = true,
                    StatusCode = 100,
                    StatusMessage = "Added Successfully"
                });
            }
            else
            {
                return Task.FromResult(new StatusResponse()
                {
                    Status = false,
                    StatusCode = 404,
                    StatusMessage = "Issue Occured."
                });
            }
        }
        public override Task<StatusResponse> UpdateKHHT(KHHT_SinhVien request, ServerCallContext context)
        {
            Response result = HocPhanRepository.TT_UPDATE_KHHT(request.Masinhvien, request.Mahocphan, request.Hocki, request.Caithien);

            if (result.resultExecute == 1)

            {
                return Task.FromResult(new StatusResponse()
                {
                    Status = true,
                    StatusCode = 100,
                    StatusMessage = "Added Successfully"
                });
            }
            else
            {
                return Task.FromResult(new StatusResponse()
                {
                    Status = false,
                    StatusCode = 404,
                    StatusMessage = "Issue Occured."
                });
            }
        }
        public override Task<StatusResponse> DeleteKHHT(RequestID request, ServerCallContext context)
        {
            Response result = HocPhanRepository.TT_DELETE_KHHT(request.Id);

            if (result.resultExecute == 1)

            {
                return Task.FromResult(new StatusResponse()
                {
                    Status = true,
                    StatusCode = 100,
                    StatusMessage = "Added Successfully"
                });
            }
            else
            {
                return Task.FromResult(new StatusResponse()
                {
                    Status = false,
                    StatusCode = 404,
                    StatusMessage = "Issue Occured."
                });
            }
        }
    }
}
