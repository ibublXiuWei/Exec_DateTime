using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime time = DateTime.Now;
			int number = Convert.ToInt32(time.Hour);
			if (number <= 11)
			{
				Console.WriteLine("早安");
			}
			else if (number >= 12 && number <= 18)
			{
				Console.WriteLine("午安");
			}
			else if (number >= 19)
			{
				Console.WriteLine("晚安");
			}
		}
	}
}
