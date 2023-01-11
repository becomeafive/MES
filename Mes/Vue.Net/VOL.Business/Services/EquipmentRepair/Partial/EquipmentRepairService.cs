/*
 *所有关于EquipmentRepair类的业务代码应在此处编写
*可使用repository.调用常用方法，获取EF/Dapper等信息
*如果需要事务请使用repository.DbContextBeginTransaction
*也可使用DBServerProvider.手动获取数据库相关信息
*用户信息、权限、角色等使用UserContext.Current操作
*EquipmentRepairService对增、删、改查、导入、导出、审核业务代码扩展参照ServiceFunFilter
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
using VOL.Core.ManageUser;
using System;

namespace VOL.Business.Services
{
    public partial class EquipmentRepairService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IEquipmentRepairRepository _repository;//访问数据库

        [ActivatorUtilitiesConstructor]
        public EquipmentRepairService(
            IEquipmentRepairRepository dbRepository,
            IHttpContextAccessor httpContextAccessor
            )
        : base(dbRepository)
        {
            _httpContextAccessor = httpContextAccessor;
            _repository = dbRepository;
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
            EquipmentRepair repair = new EquipmentRepair()
            {
                AlarmCode = saveDataModel.MainData["AlarmCode"].ToString(),
                AlarmDescription = saveDataModel.MainData["AlarmDescription"].ToString(),
                EquipmentNo = saveDataModel.MainData["EquipmentNo"].ToString(),
                CreateOperator = UserContext.Current.UserName,
                CreateTime = DateTime.Now,
                
            };
            if (!string.IsNullOrWhiteSpace(saveDataModel.MainData["RepairTime"].ToString()))
            {
                repair.RepairDescription = saveDataModel.MainData["RepairDescription"].ToString();
                repair.RepairOperator = UserContext.Current.UserName;
                repair.RepairTime = saveDataModel.MainData["RepairTime"].ToDateTime();
            }
            

            try
            {
                _repository.Add(repair, true);
                return webResponseContent.OK();
            }
            catch (Exception ex)
            {
                return webResponseContent.Error("维修记录新增失败！原因:" + ex.Message);
            }
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="saveModel"></param>
        /// <returns></returns>
        public override WebResponseContent Update(SaveModel saveModel)
        {
            EquipmentRepair repair = _repository.FindFirst(c => c.ID == Convert.ToInt32(saveModel.MainData["ID"]));
            repair.RepairDescription = saveModel.MainData["RepairDescription"].ToString();
            repair.RepairOperator = UserContext.Current.UserName;
            repair.RepairTime = saveModel.MainData["RepairTime"].ToDateTime();

            try
            {
                _repository.Update(repair, true);
                return webResponseContent.OK();
            }
            catch (Exception ex)
            {
                return webResponseContent.Error("维修记录修改失败！原因:" + ex.Message);
            }
        }
    }
}
