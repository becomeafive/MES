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
    [Entity(TableCnName = "拧紧视图",TableName = "TighteningDataView")]
    public partial class TighteningDataView:BaseEntity
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
       [Display(Name ="IDCode")]
       [MaxLength(28)]
       [Column(TypeName="varchar(28)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string IDCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Body_NO")]
       [MaxLength(28)]
       [Column(TypeName="varchar(28)")]
       [Editable(true)]
       public string Body_NO { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ScrewID")]
       [MaxLength(28)]
       [Column(TypeName="varchar(28)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string ScrewID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Torque")]
       [Column(TypeName="real")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public float Torque { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Angle")]
       [Column(TypeName="real")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public float Angle { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="TighteningStatus")]
       [MaxLength(3)]
       [Column(TypeName="char(3)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string TighteningStatus { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="TighteningTime")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public DateTime TighteningTime { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Cycle")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int Cycle { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Operator")]
       [MaxLength(15)]
       [Column(TypeName="varchar(15)")]
       [Editable(true)]
       public string Operator { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Program")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Program { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="IpAddress")]
       [MaxLength(20)]
       [Column(TypeName="varchar(20)")]
       [Editable(true)]
       public string IpAddress { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Station")]
       [MaxLength(20)]
       [Column(TypeName="varchar(20)")]
       [Editable(true)]
       public string Station { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Channel")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Channel { get; set; }

       
    }
}