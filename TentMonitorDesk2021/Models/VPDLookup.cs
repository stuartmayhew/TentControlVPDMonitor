using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TentMonitorDesk2021.Models
{
    public class VPDLookup
    {
        [Key]
        public int pKey { get; set; }
        public int RH { get; set; }
        public int Temp { get; set; }
        public decimal VPD { get; set; }
        public int Stage { get; set; } //1 veg 2 flower
    }
}