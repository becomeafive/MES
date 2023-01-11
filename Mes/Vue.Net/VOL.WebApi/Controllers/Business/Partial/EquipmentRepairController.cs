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

namespace VOL.Business.Controllers
{
    public partial class EquipmentRepairController
    {
        private readonly IEquipmentRepairService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public EquipmentRepairController(
            IEquipmentRepairService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }
    }
}
