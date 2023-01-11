/*
 *所有关于ProductLine类的业务代码应在此处编写
*可使用repository.调用常用方法，获取EF/Dapper等信息
*如果需要事务请使用repository.DbContextBeginTransaction
*也可使用DBServerProvider.手动获取数据库相关信息
*用户信息、权限、角色等使用UserContext.Current操作
*ProductLineService对增、删、改查、导入、导出、审核业务代码扩展参照ServiceFunFilter
*/
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;
using System.Linq;
using VOL.Core.Utilities;
using System.Linq.Expressions;
using VOL.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using VOL.Business.IRepositories;
using VOL.Core.ManageUser;
using System;

namespace VOL.Business.Services
{
    public partial class ProductLineService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IProductLineRepository _repository;//访问数据库
        private readonly IStationManagementRepository _station;//工位

        [ActivatorUtilitiesConstructor]
        public ProductLineService(
            IProductLineRepository dbRepository,
            IHttpContextAccessor httpContextAccessor,
            IStationManagementRepository stationRepository
            )
        : base(dbRepository)
        {
            _httpContextAccessor = httpContextAccessor;
            _repository = dbRepository;
            _station = stationRepository;
            //多租户会用到这init代码，其他情况可以不用
            //base.Init(dbRepository);
        }

        WebResponseContent webResponseContent = new WebResponseContent();

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="saveDataModel"></param>
        /// <returns></returns>
        public override WebResponseContent Add(SaveModel saveDataModel)
        {
            string lineName = saveDataModel.MainData["LineName"].ToString();
            var lineList = _repository.Find(c => c.LineName == lineName);
            if (lineList.Count > 0)
                return webResponseContent.Error("线体编号:[" + lineName + "]已存在！");

            ProductLine productLine = new ProductLine() {
                LineName = saveDataModel.MainData["LineName"].ToString(),
                LineDecription = saveDataModel.MainData["LineDecription"].ToString(),
                LineStatus = "0",
                OperatorName = UserContext.Current.UserName,
                UpTime = DateTime.Now
            };

            try
            {
                _repository.Add(productLine, true);
                return webResponseContent.OK("线体编号:[" + lineName + "]新增成功！");
            }
            catch (Exception ex)
            {
                return webResponseContent.Error("线体编号:[" + lineName + "]新增失败！原因:" + ex.Message);
            }
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="saveModel"></param>
        /// <returns></returns>
        public override WebResponseContent Update(SaveModel saveModel)
        {
            string lineName = saveModel.MainData["LineName"].ToString();
            var lineList = _repository.Find(c => c.LineName == lineName && c.ID != Convert.ToInt32(saveModel.MainData["ID"]));
            if (lineList.Count > 0)
                return webResponseContent.Error("线体编号:[" + lineName + "]已存在！");

            ProductLine productLine = _repository.FindFirst(c => c.ID == Convert.ToInt32(saveModel.MainData["ID"]));
            productLine.OperatorName = UserContext.Current.UserName;
            productLine.UpTime = DateTime.Now;
            productLine.LineDecription = saveModel.MainData["LineDecription"].ToString();

            try
            {
                _repository.Update(productLine, true);
                return webResponseContent.OK("线体编号:[" + lineName + "]修改成功！");
            }
            catch (Exception ex)
            {
                return webResponseContent.Error("线体编号:[" + lineName + "]修改失败！原因:" + ex.Message);
            }
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="keys"></param>
        /// <param name="delList"></param>
        /// <returns></returns>
        public override WebResponseContent Del(object[] keys, bool delList = false)
        {

            var stationList = _station.Find(c => c.LineID == Convert.ToInt32(keys[0]));
            if (stationList.Count > 0)
            {
                return webResponseContent.Error("该产线下有工位存在,不能删除!");
            }
            ProductLine productLine = _repository.FindFirst(c => c.ID == Convert.ToInt32(keys[0]));
            try
            {
                _repository.Delete(productLine, true);
                return webResponseContent.OK("删除成功！");
            }
            catch (Exception ex)
            {
                return webResponseContent.Error("删除失败！原因:" + ex.Message);
            }
        }
    }
}
