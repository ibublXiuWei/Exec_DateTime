using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime today=DateTime.Today;

			int dd=today.Day-1;
			int DD = today.Day -dd;
			string value = $"{today:yyyy/MM}/{DD}";
			Console.WriteLine(value);

			//DateTime first =new DateTime(today.Year/today.Month/1);
			////int a = today.Year;
			////Console.WriteLine(a);
			//Console.WriteLine(first);
		}
	}
}
