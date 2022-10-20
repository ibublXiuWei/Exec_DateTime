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
			string print=string.Empty;
			if (number >18 )
			{
				print="晚安";
			}
			else if (number >11)
			{
				print = "午安";
			}
			else 
			{
				print = "早安";
			}
			Console.WriteLine(print);
		}
	}
}
