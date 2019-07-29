namespace CheckDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Machines
    {
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string MachineAlias { get; set; }

        public int ConnectType { get; set; }

        [StringLength(20)]
        public string IP { get; set; }

        public int? SerialPort { get; set; }

        public int? Port { get; set; }

        public int? Baudrate { get; set; }

        public int MachineNumber { get; set; }

        public bool IsHost { get; set; }

        public bool Enabled { get; set; }

        [StringLength(12)]
        public string CommPassword { get; set; }

        public short? UILanguage { get; set; }

        public short? DateFormat { get; set; }

        public short? InOutRecordWarn { get; set; }

        public short? Idle { get; set; }

        public short? Voice { get; set; }

        public short? managercount { get; set; }

        public short? usercount { get; set; }

        public short? fingercount { get; set; }

        public short? SecretCount { get; set; }

        [StringLength(20)]
        public string FirmwareVersion { get; set; }

        [StringLength(20)]
        public string ProductType { get; set; }

        public short? LockControl { get; set; }

        public short? Purpose { get; set; }

        public int? ProduceKind { get; set; }

        [StringLength(20)]
        public string sn { get; set; }

        [StringLength(20)]
        public string PhotoStamp { get; set; }

        public int? IsIfChangeConfigServer2 { get; set; }

        [StringLength(1)]
        public string IsAndroid { get; set; }
    }
}
