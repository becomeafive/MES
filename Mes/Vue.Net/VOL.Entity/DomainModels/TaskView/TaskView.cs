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
    [Entity(TableCnName = "任务预览",TableName = "TaskView")]
    public partial class TaskView:BaseEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="RecordID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int RecordID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="VIN")]
       [MaxLength(20)]
       [Column(TypeName="nvarchar(20)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string VIN { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Type")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Type { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="MainType")]
       [MaxLength(10)]
       [Column(TypeName="nvarchar(10)")]
       [Editable(true)]
       public string MainType { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="DPNumber")]
       [MaxLength(20)]
       [Column(TypeName="varchar(20)")]
       [Editable(true)]
       public string DPNumber { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Deleted")]
       [Column(TypeName="bit")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public bool Deleted { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="OffLines")]
       [Column(TypeName="bit")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public bool OffLines { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="DTime")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public DateTime DTime { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="LocalTime")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public DateTime LocalTime { get; set; }

       
    }
}