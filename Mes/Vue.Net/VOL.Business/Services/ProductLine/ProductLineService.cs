/*
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下ProductLineService与IProductLineService中编写
 */
using VOL.Business.IRepositories;
using VOL.Business.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VOL.Business.Services
{
    public partial class ProductLineService : ServiceBase<ProductLine, IProductLineRepository>
    , IProductLineService, IDependency
    {
    public ProductLineService(IProductLineRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static IProductLineService Instance
    {
      get { return AutofacContainerModule.GetService<IProductLineService>(); } }
    }
 }
