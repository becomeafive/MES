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
    [Entity(TableCnName = "设备台账",TableName = "Equipment")]
    public partial class Equipment:BaseEntity
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
       ///设备名称
       /// </summary>
       [Display(Name ="设备名称")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string EquipmentName { get; set; }

       /// <summary>
       ///产线名称
       /// </summary>
       [Display(Name ="产线名称")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? LineID { get; set; }

       /// <summary>
       ///工位名称
       /// </summary>
       [Display(Name ="工位名称")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? StationID { get; set; }

       /// <summary>
       ///最后一次维修时间
       /// </summary>
       [Display(Name ="最后一次维修时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? LastUpTime { get; set; }

       /// <summary>
       ///最后一次维修人员
       /// </summary>
       [Display(Name ="最后一次维修人员")]
       [MaxLength(20)]
       [Column(TypeName="varchar(20)")]
       [Editable(true)]
       public string LastUpOperator { get; set; }

       
    }
}