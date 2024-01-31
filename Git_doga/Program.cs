using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_doga
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Adj meg egy listát, hogy kilépj ebből a funkcióból, adj a listádhoz 0-át!");
			int num = 1;
			while (num != 0)
			{
				num = Convert.ToInt32(Console.ReadLine());
			}
			

			Console.ReadKey();
		}
	}
}
