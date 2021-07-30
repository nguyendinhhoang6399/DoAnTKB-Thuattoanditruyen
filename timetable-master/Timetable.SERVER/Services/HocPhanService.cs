using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timetable.SERVER.Protos;
using Timetable.SERVER.Repositories;

namespace Timetable.SERVER.Services
{
    public class HocPhanService : HocPhan.HocPhanBase
    {
        #region hiển thị danh sách hoc phan
        public override Task<DanhSachHocPhan> DSHocPhan(Empty request, ServerCallContext context)
        {

            DanhSachHocPhan objItems = new DanhSachHocPhan();

            foreach (var item in HocPhanRepository.TT_DS_HOCPHAN())
            {
                HocPhanData tg = new HocPhanData
                {
                    MaHocPhan = item.ma_hoc_phan,
                    MaDonVi = item.ma_don_vi,
                    SoTinChi = item.so_tin_chi,
                    TenHocPhan = item.ten_hoc_phan,
                    SoTietLt = item.so_tiet_lt,
                    SoTietTh = item.so_tiet_th,
                    BatBuoc = item.bat_buoc,
                    IsScheduled = item.is_scheduled,
                    TienQuyet = item.tien_quyet,
                    HocKi = item.hoc_ki,
                    SoTietMoiTuan = item.so_tiet_moi_tuan,
                    SoBuoiMoiTuan = item.so_buoi_moi_tuan,
                    SiSo = item.si_so
                };
                objItems.ListHocPhan.Add(tg);
            }
            return Task.FromResult(objItems);
        }
        #endregion

        #region Tìm dữ liệu học phần theo mã học phần
        public override Task<HocPhanData> GetHocPhan(RequestMaHP request, ServerCallContext context)
        {
            var item = HocPhanRepository.TT_HOCPHAN(request.MaHocPhan);
            HocPhanData tg = new HocPhanData
            {
                MaHocPhan = item.ma_hoc_phan,
                MaDonVi = item.ma_don_vi,
                SoTinChi = item.so_tin_chi,
                TenHocPhan = item.ten_hoc_phan,
                SoTietLt = item.so_tiet_lt,
                SoTietTh = item.so_tiet_th,
                BatBuoc = item.bat_buoc,
                IsScheduled = item.is_scheduled,
                TienQuyet = item.tien_quyet,
                HocKi = item.hoc_ki,
                SoTietMoiTuan = item.so_tiet_moi_tuan,
                SoBuoiMoiTuan = item.so_buoi_moi_tuan,
                SiSo = item.si_so
            };
            return Task.FromResult(tg);
        }
        #endregion
    }
}
