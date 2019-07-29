namespace CheckDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACGroup")]
    public partial class ACGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short GroupID { get; set; }

        [StringLength(30)]
        public string Name { get; set; }

        public short? TimeZone1 { get; set; }

        public short? TimeZone2 { get; set; }

        public short? TimeZone3 { get; set; }

        public bool? holidayvaild { get; set; }

        public int? verifystyle { get; set; }
    }
}
