/*
*所有关于StationInfo类的业务代码接口应在此处编写
*/
using VOL.Core.BaseProvider;
using VOL.Entity.DomainModels;
using VOL.Core.Utilities;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace VOL.Business.IServices
{
    public partial interface IStationInfoService
    {
        public List<ReturnData> GetStationInfos(int ID);
    }
    public class ReturnData
    {
        public string key { get; set; }
        public string value { get; set; }
    }
}
