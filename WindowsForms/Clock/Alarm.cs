using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
	class Alarm
	{
		public DateTime date { get; set; }
		public DateTime Time { get; set; }
		public byte weekdays { get; set; }
		public string message { get; set; }
		public string filename { get; set; }
		public Alarm()
		{


		}
	}
}
