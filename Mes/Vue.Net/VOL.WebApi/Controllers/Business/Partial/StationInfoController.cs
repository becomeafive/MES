/*
 *Author：PQ
 *Date：2023-01-06
 * 此代码由框架自动生成，请勿更改
 */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using VOL.Entity.DomainModels;
using VOL.Business.IServices;
using VOL.Business.IRepositories;
using VOL.Core.Filters;
using VOL.Business.Services;

namespace VOL.Business.Controllers
{
    public partial class StationInfoController
    {
        private readonly IStationInfoService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;
        private IStationInfoService _stationInfoService;

        [ActivatorUtilitiesConstructor]
        public StationInfoController(
            IStationInfoService service,
            IHttpContextAccessor httpContextAccessor,
            IStationInfoService stationrepository
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
            _stationInfoService = stationrepository;
        }

        [HttpPost, Route("GetStionSelect")]
        [ApiActionPermission()]
        public List<ReturnData> GetStionSelect([FromQuery] int ID)
        {
           var list= _stationInfoService.GetStationInfos(ID);

            return list;
        }

    }
}
