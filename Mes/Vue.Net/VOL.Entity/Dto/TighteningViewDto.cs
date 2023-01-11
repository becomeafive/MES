using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Linq;

namespace VOL.Entity.Dto
{
    public class TighteningViewDto
    {
        public int? Line_ID { get; set; }

        public int Channel { get; set; }

        public int? Program { get; set; }

        public string Operator { get; set; }

        public int Cycle { get; set; }

        public DateTime TighteningTime { get; set; }

        /// <summary>
        ///拧紧状态
        /// </summary>
        public string TighteningStatus { get; set; }

        /// <summary>
        ///角度
        /// </summary>
        public float Angle { get; set; }
      
        /// <summary>
        ///扭矩
        /// </summary>
        public float Torque { get; set; }

        /// <summary>
        ///螺栓ID
        /// </summary>
        public string ScrewID { get; set; }

        /// <summary>
        ///扫描Vin号
        /// </summary>
        public string IDCode { get; set; }

        /// <summary>
        ///工位
        /// </summary>
        [Display(Name = "工位")]
        [MaxLength(20)]
        [Column(TypeName = "varchar(20)")]
        public string Station { get; set; }
        /// <summary>
        ///IP地址
        /// </summary>
        public string IpAddress { get; set; }

        public DateTime LocalTime { get; set; }

     
        public int RecordID { get; set; }

        public string Body_NO { get; set; }

    }
}
