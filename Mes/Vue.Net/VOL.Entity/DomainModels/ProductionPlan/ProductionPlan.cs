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
    [Entity(TableCnName = "生产计划",TableName = "ProductionPlan")]
    public partial class ProductionPlan:BaseEntity
    {
        /// <summary>
       ///计划号
       /// </summary>
       [Display(Name ="计划号")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string PlanNo { get; set; }

       /// <summary>
       ///批次号
       /// </summary>
       [Display(Name ="批次号")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string PlanSN { get; set; }

       /// <summary>
       ///产品编号
       /// </summary>
       [Display(Name ="产品编号")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string ProductNo { get; set; }

       /// <summary>
       ///产品型号
       /// </summary>
       [Display(Name ="产品型号")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string ProductType { get; set; }

       /// <summary>
       ///配方编号
       /// </summary>
       [Display(Name ="配方编号")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string FormulaCode { get; set; }

       /// <summary>
       ///状态
       /// </summary>
       [Display(Name ="状态")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string Status { get; set; }

       /// <summary>
       ///计划生产数量
       /// </summary>
       [Display(Name ="计划生产数量")]
       [Column(TypeName="int")]
       public int? PlanQty { get; set; }

       /// <summary>
       ///计划上时间
       /// </summary>
       [Display(Name ="计划上时间")]
       [Column(TypeName="datetime")]
       public DateTime? PlanStartTime { get; set; }

       /// <summary>
       ///计划下线时间
       /// </summary>
       [Display(Name ="计划下线时间")]
       [Column(TypeName="datetime")]
       public DateTime? PlanEndTime { get; set; }

       /// <summary>
       ///计划创建日期
       /// </summary>
       [Display(Name ="计划创建日期")]
       [Column(TypeName="datetime")]
       public DateTime? PlanCreateTime { get; set; }

       /// <summary>
       ///1
       /// </summary>
       [Key]
       [Display(Name ="1")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int ID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Spare3")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string Spare3 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Spare2")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string Spare2 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Spare1")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string Spare1 { get; set; }

       /// <summary>
       ///数据来源
       /// </summary>
       [Display(Name ="数据来源")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string OrderSoure { get; set; }

       /// <summary>
       ///计划当前工位
       /// </summary>
       [Display(Name ="计划当前工位")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string PlanStion { get; set; }

       /// <summary>
       ///计划当前线体
       /// </summary>
       [Display(Name ="计划当前线体")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string LineName { get; set; }

       /// <summary>
       ///流水号
       /// </summary>
       [Display(Name ="流水号")]
       [Column(TypeName="int")]
       public int? Seq { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Spare4")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string Spare4 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Spare5")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string Spare5 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ModifyID")]
       [Column(TypeName="int")]
       public int? ModifyID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Modifier")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string Modifier { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ModifyDate")]
       [Column(TypeName="datetime")]
       public DateTime? ModifyDate { get; set; }

       
    }
}