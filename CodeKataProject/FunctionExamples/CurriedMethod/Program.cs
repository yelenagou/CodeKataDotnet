using System;

namespace CurriedMethod
{
	class Program
	{
		static void Main(string[] args)
		{
			var result = FunctionsProcess.CurriedAdd(6)(3);
			Console.WriteLine(result);
		}
	}
}
