/*
*所有关于Equipment类的业务代码接口应在此处编写
*/
using VOL.Core.BaseProvider;
using VOL.Entity.DomainModels;
using VOL.Core.Utilities;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace VOL.Business.IServices
{
    public partial interface IEquipmentService
    {
        public List<Equipment> GetEquipmentByStation(string StationName);
    }
 }
