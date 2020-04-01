using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using FunctionExamples;
using DelegatesAndEvents;

namespace TestKataCode
{
	[TestClass]
	public class FunctionTests
	{
		[TestMethod]
		public void InvokeFunction_FunctionInvoked() {
			FirstFunction ff = new FirstFunction(92);
			var calcProcessRet = ff.CalcProcess;
			var calcRet = ff.ReturnCalc;
			WriteLine($"{calcProcessRet} {calcRet}");


		}
		[TestMethod]
		public void FirstFunction_BuildIntegerList()
		{
			FunctionsWithLambda ff = new FunctionsWithLambda(30, 40);
			var randInt = ff.GetRangeofIntegers;
			
		}
	}
}
