namespace CheckDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ACTimeZones
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short TimeZoneID { get; set; }

        [StringLength(30)]
        public string Name { get; set; }

        public DateTime? SunStart { get; set; }

        public DateTime? SunEnd { get; set; }

        public DateTime? MonStart { get; set; }

        public DateTime? MonEnd { get; set; }

        public DateTime? TuesStart { get; set; }

        public DateTime? TuesEnd { get; set; }

        public DateTime? WedStart { get; set; }

        public DateTime? WedEnd { get; set; }

        public DateTime? ThursStart { get; set; }

        public DateTime? ThursEnd { get; set; }

        public DateTime? FriStart { get; set; }

        public DateTime? FriEnd { get; set; }

        public DateTime? SatStart { get; set; }

        public DateTime? SatEnd { get; set; }
    }
}
