namespace CheckDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TBSMSALLOT")]
    public partial class TBSMSALLOT
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int REFERENCE { get; set; }

        public int SMSREF { get; set; }

        public int USERREF { get; set; }

        [StringLength(20)]
        public string GENTM { get; set; }
    }
}
