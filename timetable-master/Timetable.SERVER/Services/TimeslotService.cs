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
    public class TimeslotService : Timeslot.TimeslotBase
    {
        #region hiển thị danh sách tiet hoc trong tuan
        public override Task<DanhSachTimeslot> listTimeslot(Empty request, ServerCallContext context)
        {

            DanhSachTimeslot objItems = new DanhSachTimeslot();
            int id = 0;
            foreach (var thu in TimeslotRepository.TT_DS_THU())
            {
                Thu vthu = new Thu() { IdThu = thu.id_thu, Thu_ = thu.thu };
                foreach (var tiet in TimeslotRepository.TT_DS_TIET_HOC())
                {
                    TimeslotData tg = new TimeslotData
                    {
                        TimeslotID = id,
                        VThu = vthu,
                        VTiet = new Tiet()
                        {
                            IdTiet = tiet.id_tiet,
                            Tiet_ = tiet.tiet_hoc,
                            TgBatDau = tiet.tg_bat_dau,
                            TgKetThuc = tiet.tg_ket_thuc,
                            SoPhut = tiet.so_phut
                        }
                    };
                    objItems.Lst.Add(tg);
                    id++;
                }
            }
            return Task.FromResult(objItems);
        }
        #endregion

        #region thoi gian ban can bo
        public override Task<ListTimeBusyProf> listTBP(Empty request, ServerCallContext context)
        {
            ListTimeBusyProf list = new ListTimeBusyProf();
            foreach (var item in TimeslotRepository.TT_TimeBusyProf())
            {
                TimeBusyProf t = new TimeBusyProf()
                {
                    IdCanBo = item.id_can_bo,
                    IdThu = item.id_thu,
                    IdTiet = item.id_tiet,
                    LyDo = item.ly_do
                };
                list.ListTimeBusyProf_.Add(t);
            }
            return Task.FromResult(list);
        }
        public override Task<ListTimeBusyProf> listTimeBusyProf(RequestID request, ServerCallContext context)
        {
            ListTimeBusyProf list = new ListTimeBusyProf();
            foreach (var item in TimeslotRepository.TT_TimeBusyProf(request.Id))
            {
                TimeBusyProf t = new TimeBusyProf()
                {
                    IdCanBo = item.id_can_bo,
                    IdThu = item.id_thu,
                    IdTiet = item.id_tiet,
                    LyDo = item.ly_do
                };
                list.ListTimeBusyProf_.Add(t);
            }
            return Task.FromResult(list);
        }
        #endregion


        #region thoi gian ban phong hoc
        public override Task<ListTimeBusyRoom> listTBR(Empty request, ServerCallContext context)
        {
            ListTimeBusyRoom list = new ListTimeBusyRoom();
            foreach (var item in TimeslotRepository.TT_TimeBusyRoom())
            {
                TimeBusyRoom t = new TimeBusyRoom()
                {
                    IdPhongHoc = item.id_phong_hoc,
                    IdThu = item.id_thu,
                    IdTiet = item.id_tiet,
                    LyDo = item.ly_do
                };
                list.ListTimeBusyRoom_.Add(t);
            }
            return Task.FromResult(list);
        }
        #endregion

        #region danh sach hoc ki, nam hoc
        public override Task<HocKi> gethocki(requestIDHK request, ServerCallContext context)
        {
            var hkm = TimeslotRepository.TT_HocKi(request.HocKi, request.NamHoc).FirstOrDefault();
            HocKi hk = new HocKi()
            {
                IdHocKi = hkm.id_hoc_ki,
                HocKi_ = hkm.hoc_ki,
                NamHoc = hkm.nam_hoc,
                TgBatDau = hkm.tg_bat_dau,
                TgKetThuc = hkm.tg_ket_thuc
            };

            return Task.FromResult(hk);
        }
        public override Task<HocKi> gethockiByID(RequestID request, ServerCallContext context)
        {
            var hkm = TimeslotRepository.TT_HocKiByID(request.Id).FirstOrDefault();
            HocKi hk = new HocKi()
            {
                IdHocKi = hkm.id_hoc_ki,
                HocKi_ = hkm.hoc_ki,
                NamHoc = hkm.nam_hoc,
                TgBatDau = hkm.tg_bat_dau,
                TgKetThuc = hkm.tg_ket_thuc
            };

            return Task.FromResult(hk);
        }
        #endregion
    }
}
