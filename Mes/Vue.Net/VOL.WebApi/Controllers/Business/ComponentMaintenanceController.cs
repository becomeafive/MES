/*
 *Author：PQ
 *Date：2023-01-06
 * 此代码由框架自动生成，请勿更改
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using VOL.Business.IServices;
namespace VOL.Business.Controllers
{
    [Route("api/ComponentMaintenance")]
    [PermissionTable(Name = "ComponentMaintenance")]
    public partial class ComponentMaintenanceController : ApiBaseController<IComponentMaintenanceService>
    {
    public ComponentMaintenanceController(IComponentMaintenanceService service)
    : base(service)
    {
    }
    }
    }

