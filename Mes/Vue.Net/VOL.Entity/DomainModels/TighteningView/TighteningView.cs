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
    [Entity(TableCnName = "拧紧数据",TableName = "TighteningView")]
    public partial class TighteningView:BaseEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Display(Name ="Line_ID")]
       [Column(TypeName="int")]
       public int? Line_ID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="MedianAngle")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string MedianAngle { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="MedianTorque")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string MedianTorque { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="LineEN")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string LineEN { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="LineCN")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string LineCN { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="TighteningPoint")]
       [MaxLength(200)]
       [Column(TypeName="varchar(200)")]
       public string TighteningPoint { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Body_NO")]
       [MaxLength(28)]
       [Column(TypeName="varchar(28)")]
       public string Body_NO { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="RecordID")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int RecordID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="LocalTime")]
       [Column(TypeName="datetime")]
       [Required(AllowEmptyStrings=false)]
       public DateTime LocalTime { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="IpAddress")]
       [MaxLength(20)]
       [Column(TypeName="varchar(20)")]
       public string IpAddress { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Station")]
       [MaxLength(20)]
       [Column(TypeName="varchar(20)")]
       public string Station { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="IIO")]
       [Column(TypeName="int")]
       public int? IIO { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Channel")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Channel { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Program")]
       [Column(TypeName="int")]
       public int? Program { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Operator")]
       [MaxLength(15)]
       [Column(TypeName="varchar(15)")]
       public string Operator { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Cycle")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Cycle { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="TighteningTime")]
       [Column(TypeName="datetime")]
       [Required(AllowEmptyStrings=false)]
       public DateTime TighteningTime { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="TighteningStatus")]
       [MaxLength(3)]
       [Column(TypeName="char(3)")]
       [Required(AllowEmptyStrings=false)]
       public string TighteningStatus { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Angle")]
       [Column(TypeName="real")]
       [Required(AllowEmptyStrings=false)]
       public float Angle { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Torque")]
       [Column(TypeName="real")]
       [Required(AllowEmptyStrings=false)]
       public float Torque { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ScrewID")]
       [MaxLength(28)]
       [Column(TypeName="varchar(28)")]
       [Required(AllowEmptyStrings=false)]
       public string ScrewID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="IDCode")]
       [MaxLength(28)]
       [Column(TypeName="varchar(28)")]
       [Required(AllowEmptyStrings=false)]
       public string IDCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="TargetAngle")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string TargetAngle { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="TargetTorque")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string TargetTorque { get; set; }

       
    }
}