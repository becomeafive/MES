/*
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下EquipmentService与IEquipmentService中编写
 */
using VOL.Business.IRepositories;
using VOL.Business.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VOL.Business.Services
{
    public partial class EquipmentService : ServiceBase<Equipment, IEquipmentRepository>
    , IEquipmentService, IDependency
    {
    public EquipmentService(IEquipmentRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static IEquipmentService Instance
    {
      get { return AutofacContainerModule.GetService<IEquipmentService>(); } }
    }
 }
