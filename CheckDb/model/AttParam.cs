namespace CheckDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AttParam")]
    public partial class AttParam
    {
        [Key]
        [StringLength(20)]
        public string PARANAME { get; set; }

        [StringLength(2)]
        public string PARATYPE { get; set; }

        [Required]
        [StringLength(100)]
        public string PARAVALUE { get; set; }
    }
}
