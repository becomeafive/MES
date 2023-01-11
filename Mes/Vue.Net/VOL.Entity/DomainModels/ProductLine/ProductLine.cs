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
    [Entity(TableCnName = "线体管理",TableName = "ProductLine")]
    public partial class ProductLine:BaseEntity
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
       ///线体编号
       /// </summary>
       [Display(Name ="线体编号")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string LineName { get; set; }

       /// <summary>
       ///线体描述
       /// </summary>
       [Display(Name ="线体描述")]
       [MaxLength(200)]
       [Column(TypeName="varchar(200)")]
       [Editable(true)]
       public string LineDecription { get; set; }

       /// <summary>
       ///线体状态
       /// </summary>
       [Display(Name ="线体状态")]
       [MaxLength(20)]
       [Column(TypeName="varchar(20)")]
       [Editable(true)]
       public string LineStatus { get; set; }

       /// <summary>
       ///操作人
       /// </summary>
       [Display(Name ="操作人")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string OperatorName { get; set; }

       /// <summary>
       ///操作时间
       /// </summary>
       [Display(Name ="操作时间")]
       [Column(TypeName="datetime")]
       public DateTime? UpTime { get; set; }

       
    }
}