/*
 *所有关于Equipment类的业务代码应在此处编写
*可使用repository.调用常用方法，获取EF/Dapper等信息
*如果需要事务请使用repository.DbContextBeginTransaction
*也可使用DBServerProvider.手动获取数据库相关信息
*用户信息、权限、角色等使用UserContext.Current操作
*EquipmentService对增、删、改查、导入、导出、审核业务代码扩展参照ServiceFunFilter
*/
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;
using System.Linq;
using VOL.Core.Utilities;
using System.Linq.Expressions;
using VOL.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using VOL.Business.IRepositories;
using System.Collections.Generic;
using VOL.Business.Repositories;
using System;

namespace VOL.Business.Services
{
    public partial class EquipmentService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IEquipmentRepository _repository;//访问数据库
        private readonly IStationManagementRepository _stationManagementRepository;//访问数据库
        [ActivatorUtilitiesConstructor]
        public EquipmentService(
            IEquipmentRepository dbRepository,
            IHttpContextAccessor httpContextAccessor,
            IStationManagementRepository stationManagementRepository
            )
        : base(dbRepository)
        {
            _httpContextAccessor = httpContextAccessor;
            _repository = dbRepository;
            _stationManagementRepository = stationManagementRepository;
            //多租户会用到这init代码，其他情况可以不用
            //base.Init(dbRepository);
        }

        public List<Equipment> GetEquipmentByStation(string StationName)
        {
            var stationInfo = _stationManagementRepository.Find(c => c.StaionName == StationName).FirstOrDefault();
            if (stationInfo != null)
            {
                return _repository.Find(c => c.StationID == stationInfo.ID).ToList();
            }
            return new List<Equipment>();
        }
        WebResponseContent webResponseContent = new WebResponseContent();
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="saveDataModel"></param>
        /// <returns></returns>
        public override WebResponseContent Add(SaveModel saveDataModel)
        {
            string equipmentNo = saveDataModel.MainData["EquipmentNo"].ToString();
            var equipmenList = _repository.Find(c => c.EquipmentNo == equipmentNo);
            if (equipmenList.Count > 0)
                return webResponseContent.Error("设备编号:[" + equipmentNo + "]已存在！");

            Equipment equipment = new Equipment()
            {
                EquipmentNo = saveDataModel.MainData["EquipmentNo"].ToString(),
                EquipmentName = saveDataModel.MainData["EquipmentName"].ToString(),
                LineID = Convert.ToInt32(saveDataModel.MainData["LineID"]),
                StationID = Convert.ToInt32(saveDataModel.MainData["StationID"])
            };

            try
            {
                _repository.Add(equipment, true);
                return webResponseContent.OK("设备编号:[" + equipmentNo + "]新增成功！");
            }
            catch (Exception ex)
            {
                return webResponseContent.Error("设备编号:[" + equipmentNo + "]新增失败！原因:" + ex.Message);
            }
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="saveModel"></param>
        /// <returns></returns>
        public override WebResponseContent Update(SaveModel saveModel)
        {
            string equipmentNo = saveModel.MainData["EquipmentNo"].ToString();
            var equipmentList = _repository.Find(c => c.EquipmentNo == equipmentNo && c.ID != Convert.ToInt32(saveModel.MainData["ID"]));
            if (equipmentList.Count > 0)
                return webResponseContent.Error("设备编号:[" + equipmentNo + "]已存在！");

            Equipment equipment = _repository.FindFirst(c => c.ID == Convert.ToInt32(saveModel.MainData["ID"]));
            equipment.EquipmentName = saveModel.MainData["EquipmentName"].ToString();
            equipment.EquipmentNo = equipmentNo;
            try
            {
                _repository.Update(equipment, true);
                return webResponseContent.OK("设备编号:[" + equipmentNo + "]信息修改成功！");
            }
            catch (Exception ex)
            {
                return webResponseContent.Error("设备编号:[" + equipmentNo + "]信息修改失败！原因:" + ex.Message);
            }
        }
    }
}
