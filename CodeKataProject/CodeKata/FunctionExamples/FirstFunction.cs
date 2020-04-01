using System;
using static System.Console;
using static System.Math;

namespace FunctionExamples
{
	public class FirstFunction
	{
		public FirstFunction(int inputVal) => InputVal = inputVal;
		public int InputVal { get; }
		public int CalcProcess => InputVal * 3;
		public int ReturnCalc
		{
			get { return CalcProcess; }
		}

		public static Func<int, int> triple = x => x * 3;
	
		
	}
}
