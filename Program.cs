using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using LinqPractise.Extensions;

namespace LinqPractise
{
	public class Program
	{
		public static void Main(string[] args)
		{
            List<int>Tests = new List<int>{1,2,3,4,5,6,7,8,9,10};
            var ans = Tests.EduWhere(x=>x>5);
            foreach(var i in ans){
                Console.WriteLine(i);
            }
		}
	}
}
