namespace 考勤调整
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using 考勤调整.Db;

    public partial class StAtt : DbContext
    {
        //: base("name=StAtt")
        public StAtt(string con) : base("name=" + con)
        {
        }

        public virtual DbSet<CHECKINOUT> CHECKINOUT { get; set; }
        public virtual DbSet<DEPARTMENTS> DEPARTMENTS { get; set; }
        public virtual DbSet<HOLIDAYS> HOLIDAYS { get; set; }
        public virtual DbSet<USERINFO> USERINFO { get; set; }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<USERINFO>()
                .Property(e => e.PASSWORD)
                .IsUnicode(false);

            modelBuilder.Entity<USERINFO>()
                .Property(e => e.upsize_ts)
                .IsFixedLength();

            modelBuilder.Entity<USERINFO>()
                .Property(e => e.IDCardNo)
                .IsUnicode(false);

            modelBuilder.Entity<USERINFO>()
                .Property(e => e.IDCardValidTime)
                .IsUnicode(false);
        }
    }
}
