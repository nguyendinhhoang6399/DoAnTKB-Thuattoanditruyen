using Google.Protobuf.WellKnownTypes;
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
    public class PhongHocService : PhongHoc.PhongHocBase
    {
        #region hiển thị danh sách phong hoc
        public override Task<DanhSachPhongHoc> DSPhongHoc(Empty request, ServerCallContext context)
        {

            DanhSachPhongHoc objItems = new DanhSachPhongHoc();

            foreach (var item in PhongHocRepository.TT_DS_PHONGHOC())
            {
                PhongHocData tg = new PhongHocData
                {
                    IdNhaHoc = item.id_nha_hoc,
                    IdPhongHoc = item.id_phong_hoc,
                    SucChua = item.suc_chua,
                    TenPhongHoc = item.ten_phong_hoc
                };
                objItems.ListPhongHoc.Add(tg);
            }
            return Task.FromResult(objItems);
        }
        #endregion
        #region hiển thịthông tin phong hoc
        public override Task<PhongHocData> GetPhongHoc(RequestID request, ServerCallContext context)
        {
            PhongHocModel item = PhongHocRepository.TT_GET_PHONGHOC(request.Id);
            PhongHocData tg = new PhongHocData
            {
                IdNhaHoc = item.id_nha_hoc,
                IdPhongHoc = item.id_phong_hoc,
                SucChua = item.suc_chua,
                TenPhongHoc = item.ten_phong_hoc
            };
            return Task.FromResult(tg);
        }
        #endregion
        #region hiển thị danh sách phong hoc
        public override Task<DanhSachNhaHoc> DSNhaHoc(Empty request, ServerCallContext context)
        {

            DanhSachNhaHoc objItems = new DanhSachNhaHoc();

            foreach (var item in PhongHocRepository.TT_DS_NHAHOC())
            {
                objItems.ListNhaHoc.Add(item);
            }
            return Task.FromResult(objItems);
        }
        #endregion
    }
}
