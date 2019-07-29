namespace CheckDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AlarmLog")]
    public partial class AlarmLog
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string Operator { get; set; }

        [StringLength(30)]
        public string EnrollNumber { get; set; }

        public DateTime? LogTime { get; set; }

        [StringLength(20)]
        public string MachineAlias { get; set; }

        public int? AlarmType { get; set; }
    }
}
