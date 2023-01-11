/*
 *所有关于EquipmentAlarm类的业务代码应在此处编写
*可使用repository.调用常用方法，获取EF/Dapper等信息
*如果需要事务请使用repository.DbContextBeginTransaction
*也可使用DBServerProvider.手动获取数据库相关信息
*用户信息、权限、角色等使用UserContext.Current操作
*EquipmentAlarmService对增、删、改查、导入、导出、审核业务代码扩展参照ServiceFunFilter
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

namespace VOL.Business.Services
{
    public partial class EquipmentAlarmService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IEquipmentAlarmRepository _repository;//访问数据库

        [ActivatorUtilitiesConstructor]
        public EquipmentAlarmService(
            IEquipmentAlarmRepository dbRepository,
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
            string alarmCode = saveDataModel.MainData["AlarmCode"].ToString();
            var AlarmList = _repository.Find(c => c.AlarmCode == alarmCode);
            if (AlarmList.Count > 0)
                return webResponseContent.Error("故障代码:[" + alarmCode + "]已存在！");

            EquipmentAlarm alarm = new EquipmentAlarm()
            {
                AlarmType = saveDataModel.MainData["AlarmType"].ToString(),
                AlarmCode = saveDataModel.MainData["AlarmCode"].ToString(),
                AlarmDescription = saveDataModel.MainData["AlarmDescription"].ToString()
            };

            try
            {
                _repository.Add(alarm, true);
                return webResponseContent.OK("故障代码:[" + alarmCode + "]新增成功！");
            }
            catch (Exception ex)
            {
                return webResponseContent.Error("故障代码:[" + alarmCode + "]新增失败！原因:" + ex.Message);
            }
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="saveModel"></param>
        /// <returns></returns>
        public override WebResponseContent Update(SaveModel saveModel)
        {
            string alarmCode = saveModel.MainData["AlarmCode"].ToString();
            var alarmList = _repository.Find(c => c.AlarmCode == alarmCode && c.ID != Convert.ToInt32(saveModel.MainData["ID"]));
            if (alarmList.Count > 0)
                return webResponseContent.Error("故障代码:[" + alarmCode + "]已存在！");

            EquipmentAlarm alarm = _repository.FindFirst(c => c.ID == Convert.ToInt32(saveModel.MainData["ID"]));
            alarm.AlarmType = saveModel.MainData["AlarmType"].ToString();
            alarm.AlarmCode = alarmCode;
            alarm.AlarmDescription = saveModel.MainData["AlarmDescription"].ToString();
            try
            {
                _repository.Update(alarm, true);
                return webResponseContent.OK("设备编号:[" + alarmCode + "]信息修改成功！");
            }
            catch (Exception ex)
            {
                return webResponseContent.Error("设备编号:[" + alarmCode + "]信息修改失败！原因:" + ex.Message);
            }
        }
    }
}
