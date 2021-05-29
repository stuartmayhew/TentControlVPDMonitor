namespace TentMonitorDesk2021
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TentLog")]
    public partial class TentLog
    {
        [Key]
        public int logId { get; set; }

        public DateTime? LogDate { get; set; }

        public decimal? Temp { get; set; }

        public decimal? Humid { get; set; }

        public decimal? VPD { get; set; }

        public bool? AcON { get; set; }

        public bool? HumidON { get; set; }

        public bool? DehumidON { get; set; }

        public bool? LightsOff { get; set; }
        public decimal TargetTemp { get; set; }
        public decimal TargetHumid { get; set; }
    }
}
