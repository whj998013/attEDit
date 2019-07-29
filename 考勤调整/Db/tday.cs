namespace ¿¼ÇÚµ÷Õû.Db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tday")]
    public partial class tday
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int no { get; set; }

        public DateTime? t0 { get; set; }

        public DateTime? t1 { get; set; }

        public DateTime? t2 { get; set; }
    }
}
