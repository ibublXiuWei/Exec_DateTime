using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime CD=DateTime.Today;
			DateTime backCD=CD.AddDays(3);
			Console.WriteLine($"今日租借日期{CD},三日歸還日期：{backCD}");
		}
	}
}
