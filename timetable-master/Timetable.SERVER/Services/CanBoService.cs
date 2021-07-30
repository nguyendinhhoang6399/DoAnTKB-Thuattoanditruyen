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

namespace Timetable.SERVER.Services
{
    public class CanBoService : CanBo.CanBoBase
    {
        private readonly ILogger<CanBoService> _logger;
        public CanBoService()
        {
        }

        public override Task<CanBoData> FindCanBo(FindCanBoRequest request, ServerCallContext context)
        {
            CanboModel item = CanBoRepository.TT_FINDCANBO(request.Idcanbo).FirstOrDefault();
            CanBoData canbo = new CanBoData
            {
                IdCanBo = item.Id_can_bo,
                Macanbo = item.Ma_can_bo,
                Tencanbo = item.Ten_can_bo,
                Password=item.Password,
                Gioitinh = item.Gioi_tinh,
                Ngaysinh = item.Ngay_sinh,
                Sdt = item.Sdt,
                DiDong = item.Di_dong,
                Email = item.Email,
                DiaChi = item.Dia_chi,
                Avatar = item.Avatar,
                QuyenDacBiet = item.Quyen_dac_biet,
                IsActive = item.Is_active,
                TrangThai = item.Trang_thai,
                DanToc = DanTocInfo(new RequestID() { Id = item.Ma_dan_toc }, context).Result,
                TonGiao = TonGiaoInfo(new RequestID() { Id = item.Ma_ton_giao }, context).Result
            };

            return Task.FromResult(canbo);
        }

        public override Task<CanBoData> Login(RequestLogin request, ServerCallContext context)
        {
            CanboModel item = CanBoRepository.TT_LOGIN(request.Username, request.Password);
            CanBoData canbo = new CanBoData();
            if (item != null)
                canbo = new CanBoData
                {
                    IdCanBo = item.Id_can_bo,
                    Macanbo = item.Ma_can_bo,
                    Tencanbo = item.Ten_can_bo,
                    Gioitinh = item.Gioi_tinh,
                    Ngaysinh = item.Ngay_sinh,
                    Sdt = item.Sdt,
                    DiDong = item.Di_dong,
                    Email = item.Email,
                    DiaChi = item.Dia_chi,
                    Avatar = item.Avatar,
                    QuyenDacBiet = item.Quyen_dac_biet,
                    IsActive = item.Is_active,
                    TrangThai = item.Trang_thai,
                    DanToc = DanTocInfo(new RequestID() { Id = item.Ma_dan_toc }, context).Result,
                    TonGiao = TonGiaoInfo(new RequestID() { Id = item.Ma_ton_giao }, context).Result
                };

            return Task.FromResult(canbo);
        }

        #region hiển thị danh sách can bo
        public override Task<DanhSachCanBo> DSCanBo(Empty request, ServerCallContext context)
        {

            DanhSachCanBo objItems = new DanhSachCanBo();

            foreach (var item in CanBoRepository.TT_DS_CANBO())
            {
                CanBoData tg = new CanBoData
                {
                    IdCanBo = item.Id_can_bo,
                    Macanbo = item.Ma_can_bo,
                    Tencanbo = item.Ten_can_bo,
                    Gioitinh = item.Gioi_tinh,
                    Ngaysinh = item.Ngay_sinh,
                    Sdt = item.Sdt,
                    DiDong = item.Di_dong,
                    Email = item.Email,
                    DiaChi = item.Dia_chi,
                    Avatar = item.Avatar,
                    QuyenDacBiet = item.Quyen_dac_biet,
                    IsActive = item.Is_active,
                    TrangThai = item.Trang_thai,
                    DanToc = DanTocInfo(new RequestID() { Id = item.Ma_dan_toc }, context).Result,
                    TonGiao = TonGiaoInfo(new RequestID() { Id = item.Ma_ton_giao }, context).Result

                };
                objItems.ListCanBo.Add(tg);
            }
            return Task.FromResult(objItems);
        }
        #endregion
        #region tìm cán bộ theo đơn vị
        public override Task<DanhSachCanBo> FindCanBoDV(RequestID request, ServerCallContext context)
        {
            List<CanboModel> list = CanBoRepository.TT_FIND_CANBO_DV(request.Id);
            DanhSachCanBo objItems = new DanhSachCanBo();

            foreach (var item in list)
            {
                CanBoData tg = new CanBoData
                {
                    IdCanBo = item.Id_can_bo,
                    Macanbo = item.Ma_can_bo,
                    Tencanbo = item.Ten_can_bo,
                    Gioitinh = item.Gioi_tinh,
                    Ngaysinh = item.Ngay_sinh,
                    Sdt = item.Sdt,
                    DiDong = item.Di_dong,
                    Email = item.Email,
                    DiaChi = item.Dia_chi,
                    Avatar = item.Avatar,
                    QuyenDacBiet = item.Quyen_dac_biet,
                    IsActive = item.Is_active,
                    TrangThai = item.Trang_thai,
                    DanToc = DanTocInfo(new RequestID() { Id = item.Ma_dan_toc }, context).Result,
                    TonGiao = TonGiaoInfo(new RequestID() { Id = item.Ma_ton_giao }, context).Result

                };
                objItems.ListCanBo.Add(tg);
            }
            return Task.FromResult(objItems);
        }
        #endregion

        #region Danh sách tôn giáo, dân tộc


        public override Task<DanhSachTonGiao> DSTonGiao(Empty request, ServerCallContext context)
        {

            DanhSachTonGiao objItems = new DanhSachTonGiao();

            foreach (var item in CanBoRepository.TT_DS_TONGIAO())
            {
                TonGiao tg = new TonGiao()
                {
                    MaTonGiao = item.ma_ton_giao,
                    TenTonGiao = item.ten_ton_giao
                };
                objItems.ListTonGiao.Add(tg);
            }
            return Task.FromResult(objItems);
        }
        public override Task<DanhSachDanToc> DSDanToc(Empty request, ServerCallContext context)
        {

            DanhSachDanToc objItems = new DanhSachDanToc();

            foreach (var item in CanBoRepository.TT_DS_DANTOC())
            {
                DanToc tg = new DanToc()
                {
                    MaDanToc = item.ma_dan_toc,
                    TenDanToc = item.ten_dan_toc
                };
                objItems.ListDanToc.Add(tg);
            }
            return Task.FromResult(objItems);
        }

        public override Task<DanToc> DanTocInfo(RequestID request, ServerCallContext context)
        {

            DanTocModel dt = CanBoRepository.TT_DANTOC(request.Id);
            DanToc result = new DanToc()
            {
                MaDanToc = dt.ma_dan_toc,
                TenDanToc = dt.ten_dan_toc
            };
            return Task.FromResult(result);
        }
        public override Task<TonGiao> TonGiaoInfo(RequestID request, ServerCallContext context)
        {

            TonGiaoModel dt = CanBoRepository.TT_TONGIAO(request.Id);
            TonGiao result = new TonGiao()
            {
                MaTonGiao = dt.ma_ton_giao,
                TenTonGiao = dt.ten_ton_giao
            };
            return Task.FromResult(result);
        }

        #endregion
    }
}
