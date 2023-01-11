/*
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下ComponentMaintenanceService与IComponentMaintenanceService中编写
 */
using VOL.Business.IRepositories;
using VOL.Business.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VOL.Business.Services
{
    public partial class ComponentMaintenanceService : ServiceBase<ComponentMaintenance, IComponentMaintenanceRepository>
    , IComponentMaintenanceService, IDependency
    {
    public ComponentMaintenanceService(IComponentMaintenanceRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static IComponentMaintenanceService Instance
    {
      get { return AutofacContainerModule.GetService<IComponentMaintenanceService>(); } }
    }
 }
