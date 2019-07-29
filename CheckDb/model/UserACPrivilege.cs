namespace CheckDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserACPrivilege")]
    public partial class UserACPrivilege
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DeviceID { get; set; }

        public int? ACGroupID { get; set; }

        public bool? IsUseGroup { get; set; }

        public int? TimeZone1 { get; set; }

        public int? TimeZone2 { get; set; }

        public int? TimeZone3 { get; set; }

        public int? verifystyle { get; set; }
    }
}
