/*
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下DefectService与IDefectService中编写
 */
using VOL.Business.IRepositories;
using VOL.Business.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VOL.Business.Services
{
    public partial class DefectService : ServiceBase<Defect, IDefectRepository>
    , IDefectService, IDependency
    {
    public DefectService(IDefectRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static IDefectService Instance
    {
      get { return AutofacContainerModule.GetService<IDefectService>(); } }
    }
 }
