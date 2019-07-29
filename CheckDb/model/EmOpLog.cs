namespace CheckDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmOpLog")]
    public partial class EmOpLog
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int USERID { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime OperateTime { get; set; }

        public int? manipulationID { get; set; }

        public int? Params1 { get; set; }

        public int? Params2 { get; set; }

        public int? Params3 { get; set; }

        public int? Params4 { get; set; }

        [StringLength(5)]
        public string SensorId { get; set; }
    }
}
