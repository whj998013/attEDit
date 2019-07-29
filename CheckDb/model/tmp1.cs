namespace CheckDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tmp1
    {
        public int id { get; set; }

        [StringLength(30)]
        public string username { get; set; }

        [StringLength(30)]
        public string deptname { get; set; }

        public int? deptid { get; set; }

        public int? userid { get; set; }

        public DateTime? checktime { get; set; }

        [StringLength(5)]
        public string jqh { get; set; }
    }
}
