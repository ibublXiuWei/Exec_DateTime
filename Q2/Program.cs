using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime book = DateTime.Today;
			DateTime backbook = book.AddMonths(1);
			Console.WriteLine($"今日借閱日期{book},歸還到期日期：{backbook}");
		}
	}
}
