using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunctionExamples
{
	public class FunctionsWithLambda
	{

		public FunctionsWithLambda(int minValue, int maxValue)
		{
			this.minValue = minValue;
			this.maxValue = maxValue;
		}
		public int minValue { get;}
		public int maxValue { get; }
		public List<int> BuildIntegerList() {
			var list = Enumerable.Range(1, 10).Select(i => i * 3).ToList();
			return list;
		}
		private List<int> BuildIntegerList(int min, int max)
		{
			var list = Enumerable.Range(min, max).Select(i => i * 3).ToList();
			return list;
		}
		public List<int> BuildIntegerListAndSort(int min, int max)
		{
			var list = BuildIntegerList(min, max);
			//var list = Enumerable.Range(min, max).Select(i => i * 3).ToList();
			list.Sort((l, r) => l.ToString().CompareTo(r.ToString()));
			
			return list;
		}

		public List<int> GetRangeofIntegers
		{
			get {
				return BuildIntegerList(minValue,maxValue);
			}
		}
		public List<int> GetRangeOfIntegersAndSort
		{
			get
			{
				return BuildIntegerListAndSort(minValue, maxValue);

			}
		}
		
	}
}
