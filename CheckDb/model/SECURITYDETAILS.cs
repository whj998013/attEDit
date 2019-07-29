namespace CheckDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SECURITYDETAILS
    {
        [Key]
        public int SECURITYDETAILID { get; set; }

        public int? USERID { get; set; }

        public short? DEPTID { get; set; }

        public short? SCHEDULE { get; set; }

        public short? USERINFO { get; set; }

        public short? ENROLLFINGERS { get; set; }

        public short? REPORTVIEW { get; set; }

        [StringLength(10)]
        public string REPORT { get; set; }

        public bool ReadOnly { get; set; }

        public bool FullControl { get; set; }
    }
}
