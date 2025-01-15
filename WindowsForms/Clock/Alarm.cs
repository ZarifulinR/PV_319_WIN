using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
	public class Alarm
	{
		public DateTime Date { get; set; }
		public TimeSpan Time { get; set; }
		public Week Weekdays { get; set; }
		public string Message { get; set; }
		public string Filename { get; set; }
		public Alarm()
		{

			Weekdays = new Week();
		}
		public override string ToString()
		{
			string info = "";
			if (Date != DateTime.MinValue) info += Date;
			//info += Time;
			info += DateTime.Today.Add(Time).ToString("HH:mm:ss");
			info += "\t";
			info += $"{Weekdays}\t";
			info += $"{Filename}\t";
			info += $"{Message}\t";
			return info;
		}
	}
}
