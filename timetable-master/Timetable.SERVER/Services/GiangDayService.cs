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
    public class GiangDayService : GiangDay.GiangDayBase
    {
        #region hiển thị danh sách can bo giang day
        public override Task<DanhSachGiangDay> DSGiangDay(Empty request, ServerCallContext context)
        {

            DanhSachGiangDay objItems = new DanhSachGiangDay();

            foreach (var item in GiangDayRepository.TT_DS_GIANGDAY())
            {
                GiangDayData tg = new GiangDayData
                {
                    IdCanBo = item.id_can_bo,
                    MaHocPhan = item.ma_hoc_phan,
                    SoNhomGiangDay = item.so_nhom_giang_day,
                    IdHocKi = item.id_hoc_ki
                };
                objItems.ListGiangDay.Add(tg);
            }
            return Task.FromResult(objItems);
        }
        //Danh sách giảng dạy theo học kì
        public override Task<DanhSachGiangDay> DSGiangDayHK(requestIDHK request, ServerCallContext context)
        {

            DanhSachGiangDay objItems = new DanhSachGiangDay();

            foreach (var item in GiangDayRepository.TT_DS_GIANGDAY(request.HocKi, request.NamHoc))
            {
                GiangDayData tg = new GiangDayData
                {
                    IdCanBo = item.id_can_bo,
                    MaHocPhan = item.ma_hoc_phan,
                    SoNhomGiangDay = item.so_nhom_giang_day,
                    IdHocKi = item.id_hoc_ki
                };
                objItems.ListGiangDay.Add(tg);
            }
            return Task.FromResult(objItems);
        }
        #endregion

        #region hiển thị danh sách can bo giang day theo hoc phan
        public override Task<DanhSachGiangDay> DSGiangDayHP(RequestMaSo request, ServerCallContext context)
        {

            DanhSachGiangDay objItems = new DanhSachGiangDay();

            foreach (var item in GiangDayRepository.TT_DS_GIANGDAY(request.Maso))
            {
                GiangDayData tg = new GiangDayData
                {
                    IdCanBo = item.id_can_bo,
                    MaHocPhan = item.ma_hoc_phan,
                    SoNhomGiangDay = item.so_nhom_giang_day,
                    IdHocKi = item.id_hoc_ki
                };
                objItems.ListGiangDay.Add(tg);
            }
            return Task.FromResult(objItems);
        }
        #endregion

        #region hiển thị danh sách can bo giang day theo canbo
        public override Task<DanhSachGiangDay> DSGiangDayGV(RequestID request, ServerCallContext context)
        {

            DanhSachGiangDay objItems = new DanhSachGiangDay();

            foreach (var item in GiangDayRepository.TT_DS_GIANGDAY(request.Id))
            {
                GiangDayData tg = new GiangDayData
                {
                    IdCanBo = item.id_can_bo,
                    MaHocPhan = item.ma_hoc_phan,
                    SoNhomGiangDay = item.so_nhom_giang_day,
                    IdHocKi = item.id_hoc_ki
                };
                objItems.ListGiangDay.Add(tg);
            }
            return Task.FromResult(objItems);
        }
        #endregion
        #region thêm thoonng tin giảng dạy
        public override Task<StatusResponse> insertGiangDay(GiangDayData request, ServerCallContext context)
        {
            Response result = GiangDayRepository.TT_INSERT_GIANGDAY(request);

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
        #region cập nhật thông tin giảng dạy
        public override Task<StatusResponse> updateGiangDay(GiangDayData request, ServerCallContext context)
        {
            Response result = GiangDayRepository.TT_UPDATE_GIANGDAY(request);

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
        #region xóa thông tin giảng dạy 
        public override Task<StatusResponse> deleteGiangDay(RequestGD request, ServerCallContext context)
        {
            Response result = GiangDayRepository.TT_DELETE_GIANGDAY(request);

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
    }
}
