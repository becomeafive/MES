/*
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下EquipmentAlarmService与IEquipmentAlarmService中编写
 */
using VOL.Business.IRepositories;
using VOL.Business.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VOL.Business.Services
{
    public partial class EquipmentAlarmService : ServiceBase<EquipmentAlarm, IEquipmentAlarmRepository>
    , IEquipmentAlarmService, IDependency
    {
    public EquipmentAlarmService(IEquipmentAlarmRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static IEquipmentAlarmService Instance
    {
      get { return AutofacContainerModule.GetService<IEquipmentAlarmService>(); } }
    }
 }
