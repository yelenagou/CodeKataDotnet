using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionExamplesUI
{
	public static class FunctionExample
	{
		public static Func<int, int> f = (x) => x + 2;
		public static int GetFuncResult(int x) {
			return f(x);
		}
	}
}
