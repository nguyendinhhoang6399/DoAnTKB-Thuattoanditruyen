using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timetable.SERVER.Models;
using Timetable.SERVER.Protos;
using Timetable.SERVER.Repositories;

namespace Timetable.SERVER.Services
{
    public class CongTacService : CongTac.CongTacBase
    {
        #region Liet le danh sach tat ca don vi 
        public override Task<DanhSachCongTac> DSCongTacCB(RequestID request, ServerCallContext context)
        {
            List<CongTacModel> list = CongTacRepostory.TT_DS_CONGTAC(request.Id);
            DanhSachCongTac ds = new DanhSachCongTac();
            CanBoService cb = new CanBoService();
            DonViService dv = new DonViService();
            foreach (var item in list)
            {
                ChucVuModel cv = ChucVuRepository.TT_CHUCVU_INFO(item.ma_chuc_vu);
                CongTacData ct = new CongTacData()
                {
                    MaCongTac = item.ma_cong_tac,
                    NgayBD = item.ngay_bat_dau,
                    NgayKT = item.ngay_ket_thuc,
                    Chucvu = new ChucVuData()
                    {
                        MaChucVu = cv.ma_chuc_vu,
                        TenChucVu = cv.ten_chuc_vu,
                        MoTa = cv.mo_ta
                    },
                    Canbos = cb.FindCanBo(new FindCanBoRequest() { Idcanbo = item.id_can_bo }, context).Result,
                    Donvis = dv.DonViInfo(new RequestID() { Id = item.ma_don_vi }, context).Result
                };
                ds.ListCongTac.Add(ct);
            }
            return Task.FromResult(ds);
        }
        #endregion
    }
}
