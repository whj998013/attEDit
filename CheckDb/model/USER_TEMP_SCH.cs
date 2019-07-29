namespace CheckDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class USER_TEMP_SCH
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int USERID { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime COMETIME { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime LEAVETIME { get; set; }

        public short? TYPE { get; set; }

        public short? FLAG { get; set; }

        public int SCHCLASSID { get; set; }

        public int? OVERTIME { get; set; }
    }
}
