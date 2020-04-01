using System;
using System.Collections.Generic;
using System.Linq;

namespace StatementStyle
{
	partial class Program
	{
		public static string GetSign(int val)
		{
			return val > 0 ? "positive" : "negative";
		}
	}
	partial class Program
	{
		static List<int> NthFunctional(List<int> list, int n)
		{
			return list.Where((x, i) => i % n == 0).ToList();
		}
	}
	public partial class Program
	{
		static void PrintIntList(
		  string titleHeader,
		  List<int> list)
		{
			Console.WriteLine(
			  String.Format("{0}",
			  titleHeader));

			foreach (int i in list)
			{
				Console.Write(String.Format("{0}\t", i));
			}

			Console.WriteLine("\n");
		}
	}
	partial class Program
	{
		static void Main(string[] args)
		{
			var sign = GetSign(10);
			Console.WriteLine(sign);

			List<int> listing = new List<int>() { 0, 1, 2, 3, 4, 5,6, 7, 8, 9, 10, 11,12, 13, 14, 15, 16 };
			var list3rd_funct = NthFunctional(listing, 3);
			PrintIntList("Nth Functional", list3rd_funct);

		}
	}
}
