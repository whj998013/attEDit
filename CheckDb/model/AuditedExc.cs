namespace CheckDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AuditedExc")]
    public partial class AuditedExc
    {
        [Key]
        public int AEID { get; set; }

        public int? UserId { get; set; }

        public DateTime CheckTime { get; set; }

        public int? NewExcID { get; set; }

        public short? IsLeave { get; set; }

        [StringLength(20)]
        public string UName { get; set; }

        public DateTime UTime { get; set; }
    }
}
