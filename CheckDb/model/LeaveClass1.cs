namespace CheckDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LeaveClass1
    {
        [Key]
        public int LeaveId { get; set; }

        [Required]
        [StringLength(20)]
        public string LeaveName { get; set; }

        public double MinUnit { get; set; }

        public short Unit { get; set; }

        public short RemaindProc { get; set; }

        public short RemaindCount { get; set; }

        [Required]
        [StringLength(4)]
        public string ReportSymbol { get; set; }

        public double Deduct { get; set; }

        public short LeaveType { get; set; }

        public int Color { get; set; }

        public short Classify { get; set; }

        [Column(TypeName = "ntext")]
        public string Calc { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] upsize_ts { get; set; }
    }
}
