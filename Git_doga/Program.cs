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
			Console.WriteLine("Adj meg egy számokból álló listát, hogy kilépj ebből a funkcióból, adj a listádhoz 0-át!");
			
			int num = 1;

			Reszletek r = new Reszletek();

			

			while (num != 0)
			{
				num = Convert.ToInt32(Console.ReadLine());
				if(num != 0) 
				{
					r.Lista_feltoltes(num);
				}
				Console.WriteLine("A{"+r.Lista_kiiratas()+"}\n");
			}

			Console.WriteLine("\nMinimum:"+r.Minimum());


			Console.ReadKey();//Commit all
		}
	}
}
