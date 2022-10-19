using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime today = DateTime.Today;
			int MM = today.Month;
			int day_1 = DateTime.DaysInMonth(2022, MM);
			string value = $"{today:yyyy/MM}/{day_1}";
			Console.WriteLine(value);
		}
	}
}
