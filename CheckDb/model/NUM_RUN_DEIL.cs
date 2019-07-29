namespace CheckDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NUM_RUN_DEIL
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short NUM_RUNID { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime STARTTIME { get; set; }

        public DateTime? ENDTIME { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short SDAYS { get; set; }

        public short? EDAYS { get; set; }

        public int? SCHCLASSID { get; set; }

        public int? OverTime { get; set; }
    }
}
