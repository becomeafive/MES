/*
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下EquipmentRepairService与IEquipmentRepairService中编写
 */
using VOL.Business.IRepositories;
using VOL.Business.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VOL.Business.Services
{
    public partial class EquipmentRepairService : ServiceBase<EquipmentRepair, IEquipmentRepairRepository>
    , IEquipmentRepairService, IDependency
    {
    public EquipmentRepairService(IEquipmentRepairRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static IEquipmentRepairService Instance
    {
      get { return AutofacContainerModule.GetService<IEquipmentRepairService>(); } }
    }
 }
