using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
	class Week
	{
		public static readonly string[] Weekdays = new string[] { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };
		byte week;
		public Week(bool[] days)
		{
			CompressWeekDays(days);
		}
		public Week()
		{
			week=0;
		}
		public void SetDay(int day)
		{
			if (day > 6) return;
			week |=(byte)(1<< day) ;
		}
		public void CompressWeekDays(bool[] days)
		{
			for(byte i=0;i<days.Length;i++)
			{
				//byte day = 1;
				//if (days[i]) week &= (byte)(day << i);
				if (days[i]) SetDay(i);
			}
		}
		public override string ToString()
		{
			string weekdays = "";

			for(int i = 0;i<Weekdays.Length;i++)
			{
				
				if (((1 << i) & week) != 0)
					weekdays += Weekdays[i];
			}
			return weekdays;
		}
	}
}
