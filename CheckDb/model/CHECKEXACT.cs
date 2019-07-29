namespace CheckDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHECKEXACT")]
    public partial class CHECKEXACT
    {
        [Key]
        public int EXACTID { get; set; }

        public int? USERID { get; set; }

        public DateTime? CHECKTIME { get; set; }

        [StringLength(2)]
        public string CHECKTYPE { get; set; }

        public short? ISADD { get; set; }

        [StringLength(25)]
        public string YUYIN { get; set; }

        public short? ISMODIFY { get; set; }

        public short? ISDELETE { get; set; }

        public short? INCOUNT { get; set; }

        public short? ISCOUNT { get; set; }

        [StringLength(20)]
        public string MODIFYBY { get; set; }

        public DateTime? DATE { get; set; }
    }
}
