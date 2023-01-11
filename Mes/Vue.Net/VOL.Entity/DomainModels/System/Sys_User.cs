using Newtonsoft.Json;
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
    [Entity(TableCnName = "用户管理",TableName = "Sys_User",ApiInput = typeof(ApiSys_UserInput),ApiOutput = typeof(ApiSys_UserOutput))]
    public partial class Sys_User:BaseEntity
    {
        /// <summary>
       ///帐号
       /// </summary>
       [Display(Name ="帐号")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string UserName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="User_Id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int User_Id { get; set; }

       /// <summary>
       ///性别
       /// </summary>
       [Display(Name ="性别")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Gender { get; set; }

       /// <summary>
       ///头像
       /// </summary>
       [Display(Name ="头像")]
       [MaxLength(200)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(200)")]
       public string HeadImageUrl { get; set; }

       /// <summary>
       ///角色
       /// </summary>
       [Display(Name ="角色")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int Role_Id { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="RoleName")]
       [MaxLength(150)]
       [Column(TypeName="nvarchar(150)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string RoleName { get; set; }

       /// <summary>
       ///Token
       /// </summary>
       [Display(Name ="Token")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string Token { get; set; }

       /// <summary>
       ///真实姓名
       /// </summary>
       [Display(Name ="真实姓名")]
       [MaxLength(20)]
       [Column(TypeName="nvarchar(20)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string UserTrueName { get; set; }

       /// <summary>
       ///密码
       /// </summary>
       [Display(Name ="密码")]
       [MaxLength(200)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(200)")]
       public string UserPwd { get; set; }

       /// <summary>
       ///注册时间
       /// </summary>
       [Display(Name ="注册时间")]
       [Column(TypeName="datetime")]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="CreateID")]
       [Column(TypeName="int")]
       public int? CreateID { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       public string Creator { get; set; }

       /// <summary>
       ///是否可用
       /// </summary>
       [Display(Name ="是否可用")]
       [JsonIgnore]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Enable { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ModifyID")]
       [Column(TypeName="int")]
       public int? ModifyID { get; set; }

       /// <summary>
       ///修改人
       /// </summary>
       [Display(Name ="修改人")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       public string Modifier { get; set; }

       /// <summary>
       ///修改时间
       /// </summary>
       [Display(Name ="修改时间")]
       [JsonIgnore]
       [Column(TypeName="datetime")]
       public DateTime? ModifyDate { get; set; }

       /// <summary>
       ///最后登陆时间
       /// </summary>
       [Display(Name ="最后登陆时间")]
       [Column(TypeName="datetime")]
       public DateTime? LastLoginDate { get; set; }

       /// <summary>
       ///最后密码修改时间
       /// </summary>
       [Display(Name ="最后密码修改时间")]
       [Column(TypeName="datetime")]
       public DateTime? LastModifyPwdDate { get; set; }

       /// <summary>
       ///备注
       /// </summary>
       [Display(Name ="备注")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       public string Remark { get; set; }

       /// <summary>
       ///排序号
       /// </summary>
       [Display(Name ="排序号")]
       [Column(TypeName="int")]
       public int? OrderNo { get; set; }

       /// <summary>
       ///不合格确认
       /// </summary>
       [Display(Name ="不合格确认")]
       [Column(TypeName="tinyint")]
       [Editable(true)]
       public byte? Confirm { get; set; }

       
    }
}
