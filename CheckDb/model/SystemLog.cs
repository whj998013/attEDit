namespace CheckDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SystemLog")]
    public partial class SystemLog
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string Operator { get; set; }

        public DateTime? LogTime { get; set; }

        [StringLength(20)]
        public string MachineAlias { get; set; }

        public short? LogTag { get; set; }

        [StringLength(50)]
        public string LogDescr { get; set; }
    }
}
