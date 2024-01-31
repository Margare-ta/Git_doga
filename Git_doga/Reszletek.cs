using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_doga
{
	internal class Reszletek
	{
		private List<int> nums = new List<int>();

		

		public void Lista_feltoltes(int num)
		{
			nums.Add(num);
		}

		public string Lista_kiiratas()
		{
			string s="";
			for(int i=0; i<nums.Count; i++)
			{
				s += nums[i];
				s += "; ";
			}
			return s;	
		}
	}
}
