using System;
using static System.Console;

namespace FunctionExamplesUI
{
	class Program
	{
		delegate int DoubleAction(int inp);
		static void Main(string[] args)
		{
			DoubleAction da = Double;
		    
			int doubleValue = da(2);

			var funcResult = FunctionExample.f(6);
			WriteLine(funcResult);
		}
		static int Double(int input) {
			return input * 2;
		}
	}
}
