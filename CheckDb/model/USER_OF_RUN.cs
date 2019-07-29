namespace CheckDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class USER_OF_RUN
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int USERID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NUM_OF_RUN_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime STARTDATE { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime ENDDATE { get; set; }

        public int? ISNOTOF_RUN { get; set; }

        public int? ORDER_RUN { get; set; }
    }
}
