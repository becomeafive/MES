/*
 *所有关于StationManagement类的业务代码应在此处编写
*可使用repository.调用常用方法，获取EF/Dapper等信息
*如果需要事务请使用repository.DbContextBeginTransaction
*也可使用DBServerProvider.手动获取数据库相关信息
*用户信息、权限、角色等使用UserContext.Current操作
*StationManagementService对增、删、改查、导入、导出、审核业务代码扩展参照ServiceFunFilter
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
using System;
using VOL.Core.ManageUser;

namespace VOL.Business.Services
{
    public partial class StationManagementService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IStationManagementRepository _repository;//访问数据库
        private readonly IProductLineRepository _productLine;//产线访问
        private readonly IEquipmentRepository _equipment;//设备访问

        [ActivatorUtilitiesConstructor]
        public StationManagementService(
            IStationManagementRepository dbRepository,
            IHttpContextAccessor httpContextAccessor,
            IProductLineRepository productLine,
            IEquipmentRepository equipment
            )
        : base(dbRepository)
        {
            _httpContextAccessor = httpContextAccessor;
            _repository = dbRepository;
            _productLine = productLine;
            _equipment = equipment;
            //多租户会用到这init代码，其他情况可以不用
            //base.Init(dbRepository);
        }

        WebResponseContent webResponseContent = new WebResponseContent();

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="saveDataModel"></param>
        /// <returns></returns>
        public override WebResponseContent Add(SaveModel saveDataModel)
        {
            string staionName = saveDataModel.MainData["StaionName"].ToString();
            var staionList = _repository.Find(c => c.StaionName == staionName);
            if (staionList.Count > 0)
                return webResponseContent.Error("工位编号:[" + staionName + "]已存在！");

            StationManagement station = new StationManagement()
            {
                StaionName = saveDataModel.MainData["StaionName"].ToString(),
                LineID = Convert.ToInt32(saveDataModel.MainData["LineID"]),
                StationOrder = Convert.ToInt32(saveDataModel.MainData["StationOrder"]),
                StationRemark = saveDataModel.MainData["StationRemark"].ToString(),
                IP = saveDataModel.MainData["IP"].ToString()
            };
            ProductLine productLine = _productLine.FindFirst(c => c.ID == Convert.ToInt32(saveDataModel.MainData["LineID"]));
            productLine.LineStatus = "1";
            try
            {
                WebResponseContent webResponse = repository.DbContextBeginTransaction(() =>
                {
                    _repository.Add(station, true);
                    _productLine.Update(productLine, true);
                    return new WebResponseContent().OK();
                });
                //判断事务是否执行成功
                if (webResponse.Status)
                    return webResponseContent.OK("工位编号:[" + staionName + "]新增成功！");
                else
                    return webResponseContent.Error("工位编号:[" + staionName + "]新增失败！原因:" + webResponse.Message);
            }
            catch (Exception ex)
            {
                return webResponseContent.Error("工位编号:[" + staionName + "]新增失败！原因:" + ex.Message);
            }
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="saveModel"></param>
        /// <returns></returns>
        public override WebResponseContent Update(SaveModel saveModel)
        {
            string stationName = saveModel.MainData["StaionName"].ToString();
            var staionList = _repository.Find(c => c.StaionName == stationName && c.ID != Convert.ToInt32(saveModel.MainData["ID"]));
            if (staionList.Count > 0)
                return webResponseContent.Error("工位编号:[" + stationName + "]已存在！");

            StationManagement station = _repository.FindFirst(c => c.ID == Convert.ToInt32(saveModel.MainData["ID"]));
            station.StaionName = saveModel.MainData["StaionName"].ToString();
            station.StationOrder = Convert.ToInt32(saveModel.MainData["StationOrder"]);
            station.StationRemark = saveModel.MainData["StationRemark"].ToString();
            station.IP = saveModel.MainData["IP"].ToString();

            try
            {
                _repository.Update(station, true);
                return webResponseContent.OK("工位编号:[" + station.StaionName + "]修改成功！");
            }
            catch (Exception ex)
            {
                return webResponseContent.Error("工位编号:[" + station.StaionName + "]修改失败！原因:" + ex.Message);
            }
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="keys"></param>
        /// <param name="delList"></param>
        /// <returns></returns>
        public override WebResponseContent Del(object[] keys, bool delList = false)
        {
            
            var equipmentList = _equipment.Find(c => c.StationID == Convert.ToInt32(keys[0]));
            if (equipmentList.Count > 0)
            {
                return webResponseContent.Error("该工位下有设备存在,不能删除!");
            }
            StationManagement station = _repository.FindFirst(c => c.ID == Convert.ToInt32(keys[0]));
            ProductLine line = _productLine.FindFirst(c => c.ID == station.LineID);

            try
            {
                _repository.Delete(station, true);

                var staionCount = _repository.Find(c => c.LineID == line.ID);
                if (staionCount.Count == 0)
                {
                    line.LineStatus = "0";
                    line.OperatorName = UserContext.Current.UserName;
                    line.UpTime = DateTime.Now;
                    _productLine.Update(line, true);
                }
                return webResponseContent.OK("删除成功！");
            }
            catch (Exception ex)
            {
                return webResponseContent.Error("删除失败！原因:" + ex.Message);
            }
        }
    }
}
