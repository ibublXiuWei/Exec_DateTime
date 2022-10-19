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
			if(number<11)
			{
				Console.WriteLine("上旬");
			}
			else if(number>=11 && number<=20)
			{
				Console.WriteLine("中旬");
			}else if(number<=31)
			{
				Console.WriteLine("下旬");
			}
		}
	}
}
