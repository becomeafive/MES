/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *Repository提供数据库操作，如果要增加数据库操作请在当前目录下Partial文件夹PositionMaintenanceRepository编写代码
 */
using VOL.Business.IRepositories;
using VOL.Core.BaseProvider;
using VOL.Core.EFDbContext;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VOL.Business.Repositories
{
    public partial class PositionMaintenanceRepository : RepositoryBase<PositionMaintenance> , IPositionMaintenanceRepository
    {
    public PositionMaintenanceRepository(VOLContext dbContext)
    : base(dbContext)
    {

    }
    public static IPositionMaintenanceRepository Instance
    {
      get {  return AutofacContainerModule.GetService<IPositionMaintenanceRepository>(); } }
    }
}
