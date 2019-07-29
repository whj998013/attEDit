namespace CheckDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TBSMSINFO")]
    public partial class TBSMSINFO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int REFERENCE { get; set; }

        [Required]
        [StringLength(16)]
        public string SMSID { get; set; }

        public int SMSINDEX { get; set; }

        public int? SMSTYPE { get; set; }

        [Column(TypeName = "ntext")]
        public string SMSCONTENT { get; set; }

        [StringLength(32)]
        public string SMSSTARTTM { get; set; }

        public int? SMSTMLENG { get; set; }

        [StringLength(20)]
        public string GENTM { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] upsize_ts { get; set; }
    }
}
