using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
	internal class Program
	{//列出指定年份的每一星期日
		static void Main(string[] args)
		{
			Console.Write("請輸入年分");
			string input = Console.ReadLine();
			string years = $"{input}/1/1";
			DateTime dtyears=Convert.ToDateTime(years);
			
			DayOfWeek weekday = dtyears.DayOfWeek;
			int value = (int)weekday;
			
			int plus = 7 - value;
			int DD = dtyears.Day + plus;
			string allsunday = $"{dtyears.Year}/{dtyears.Month}/{DD}";
			DateTime dt=Convert.ToDateTime(allsunday);
			
			for (DateTime AS=dt; AS < dtyears.AddYears(1); AS = AS.AddDays(7))
			{
				
				Console.WriteLine(AS);
			}



		}
	}
}
