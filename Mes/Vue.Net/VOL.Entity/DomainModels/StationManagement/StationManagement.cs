/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果数据库字段发生变化，请在代码生器重新生成此Model
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VOL.Entity.SystemModels;

namespace VOL.Entity.DomainModels
{
    [Entity(TableCnName = "工位管理",TableName = "StationManagement")]
    public partial class StationManagement:BaseEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int ID { get; set; }

       /// <summary>
       ///工位编号
       /// </summary>
       [Display(Name ="工位编号")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string StaionName { get; set; }

       /// <summary>
       ///产线名称
       /// </summary>
       [Display(Name ="产线名称")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int LineID { get; set; }

       /// <summary>
       ///工位备注
       /// </summary>
       [Display(Name ="工位备注")]
       [MaxLength(200)]
       [Column(TypeName="varchar(200)")]
       [Editable(true)]
       public string StationRemark { get; set; }

       /// <summary>
       ///工位排序
       /// </summary>
       [Display(Name ="工位排序")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? StationOrder { get; set; }

       /// <summary>
       ///工位IP
       /// </summary>
       [Display(Name ="工位IP")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string IP { get; set; }

       
    }
}