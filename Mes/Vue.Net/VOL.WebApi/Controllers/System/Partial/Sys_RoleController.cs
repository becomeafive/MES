using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VOL.Business.IRepositories;
using VOL.Business.Repositories;
using VOL.Core.Controllers.Basic;
using VOL.Core.Enums;
using VOL.Core.Filters;
using VOL.Core.ManageUser;
using VOL.Core.UserManager;
using VOL.Core.Utilities;
using VOL.Entity.AttributeManager;
using VOL.Entity.DomainModels;
using VOL.System.IServices;
using VOL.System.Repositories;
using VOL.System.Services;

namespace VOL.System.Controllers
{
    [Route("api/role")]
    public partial class Sys_RoleController
    {
        [HttpPost, Route("getCurrentTreePermission")]
        [ApiActionPermission(ActionPermissionOptions.Search)]
        public async Task<IActionResult> GetCurrentTreePermission()
        {
            return Json(await Service.GetCurrentTreePermission());
        }

        [HttpPost, Route("getUserTreePermission")]
        [ApiActionPermission(ActionPermissionOptions.Search)]
        public async Task<IActionResult> GetUserTreePermission(int roleId)
        {
            return Json(await Service.GetUserTreePermission(roleId));
        }

        [HttpPost, Route("savePermission")]
        [ApiActionPermission(ActionPermissionOptions.Update)]
        public async Task<IActionResult> SavePermission([FromBody] List<UserPermissions> userPermissions, int roleId)
        {
            return Json(await Service.SavePermission(userPermissions, roleId));
        }

        /// <summary>
        /// 获取当前角色下的所有角色 
        /// </summary>
        /// <returns></returns>

        [HttpPost, Route("getUserChildRoles")]
        [ApiActionPermission(ActionPermissionOptions.Search)]
        public IActionResult GetUserChildRoles()
        {
            int roleId = UserContext.Current.RoleId;
            var data = RoleContext.GetAllChildren(UserContext.Current.RoleId);

            if (UserContext.Current.IsSuperAdmin)
            {
                return Json(WebResponseContent.Instance.OK(null, data));
            }
            //不是超级管理，将自己的角色查出来，在树形菜单上作为根节点
            var self = Sys_RoleRepository.Instance.FindAsIQueryable(x => x.Role_Id == roleId)
                 .Select(s => new VOL.Core.UserManager.RoleNodes()
                 {
                     Id = s.Role_Id,
                     ParentId = 0,//将自己的角色作为root节点
                     RoleName = s.RoleName
                 }).ToList();
            data.AddRange(self);
            return Json(WebResponseContent.Instance.OK(null, data));
        }

        [HttpPost, Route("GetLines")]
        [ApiActionPermission(ActionPermissionOptions.Search)]
        public IActionResult GetLines()
        {
            List<VOL.Core.UserManager.RoleNodes> data = new List<Core.UserManager.RoleNodes>();
            data.AddRange(
            ProductLineRepository.Instance.Find(c => true).Select(c=>new VOL.Core.UserManager.RoleNodes
            {
                Id = c.ID,
                ParentId = 0,//将自己的角色作为root节点
                RoleName = c.LineName,
            }) );

            data.AddRange(
            StationManagementRepository.Instance.Find(c => true).Select(c => new VOL.Core.UserManager.RoleNodes
            {
                Id = c.ID,
                ParentId = c.LineID,//将自己的角色作为root节点
                RoleName = c.StaionName
            }));
            return Json(WebResponseContent.Instance.OK(null, data));
        }

        [HttpPost, Route("GetProductType")]
        [ApiActionPermission(ActionPermissionOptions.Search)]
        public IActionResult GetProductType()
        {
            List<VOL.Core.UserManager.RoleNodes> data = new List<Core.UserManager.RoleNodes>();
            data.AddRange(
            ProductInfoRepository.Instance.Find(c => true).Select(c => new VOL.Core.UserManager.RoleNodes
            {
                Id = c.ID,
                ParentId = 0,//将自己的角色作为root节点
                RoleName = c.ProductType
            }));
        
            return Json(WebResponseContent.Instance.OK(null, data));
        }
    }
}


