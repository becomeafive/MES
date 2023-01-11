/*
 *所有关于ProductionPlan类的业务代码应在此处编写
*可使用repository.调用常用方法，获取EF/Dapper等信息
*如果需要事务请使用repository.DbContextBeginTransaction
*也可使用DBServerProvider.手动获取数据库相关信息
*用户信息、权限、角色等使用UserContext.Current操作
*ProductionPlanService对增、删、改查、导入、导出、审核业务代码扩展参照ServiceFunFilter
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
using System;
using VOL.Core.ManageUser;
using System.Collections.Generic;

namespace VOL.Business.Services
{
    public partial class ProductionPlanService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IProductionPlanRepository _repository;//访问数据库
        private readonly IProductVesionRepository _Vesionrepository;//访问数据库


        [ActivatorUtilitiesConstructor]
        public ProductionPlanService(
            IProductionPlanRepository dbRepository,
            IHttpContextAccessor httpContextAccessor,
            IProductVesionRepository Vesionrepository
            )
        : base(dbRepository)
        {
            _httpContextAccessor = httpContextAccessor;
            _repository = dbRepository;
            _Vesionrepository = Vesionrepository;
            //多租户会用到这init代码，其他情况可以不用
            //base.Init(dbRepository);
        }

        WebResponseContent responseContent = new WebResponseContent();
        public override WebResponseContent Add(SaveModel saveDataModel)
        {
            AddOnExecute = (SaveModel saveModel) =>
            {
                //如果返回false,后面代码不会再执行
                return responseContent.OK();
            };
            string Plano = saveDataModel.MainData["PlanNo"].ToString();
            int ProductType=Int32.Parse(saveDataModel.MainData["ProductType"].ToString());

            var PlanData = _repository.Find(c => c.PlanNo == Plano);
            if (PlanData.Count > 0)
            {
                return responseContent.Error("计划号:" + Plano + "已存在！请重新编写计划号");
            }

            var list = _Vesionrepository.Find(o=>o.ProductID== ProductType).OrderByDescending(q=> q.CreateTime).FirstOrDefault();

            ProductionPlan plan = new ProductionPlan();
            plan.PlanNo = saveDataModel.MainData["PlanNo"].ToString();
            plan.PlanSN = saveDataModel.MainData["PlanSN"].ToString();
            plan.ProductType = saveDataModel.MainData["ProductType"].ToString();
            plan.FormulaCode = list.VersionCode;
            //saveDataModel.MainData["FormulaCode"].ToString()
            plan.Status = saveDataModel.MainData["Status"].ToString();
            plan.PlanCreateTime = DateTime.Now;
            plan.PlanQty = 1;
            plan.OrderSoure = "1";

            try
            {
                _repository.Add(plan, true);
                return responseContent.OK("新增成功!创建的计划为:" + plan.PlanNo);
            }
            catch (Exception ex)
            {
                return responseContent.Error("新增计划失败!原因:" + ex.Message);
            }
        }
        /// <summary>
        /// 编辑操作
        /// </summary>
        /// <param name="saveModel"></param>
        /// <returns></returns>
        public override WebResponseContent Update(SaveModel saveModel)
        {
            UpdateOnExecute = (SaveModel model) =>
            {
                ////这里的设置配合下面order.Remark = "888"代码位置使用
                // saveModel.MainData.TryAdd("Remark", "1231");

                //如果不想前端提交某些可以编辑的字段的值,直接移除字段
                // saveModel.MainData.Remove("字段");

                //如果返回false,后面代码不会再执行
                return responseContent.OK();

            };
            int ID = Int32.Parse(saveModel.MainData["ID"].ToString());
            string Plano = saveModel.MainData["PlanNo"].ToString();

            var PlanData = _repository.Find(c => c.PlanNo == Plano && c.ID != ID);

            var list = _repository.Find(c => c.ID == ID).FirstOrDefault(); 

            if (PlanData.Count > 0)
            {
                return responseContent.Error("计划号:" + Plano + "已存在！不能修改成当前任务号!");
            }

            ProductionPlan plan = new ProductionPlan();

            plan.ID = Int32.Parse(saveModel.MainData["ID"].ToString());

            plan.PlanNo = saveModel.MainData["PlanNo"].ToString();
            plan.PlanSN = saveModel.MainData["PlanSN"].ToString();

            plan.FormulaCode = saveModel.MainData["FormulaCode"].ToString();
            plan.ProductType = saveModel.MainData["ProductType"].ToString();
            plan.Status = saveModel.MainData["Status"].ToString();
            plan.PlanQty = list.PlanQty;
            plan.PlanStartTime = list.PlanStartTime;
            plan.PlanEndTime = list.PlanEndTime;
            plan.PlanCreateTime = list.PlanCreateTime;
            plan.LineName = list.LineName;
            plan.PlanStion = list.PlanStion;
            plan.OrderSoure = list.OrderSoure;

            plan.ModifyID = UserContext.Current.UserId;
            plan.Modifier = UserContext.Current.UserName;
            plan.ModifyDate = DateTime.Now;

            try
            {
                _repository.Update(plan, true);
                return responseContent.OK("修改计划信息成功!");
            }
            catch (Exception ex)
            {
                return responseContent.OK("修改计划信息失败，原因:" + ex.Message);
            }
        }
    }
}
