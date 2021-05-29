using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TentMonitorDesk2021.Models
{
    public class TempRHRange
    {
        [Key]
        public decimal Temp { get; set; }
        public decimal LowRH { get; set; }
        public decimal HighRH { get; set; }
        public string GrowStage { get; set; }

    }
}