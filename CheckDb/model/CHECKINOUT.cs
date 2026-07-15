namespace CheckDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHECKINOUT")]
    public partial class CHECKINOUT
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int USERID { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime CHECKTIME { get; set; }

        [StringLength(1)]
        public string CHECKTYPE { get; set; } = "I";

        public int? VERIFYCODE { get; set; } = 1;

        [StringLength(5)]
        public string SENSORID { get; set; } = "2";

        [StringLength(30)]
        public string Memoinfo { get; set; }

        //public int? WorkCode { get; set; }

        [StringLength(20)]
        public string sn { get; set; }

        public short? UserExtFmt { get; set; }

        /// <summary>
        /// 创建当前 CHECKINOUT 实例的浅拷贝。
        /// 返回的新对象字段值与原对象相同，但引用类型字段为相同引用（该类中仅有字符串为引用类型，属于不可变或可安全共享的情况）。
        /// </summary>
        /// <returns>新的 CHECKINOUT 实例</returns>
        public CHECKINOUT Clone()
        {
            return new CHECKINOUT
            {
                USERID = this.USERID,
                CHECKTIME = this.CHECKTIME,
                CHECKTYPE = this.CHECKTYPE,
                VERIFYCODE = this.VERIFYCODE,
                SENSORID = this.SENSORID,
                Memoinfo = this.Memoinfo,
                sn = this.sn,
                UserExtFmt = this.UserExtFmt
            };
        }
    }
}
