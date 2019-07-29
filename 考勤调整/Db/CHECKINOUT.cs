namespace 考勤调整.Db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHECKINOUT")]
    public partial class CHECKINOUT
    {
        public CHECKINOUT()
        {
            CHECKTYPE = "I";
            VERIFYCODE = 1;
            SENSORID = "1";
            WorkCode = 0;
            sn = "0246361160597";
            UserExtFmt = 0;
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int USERID { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime CHECKTIME { get; set; }

        [StringLength(1)]
        public string CHECKTYPE { get; set; }

        public int? VERIFYCODE { get; set; }

        [StringLength(5)]
        public string SENSORID { get; set; }

        [StringLength(30)]
        public string Memoinfo { get; set; }

        public int? WorkCode { get; set; }

        [StringLength(20)]
        public string sn { get; set; }

        public short? UserExtFmt { get; set; }
    }
}
