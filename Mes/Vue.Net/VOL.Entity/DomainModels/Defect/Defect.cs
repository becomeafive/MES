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
    [Entity(TableCnName = "缺陷维护",TableName = "Defect")]
    public partial class Defect:BaseEntity
    {
        /// <summary>
       ///缺陷代码
       /// </summary>
       [Display(Name ="缺陷代码")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string DefectNo { get; set; }

       /// <summary>
       ///缺陷名称
       /// </summary>
       [Display(Name ="缺陷名称")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string DefectName { get; set; }

       /// <summary>
       ///缺陷详情
       /// </summary>
       [Display(Name ="缺陷详情")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string DefectInfo { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="ID")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int ID { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string Creator { get; set; }

       /// <summary>
       ///创建时间
       /// </summary>
       [Display(Name ="创建时间")]
       [Column(TypeName="datetime")]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///是否已有子订单，如果是1，不能删除
       /// </summary>
       [Display(Name ="是否已有子订单，如果是1，不能删除")]
       [MaxLength(10)]
       [Column(TypeName="varchar(10)")]
       public string IsEnabled { get; set; }

       
    }
}