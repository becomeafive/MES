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
    [Entity(TableCnName = "车型螺栓配置",TableName = "CarScrewConfig")]
    public partial class CarScrewConfig:BaseEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="Id")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int Id { get; set; }

       /// <summary>
       ///子车型
       /// </summary>
       [Display(Name ="子车型")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string Type { get; set; }

       /// <summary>
       ///主车型
       /// </summary>
       [Display(Name ="主车型")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string MainType { get; set; }

       /// <summary>
       ///螺栓ID
       /// </summary>
       [Display(Name ="螺栓ID")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string ScrewId { get; set; }

       /// <summary>
       ///扭矩拧紧点
       /// </summary>
       [Display(Name ="扭矩拧紧点")]
       [MaxLength(200)]
       [Column(TypeName="varchar(200)")]
       [Editable(true)]
       public string TighteningPoint { get; set; }

       /// <summary>
       ///目标扭矩
       /// </summary>
       [Display(Name ="目标扭矩")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string TargetTorque { get; set; }

       /// <summary>
       ///扭矩中值
       /// </summary>
       [Display(Name ="扭矩中值")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string MedianTorque { get; set; }

       /// <summary>
       ///目标角度
       /// </summary>
       [Display(Name ="目标角度")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string TargetAngle { get; set; }

       /// <summary>
       ///角度中值
       /// </summary>
       [Display(Name ="角度中值")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string MedianAngle { get; set; }

       /// <summary>
       ///特征值
       /// </summary>
       [Display(Name ="特征值")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string Eigenvalue { get; set; }

       /// <summary>
       ///线体(中文)
       /// </summary>
       [Display(Name ="线体(中文)")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string LineCN { get; set; }

       /// <summary>
       ///线体(英文)
       /// </summary>
       [Display(Name ="线体(英文)")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string LineEN { get; set; }

       /// <summary>
       ///工位
       /// </summary>
       [Display(Name ="工位")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string Station { get; set; }

       /// <summary>
       ///屏蔽长度
       /// </summary>
       [Display(Name ="屏蔽长度")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Length { get; set; }

       /// <summary>
       ///修改人
       /// </summary>
       [Display(Name ="修改人")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       public string Modifier { get; set; }

       /// <summary>
       ///修改日期
       /// </summary>
       [Display(Name ="修改日期")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? ModifyDate { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ModifyID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? ModifyID { get; set; }

       /// <summary>
       ///创建日期
       /// </summary>
       [Display(Name ="创建日期")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="CreateID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? CreateID { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       public string Creator { get; set; }

       /// <summary>
       ///禁用
       /// </summary>
       [Display(Name ="禁用")]
       [Column(TypeName="tinyint")]
       [Editable(true)]
       public byte? Enable { get; set; }

       /// <summary>
       ///禁用说明
       /// </summary>
       [Display(Name ="禁用说明")]
       [MaxLength(200)]
       [Column(TypeName="varchar(200)")]
       [Editable(true)]
       public string Explain { get; set; }

       
    }
}