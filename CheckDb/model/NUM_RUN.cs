namespace CheckDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NUM_RUN
    {
        public int NUM_RUNID { get; set; }

        public int? OLDID { get; set; }

        [Required]
        [StringLength(30)]
        public string NAME { get; set; }

        public DateTime? STARTDATE { get; set; }

        public DateTime? ENDDATE { get; set; }

        public short? CYLE { get; set; }

        public short? UNITS { get; set; }
    }
}
