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
    [Entity(TableCnName = "维修记录",TableName = "EquipmentRepair")]
    public partial class EquipmentRepair:BaseEntity
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
       ///设备编号
       /// </summary>
       [Display(Name ="设备编号")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string EquipmentNo { get; set; }

       /// <summary>
       ///故障代码
       /// </summary>
       [Display(Name ="故障代码")]
       [MaxLength(20)]
       [Column(TypeName="varchar(20)")]
       [Editable(true)]
       public string AlarmCode { get; set; }

       /// <summary>
       ///故障描述
       /// </summary>
       [Display(Name ="故障描述")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string AlarmDescription { get; set; }

       /// <summary>
       ///录入人员
       /// </summary>
       [Display(Name ="录入人员")]
       [MaxLength(20)]
       [Column(TypeName="varchar(20)")]
       [Editable(true)]
       public string CreateOperator { get; set; }

       /// <summary>
       ///录入时间
       /// </summary>
       [Display(Name ="录入时间")]
       [Column(TypeName="datetime")]
       public DateTime? CreateTime { get; set; }

       /// <summary>
       ///维修人员
       /// </summary>
       [Display(Name ="维修人员")]
       [MaxLength(20)]
       [Column(TypeName="varchar(20)")]
       [Editable(true)]
       public string RepairOperator { get; set; }

       /// <summary>
       ///维修时间
       /// </summary>
       [Display(Name ="维修时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? RepairTime { get; set; }

       /// <summary>
       ///维修描述
       /// </summary>
       [Display(Name ="维修描述")]
       [MaxLength(200)]
       [Column(TypeName="varchar(200)")]
       [Editable(true)]
       public string RepairDescription { get; set; }

       
    }
}