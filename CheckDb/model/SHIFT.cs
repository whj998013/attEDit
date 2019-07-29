namespace CheckDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SHIFT")]
    public partial class SHIFT
    {
        public int SHIFTID { get; set; }

        [StringLength(20)]
        public string NAME { get; set; }

        public int? USHIFTID { get; set; }

        public DateTime STARTDATE { get; set; }

        public DateTime? ENDDATE { get; set; }

        public short? RUNNUM { get; set; }

        public int? SCH1 { get; set; }

        public int? SCH2 { get; set; }

        public int? SCH3 { get; set; }

        public int? SCH4 { get; set; }

        public int? SCH5 { get; set; }

        public int? SCH6 { get; set; }

        public int? SCH7 { get; set; }

        public int? SCH8 { get; set; }

        public int? SCH9 { get; set; }

        public int? SCH10 { get; set; }

        public int? SCH11 { get; set; }

        public int? SCH12 { get; set; }

        public short? CYCLE { get; set; }

        public short? UNITS { get; set; }
    }
}
