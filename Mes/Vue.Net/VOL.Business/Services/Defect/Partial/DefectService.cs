/*
 *所有关于Defect类的业务代码应在此处编写
*可使用repository.调用常用方法，获取EF/Dapper等信息
*如果需要事务请使用repository.DbContextBeginTransaction
*也可使用DBServerProvider.手动获取数据库相关信息
*用户信息、权限、角色等使用UserContext.Current操作
*DefectService对增、删、改查、导入、导出、审核业务代码扩展参照ServiceFunFilter
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
using System.Collections.Generic;
using System;

namespace VOL.Business.Services
{
    public partial class DefectService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IDefectRepository _repository;//访问数据库

        [ActivatorUtilitiesConstructor]
        public DefectService(
            IDefectRepository dbRepository,
            IHttpContextAccessor httpContextAccessor
            )
        : base(dbRepository)
        {
            _httpContextAccessor = httpContextAccessor;
            _repository = dbRepository;
            //多租户会用到这init代码，其他情况可以不用
            //base.Init(dbRepository);
        }

        /// <summary>
        /// 新增缺陷单，判断缺陷代码是否重复
        /// </summary>
        /// <param name="saveModel"></param>
        /// <returns></returns>
        public override WebResponseContent Add(SaveModel saveModel)
        {
            WebResponseContent responseData = new WebResponseContent();

            Defect de = new Defect();
            de.DefectNo = saveModel.MainData["DefectNo"].ToString();
            de.DefectName = saveModel.MainData["DefectName"].ToString();
            de.DefectInfo = saveModel.MainData["DefectInfo"].ToString();
            //在AddOnExecuting之前已经对提交的数据做过验证是否为空
            base.AddOnExecuting = (Defect de, object obj) =>
            {
                de.DefectNo = de.DefectNo.Trim();
                if (repository.Exists(x => x.DefectNo == de.DefectNo))
                    return responseData.Error("缺陷代码已被使用");
                _repository.Add(de);
                //设置默认头像
                return responseData.OK();
            };
            return base.Add(saveModel); ;
        }


        /// <summary>
        /// 删除部件
        /// </summary>
        /// <param name="keys"></param>
        /// <param name="delList"></param>
        /// <returns></returns>
        public override WebResponseContent Del(object[] keys, bool delList = false)
        {
            base.DelOnExecuting = (object[] ids) =>
            {
                int[] Ids = ids.Select(x => Convert.ToInt32(x)).ToArray();
                foreach (int id in Ids)
                {
                    if (repository.Exists(x => x.ID == id && x.IsEnabled == "1"))
                        return new WebResponseContent().Error("部件已经产生数据,无法删除");
                }

                return new WebResponseContent().OK();
            };
            return base.Del(keys, delList);
        }
    }
}
