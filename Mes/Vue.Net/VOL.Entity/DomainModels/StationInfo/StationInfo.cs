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
    [Entity(TableCnName = "工艺路线",TableName = "StationInfo")]
    public partial class StationInfo:BaseEntity
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
       ///线体
       /// </summary>
       [Display(Name ="线体")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? LineID { get; set; }

       /// <summary>
       ///工位
       /// </summary>
       [Display(Name ="工位")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? StationID { get; set; }

       /// <summary>
       ///产品
       /// </summary>
       [Display(Name ="产品")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? ProductID { get; set; }

       /// <summary>
       ///排序
       /// </summary>
       [Display(Name ="排序")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? XOrder { get; set; }

       /// <summary>
       ///备注
       /// </summary>
       [Display(Name ="备注")]
       [MaxLength(200)]
       [Column(TypeName="varchar(200)")]
       [Editable(true)]
       public string Remark { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="VersionNumber")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string VersionNumber { get; set; }

       
    }
}