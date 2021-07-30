using Core.Database;
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
    public class NhomHocPhanService : NhomHocPhan.NhomHocPhanBase
    {
        #region hiển thị danh sách nhom hoc phan
        public override Task<DanhSachNhomHP> DSNhomHP(requestIDHK request, ServerCallContext context)
        {

            DanhSachNhomHP objItems = new DanhSachNhomHP();

            foreach (var item in NhomHPRepository.TT_DS_NHOMHP(request.HocKi, request.NamHoc))
            {
                NhomHPData tg = new NhomHPData
                {
                    MaHocPhan = item.ma_hoc_phan,
                    MaNhomHp = item.ma_nhom_hp,
                    TenNhomHp = item.ten_nhom_hp,
                    SiSo = item.si_so,
                    TongBuoiHoc = item.tong_buoi_hoc,
                    TongTietHoc = item.tong_tiet_hoc,
                    IdHocKi = item.id_hoc_ki
                };
                objItems.ListNhomHP.Add(tg);
            }
            return Task.FromResult(objItems);
        }
        #endregion
        #region hiển thị thông tin nhóm học phần
        public override Task<NhomHPData> GetInfoNhomHP(RequestID request, ServerCallContext context)
        {

            var item = NhomHPRepository.TT_GET_NHOMHP(request.Id).FirstOrDefault();
            NhomHPData tg = new NhomHPData
            {
                MaHocPhan = item.ma_hoc_phan,
                MaNhomHp = item.ma_nhom_hp,
                TenNhomHp = item.ten_nhom_hp,
                SiSo = item.si_so,
                TongBuoiHoc = item.tong_buoi_hoc,
                TongTietHoc = item.tong_tiet_hoc,
                IdHocKi = item.id_hoc_ki
            };
            return Task.FromResult(tg);
        }
    #endregion
    #region Insert nhóm học phần
    public override Task<StatusResponse> InsertNhomHP(NhomHPData nhomHP, ServerCallContext context)
    {

        Response result = NhomHPRepository.TT_INS_NHOMHP(nhomHP);

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
    #endregion

    #region Insert nhóm học phần
    public override Task<StatusResponse> UpdateNhomHP(NhomHPData nhomHP, ServerCallContext context)
    {

        Response result = NhomHPRepository.TT_UPDATE_NHOMHP(nhomHP);

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
    #endregion

    #region Delete all nhóm học phần
    public override Task<StatusResponse> DelNhomHP(requestIDHK request, ServerCallContext context)
    {

        Response result = NhomHPRepository.TT_DELETEALL_NHOMHP(request.HocKi, request.NamHoc);

        if (result.resultExecute == 1)

        {
            return Task.FromResult(new StatusResponse()
            {
                Status = true,
                StatusCode = 100,
                StatusMessage = "Delete Successfully"
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
    #endregion
    #region Delete 1 nhóm học phần
    public override Task<StatusResponse> DeleteNhomHP(RequestID request, ServerCallContext context)
    {

        Response result = NhomHPRepository.TT_DEL_NHOMHP(request.Id);

        if (result.resultExecute == 1)

        {
            return Task.FromResult(new StatusResponse()
            {
                Status = true,
                StatusCode = 100,
                StatusMessage = "Delete Successfully"
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
    #endregion
}
}
