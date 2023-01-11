/*
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下StationInfoService与IStationInfoService中编写
 */
using System.Collections.Generic;
using VOL.Business.IRepositories;
using VOL.Business.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VOL.Business.Services
{
    public partial class StationInfoService : ServiceBase<StationInfo, IStationInfoRepository>
    , IStationInfoService, IDependency
    {
    public StationInfoService(IStationInfoRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static IStationInfoService Instance
    {
      get { return AutofacContainerModule.GetService<IStationInfoService>(); } }

    }
 }
