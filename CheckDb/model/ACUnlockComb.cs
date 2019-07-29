namespace CheckDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACUnlockComb")]
    public partial class ACUnlockComb
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short UnlockCombID { get; set; }

        [StringLength(30)]
        public string Name { get; set; }

        public short? Group01 { get; set; }

        public short? Group02 { get; set; }

        public short? Group03 { get; set; }

        public short? Group04 { get; set; }

        public short? Group05 { get; set; }
    }
}
