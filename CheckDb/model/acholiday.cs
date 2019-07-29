namespace CheckDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("acholiday")]
    public partial class acholiday
    {
        [Key]
        public int primaryid { get; set; }

        public int? holidayid { get; set; }

        public DateTime? begindate { get; set; }

        public DateTime? enddate { get; set; }

        public int? timezone { get; set; }
    }
}
