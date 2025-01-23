using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
	public class Week
	{
		public static readonly string[] Weekdays = new string[] { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };
		byte week;
		public Week(byte week =127)
		{
			this.week = week;
		}
		public Week(bool[] days)
		{
			CompressWeekDays(days);
		}
		
		public void CompressWeekDays(bool[] days)
		{
			
			for(byte i=0;i<days.Length;i++)
			{
				
				if (days[i]) week |= (byte)(1 << i);
			
			}
		}
		public bool[] ExtractWeecDays()
		{
			bool[] weekDasys = new bool[7];
			for(byte i=0;i<7;i++)
			{
				weekDasys[i] = (week &(byte)(1<<i))!=0;
				
			}
			return weekDasys;
		}
		public bool Contains(DayOfWeek day)
		{
			int i_day = (int)day;
			i_day -= 1;
			if (i_day == -1) i_day = 6;
			return(week &(1<<i_day)) != 6;
		}
		public override string ToString()
		{
			string weekdays = "";

			for(byte i = 0;i<Weekdays.Length;i++)
			{
				
				if (((1 << i) & week) != 0)
					weekdays += $"{Weekdays[i]},";
			}
			return weekdays;
			
		}
		public  string ToFileString()
		{
			
			return week.ToString();

		}
	}
}
