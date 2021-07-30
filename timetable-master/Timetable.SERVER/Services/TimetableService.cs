using Core.Database;
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
    public class TimetableService : Protos.Timetable.TimetableBase
    {
        #region danh sach thoi khoa bieu theo hoc ki
        public override Task<Timetables> listTimetable(requestIDHK request, ServerCallContext context)
        {
            Timetables list = new Timetables();
            foreach (var item in TimetableRepository.TT_GET_TIMETABLE(request.HocKi, request.NamHoc))
            {
                TimetableData t = new TimetableData()
                {
                    IdTimetable = item.id_tkb,
                    MaNhomHp = item.ma_nhom_hoc_phan,
                    IdCanBo = item.id_can_bo,
                    IdHocKi = item.id_hoc_ki,
                    IdPhongHoc = item.id_phong_hoc,
                    IdThu = item.thu,
                    IdTiet = item.tiet_bd,
                    SoTiet = item.so_tiet,
                    ViPham = item.vi_pham,
                    MaHocPhan = item.ma_hoc_phan,
                    TenHocPhan = item.ten_hoc_phan,
                    SoTc = item.so_tin_chi,
                    TenPhongHoc = item.ten_phong_hoc,
                    TenNhomHp = item.ten_nhom_hp
                };
                list.Tkb.Add(t);
            }
            return Task.FromResult(list);
        }
        #endregion
        #region danh sach thoi khoa bieu cua 1 phong hoc theo hoc ki
        public override Task<Timetables> TimetableOfRoom(RequestTimetableTeacher request, ServerCallContext context)
        {
            Timetables list = new Timetables();
            var listmodel = TimetableRepository.TT_GET_TIMETABLE_PH(request.IdCanBo.Id, request.HocKi.HocKi, request.HocKi.NamHoc);
            foreach (var item in listmodel)
            {
                TimetableData t = new TimetableData()
                {
                    IdTimetable = item.id_tkb,
                    MaNhomHp = item.ma_nhom_hoc_phan,
                    IdCanBo = item.id_can_bo,
                    IdHocKi = item.id_hoc_ki,
                    IdPhongHoc = item.id_phong_hoc,
                    IdThu = item.thu,
                    IdTiet = item.tiet_bd,
                    SoTiet = item.so_tiet,
                    ViPham = item.vi_pham,
                    MaHocPhan = item.ma_hoc_phan,
                    TenHocPhan = item.ten_hoc_phan,
                    SoTc = item.so_tin_chi,
                    TenPhongHoc = item.ten_phong_hoc,
                    TenNhomHp = item.ten_nhom_hp
                };
                list.Tkb.Add(t);
            }
            return Task.FromResult(list);
        }
        #endregion
        #region danh sach thoi khoa bieu cua 1 can bo theo hoc ki
        public override Task<Timetables> TimetableOfTeacher(RequestTimetableTeacher request, ServerCallContext context)
        {
            Timetables list = new Timetables();
            var listmodel = TimetableRepository.TT_GET_TIMETABLE(request.IdCanBo.Id, request.HocKi.HocKi, request.HocKi.NamHoc);
            foreach (var item in listmodel)
            {
                TimetableData t = new TimetableData()
                {
                    IdTimetable = item.id_tkb,
                    MaNhomHp = item.ma_nhom_hoc_phan,
                    IdCanBo = item.id_can_bo,
                    IdHocKi = item.id_hoc_ki,
                    IdPhongHoc = item.id_phong_hoc,
                    IdThu = item.thu,
                    IdTiet = item.tiet_bd,
                    SoTiet = item.so_tiet,
                    ViPham = item.vi_pham,
                    MaHocPhan = item.ma_hoc_phan,
                    TenHocPhan = item.ten_hoc_phan,
                    SoTc = item.so_tin_chi,
                    TenPhongHoc = item.ten_phong_hoc,
                    TenNhomHp = item.ten_nhom_hp
                };
                list.Tkb.Add(t);
            }
            return Task.FromResult(list);
        }
        public override Task<TimetableData> getInfoTimetableById(RequestID request, ServerCallContext context)
        {
            var item = TimetableRepository.TT_GET_TIMETABLE(request.Id).FirstOrDefault();
            TimetableData t = new TimetableData()
            {
                IdTimetable = item.id_tkb,
                MaNhomHp = item.ma_nhom_hoc_phan,
                IdCanBo = item.id_can_bo,
                IdHocKi = item.id_hoc_ki,
                IdPhongHoc = item.id_phong_hoc,
                IdThu = item.thu,
                IdTiet = item.tiet_bd,
                SoTiet = item.so_tiet,
                ViPham = item.vi_pham,
                MaHocPhan = item.ma_hoc_phan,
                TenHocPhan = item.ten_hoc_phan,
                SoTc = item.so_tin_chi,
                TenPhongHoc = item.ten_phong_hoc,
                TenNhomHp = item.ten_nhom_hp
            };

            return Task.FromResult(t);
        }
        #endregion
        #region lay thong tin thoi khoa bieu theo nhom hp, thu, tiet
        public override Task<TimetableData> getInfoTimetable(RequestGetInfoTimetable request, ServerCallContext context)
        {
            TimetableModel item = TimetableRepository.TT_GET_TIMETABLE(request.MaNhomHp, request.Tiet, request.Thu);

            TimetableData t = new TimetableData()
            {
                IdTimetable = item.id_tkb,
                MaNhomHp = item.ma_nhom_hoc_phan,
                IdCanBo = item.id_can_bo,
                IdHocKi = item.id_hoc_ki,
                IdPhongHoc = item.id_phong_hoc,
                IdThu = item.thu,
                IdTiet = item.tiet_bd,
                SoTiet = item.so_tiet,
                ViPham = item.vi_pham,
                MaHocPhan = item.ma_hoc_phan,
                TenHocPhan = item.ten_hoc_phan,
                SoTc = item.so_tin_chi,
                TenPhongHoc = item.ten_phong_hoc,
                TenNhomHp = item.ten_nhom_hp
            };

            return Task.FromResult(t);
        }
        #endregion
        #region insert thoi khoa bieu 
        public override Task<StatusResponse> insertTimetable(TimetableData request, ServerCallContext context)
        {
            Response result = TimetableRepository.TT_INSERT_TIMETABLE(request);

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
        #region update thoi khoa bieu 
        public override Task<StatusResponse> updateTimetable(TimetableData request, ServerCallContext context)
        {
            Response result = TimetableRepository.TT_UPDATE_TIMETABLE(request);

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

        #region delete tat ca thoi khoa bieu trong 1 hoc ki
        public override Task<StatusResponse> deleteAllTimetable(requestIDHK request, ServerCallContext context)
        {
            Response result = TimetableRepository.TT_DELETE_ALL_TIMETABLE(request.HocKi, request.NamHoc);

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
        #region delete thoi khoa bieu 
        public override Task<StatusResponse> deleteTimetable(RequestID request, ServerCallContext context)
        {
            Response result = TimetableRepository.TT_DELETE_TIMETABLE(request.Id);

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
