using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TentMonitorDesk2021
{
    public class Settings
	{
		[Key]
		public int pKey { get; set; }
		public decimal maxVPD { get; set; }
		public decimal minVPD { get; set; }
		public decimal optTempDay { get; set; }
		public decimal optRHDay { get; set; }
		public decimal nightStart { get; set; }
		public decimal nightEnd { get; set; }
		public decimal tempRangeFactor { get; set; }
		public decimal RHRangeFactor { get; set; }
		public decimal lightsLPD { get; set; }

		public decimal TempCalFactor { get; set; }
		public decimal RHCalFactor { get; set; }
		public decimal maxNightRH { get; set; }
		public decimal maxNightTemp { get; set; }

		//		public int TryTempTime { get; set; }

	}
}