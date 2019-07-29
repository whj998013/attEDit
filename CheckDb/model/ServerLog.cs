namespace CheckDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServerLog")]
    public partial class ServerLog
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string EVENT { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int USERID { get; set; }

        [StringLength(30)]
        public string EnrollNumber { get; set; }

        public short? parameter { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime EVENTTIME { get; set; }

        [StringLength(5)]
        public string SENSORID { get; set; }

        [StringLength(20)]
        public string OPERATOR { get; set; }
    }
}
