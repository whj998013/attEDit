namespace CheckDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReportItem")]
    public partial class ReportItem
    {
        [Key]
        public int RIID { get; set; }

        public int? RIIndex { get; set; }

        public short? ShowIt { get; set; }

        [StringLength(12)]
        public string RIName { get; set; }

        [StringLength(6)]
        public string UnitName { get; set; }

        [Column(TypeName = "image")]
        public byte[] Formula { get; set; }

        public short? CalcBySchClass { get; set; }

        public short? StatisticMethod { get; set; }

        public short? CalcLast { get; set; }

        [Column(TypeName = "image")]
        public byte[] Notes { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] upsize_ts { get; set; }
    }
}
