namespace CheckDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TEMPLATE")]
    public partial class TEMPLATE
    {
        public int TEMPLATEID { get; set; }

        public int USERID { get; set; }

        public int FINGERID { get; set; }

        [Column("TEMPLATE", TypeName = "image")]
        public byte[] TEMPLATE1 { get; set; }

        [Column(TypeName = "image")]
        public byte[] TEMPLATE2 { get; set; }

        [Column(TypeName = "image")]
        public byte[] BITMAPPICTURE { get; set; }

        [Column(TypeName = "image")]
        public byte[] BITMAPPICTURE2 { get; set; }

        [Column(TypeName = "image")]
        public byte[] BITMAPPICTURE3 { get; set; }

        [Column(TypeName = "image")]
        public byte[] BITMAPPICTURE4 { get; set; }

        public short? USETYPE { get; set; }

        [Column(TypeName = "image")]
        public byte[] TEMPLATE3 { get; set; }

        [StringLength(3)]
        public string EMACHINENUM { get; set; }

        [Column("TEMPLATE1", TypeName = "image")]
        public byte[] TEMPLATE11 { get; set; }

        public short? Flag { get; set; }

        public short? DivisionFP { get; set; }

        [Column(TypeName = "image")]
        public byte[] TEMPLATE4 { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] upsize_ts { get; set; }
    }
}
