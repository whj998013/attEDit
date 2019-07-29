namespace CheckDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserUpdates
    {
        [Key]
        public int UpdateId { get; set; }

        [StringLength(20)]
        public string BadgeNumber { get; set; }
    }
}
