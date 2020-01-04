namespace CheckDb
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class attContent : DbContext
    {
        public attContent(string con)
            : base("name=" + con)
        {
        }
        public string ConName { get; set; }
        public virtual DbSet<ACGroup> ACGroup { get; set; }
        public virtual DbSet<acholiday> acholiday { get; set; }
        public virtual DbSet<ACTimeZones> ACTimeZones { get; set; }
        public virtual DbSet<ACUnlockComb> ACUnlockComb { get; set; }
        public virtual DbSet<AlarmLog> AlarmLog { get; set; }
        public virtual DbSet<AttParam> AttParam { get; set; }
        public virtual DbSet<AuditedExc> AuditedExc { get; set; }
        public virtual DbSet<AUTHDEVICE> AUTHDEVICE { get; set; }
        public virtual DbSet<CHECKINOUT> CHECKINOUT { get; set; }
        public virtual DbSet<DEPARTMENTS_OLD> DEPARTMENTS_OLD { get; set; }
        public virtual DbSet<dtproperties> dtproperties { get; set; }
        public virtual DbSet<FaceTemp> FaceTemp { get; set; }
        public virtual DbSet<HOLIDAYS2> HOLIDAYS2 { get; set; }
        public virtual DbSet<LeaveClass> LeaveClass { get; set; }
        public virtual DbSet<LeaveClass1> LeaveClass1 { get; set; }
        public virtual DbSet<Machines> Machines { get; set; }
        public virtual DbSet<NUM_RUN> NUM_RUN { get; set; }
        public virtual DbSet<NUM_RUN_DEIL> NUM_RUN_DEIL { get; set; }
        public virtual DbSet<ReportItem> ReportItem { get; set; }
        public virtual DbSet<SchClass> SchClass { get; set; }
        public virtual DbSet<SECURITYDETAILS> SECURITYDETAILS { get; set; }
        public virtual DbSet<SHIFT> SHIFT { get; set; }
        public virtual DbSet<SystemLog> SystemLog { get; set; }
        public virtual DbSet<TBSMSALLOT> TBSMSALLOT { get; set; }
        public virtual DbSet<TBSMSINFO> TBSMSINFO { get; set; }
        public virtual DbSet<tday> tday { get; set; }
        public virtual DbSet<TEMPLATE> TEMPLATE { get; set; }
        public virtual DbSet<tmp1> tmp1 { get; set; }
        public virtual DbSet<USER_OF_RUN> USER_OF_RUN { get; set; }
        public virtual DbSet<USER_SPEDAY> USER_SPEDAY { get; set; }
        public virtual DbSet<USER_TEMP_SCH> USER_TEMP_SCH { get; set; }
        public virtual DbSet<UserACMachines> UserACMachines { get; set; }
        public virtual DbSet<UserACPrivilege> UserACPrivilege { get; set; }
        public virtual DbSet<UserUpdates> UserUpdates { get; set; }
        public virtual DbSet<UserUsedSClasses> UserUsedSClasses { get; set; }
        public virtual DbSet<CHECKEXACT> CHECKEXACT { get; set; }
        public virtual DbSet<DeptUsedSchs_old> DeptUsedSchs_old { get; set; }
        public virtual DbSet<EmOpLog> EmOpLog { get; set; }
        public virtual DbSet<ServerLog> ServerLog { get; set; }
        public virtual DbSet<UsersMachines> UsersMachines { get; set; }
        public virtual DbSet<CIOT> CIOT { get; set; }
        public virtual DbSet<DEPARTMENTS> DEPARTMENTS { get; set; }
        public virtual DbSet<DeptUsedSchs> DeptUsedSchs { get; set; }
        public virtual DbSet<HOLIDAYS> HOLIDAYS { get; set; }
        public virtual DbSet<USERINFO> USERINFO { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<dtproperties>()
                .Property(e => e.property)
                .IsUnicode(false);

            modelBuilder.Entity<dtproperties>()
                .Property(e => e.value)
                .IsUnicode(false);

            modelBuilder.Entity<FaceTemp>()
                .Property(e => e.upsize_ts)
                .IsFixedLength();

            modelBuilder.Entity<LeaveClass>()
                .Property(e => e.upsize_ts)
                .IsFixedLength();

            modelBuilder.Entity<LeaveClass1>()
                .Property(e => e.upsize_ts)
                .IsFixedLength();

            modelBuilder.Entity<Machines>()
                .Property(e => e.IsAndroid)
                .IsUnicode(false);

            modelBuilder.Entity<ReportItem>()
                .Property(e => e.upsize_ts)
                .IsFixedLength();

            modelBuilder.Entity<SchClass>()
                .Property(e => e.upsize_ts)
                .IsFixedLength();

            modelBuilder.Entity<TBSMSINFO>()
                .Property(e => e.SMSSTARTTM)
                .IsUnicode(false);

            modelBuilder.Entity<TBSMSINFO>()
                .Property(e => e.upsize_ts)
                .IsFixedLength();

            modelBuilder.Entity<TEMPLATE>()
                .Property(e => e.upsize_ts)
                .IsFixedLength();

            modelBuilder.Entity<USERINFO>()
                .Property(e => e.PASSWORD)
                .IsUnicode(false);

       

            //modelBuilder.Entity<USERINFO>()
            //    .Property(e => e.IDCardNo)
            //    .IsUnicode(false);

            //modelBuilder.Entity<USERINFO>()
            //    .Property(e => e.IDCardValidTime)
            //    .IsUnicode(false);
        }
    }

   
}
