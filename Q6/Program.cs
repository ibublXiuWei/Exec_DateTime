using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime today = DateTime.Today;
			int number = Convert.ToInt32(today.Day);
			string print = string.Empty;

			if(number>20)
			{
				print = "下旬";
			}
			else if(number>10)
			{
				print="中旬";
			}else 
			{
				print = "上旬";
			}
			Console.WriteLine(print);
		}
	}
}
