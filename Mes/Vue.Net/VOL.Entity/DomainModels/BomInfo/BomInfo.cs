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
    [Entity(TableCnName = "Bom清单",TableName = "BomInfo")]
    public partial class BomInfo:BaseEntity
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
       ///产品型号
       /// </summary>
       [Display(Name ="产品型号")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? ProductID { get; set; }

       /// <summary>
       ///物料名称
       /// </summary>
       [Display(Name ="物料名称")]
       [MaxLength(200)]
       [Column(TypeName="varchar(200)")]
       [Editable(true)]
       public string MaterialName { get; set; }

       /// <summary>
       ///物料批次
       /// </summary>
       [Display(Name ="物料批次")]
       [MaxLength(10)]
       [Column(TypeName="nchar(10)")]
       [Editable(true)]
       public string MaterialSN { get; set; }

       /// <summary>
       ///物料描述
       /// </summary>
       [Display(Name ="物料描述")]
       [MaxLength(500)]
       [Column(TypeName="varchar(500)")]
       public string MaterialDescription { get; set; }

       /// <summary>
       ///物料识别码1
       /// </summary>
       [Display(Name ="物料识别码1")]
       [MaxLength(200)]
       [Column(TypeName="varchar(200)")]
       [Editable(true)]
       public string MaterialsNO1 { get; set; }

       /// <summary>
       ///物料识别码2
       /// </summary>
       [Display(Name ="物料识别码2")]
       [MaxLength(10)]
       [Column(TypeName="nchar(10)")]
       [Editable(true)]
       public string MaterialsNO2 { get; set; }

       /// <summary>
       ///物料识别码3
       /// </summary>
       [Display(Name ="物料识别码3")]
       [MaxLength(10)]
       [Column(TypeName="nchar(10)")]
       [Editable(true)]
       public string MaterialsNO3 { get; set; }

       /// <summary>
       ///物料识别码4
       /// </summary>
       [Display(Name ="物料识别码4")]
       [MaxLength(10)]
       [Column(TypeName="nchar(10)")]
       [Editable(true)]
       public string MaterialsNO4 { get; set; }

       /// <summary>
       ///创建日期
       /// </summary>
       [Display(Name ="创建日期")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? CreateTime { get; set; }

       
    }
}