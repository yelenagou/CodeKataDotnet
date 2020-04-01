using System;
using System.Collections.Generic;
using System.Text;

namespace CurriedMethod
{
	public class FunctionsProcess
	{
		public static Func<int, int> CurriedAdd(int a) => b => a + b;
	}
}
