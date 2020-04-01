using System;
using System.Linq;
using System.Text;
using static System.Console;
namespace GenerateList
{
	class Program
	{
		static void Main(string[] args)
		{
			var utilityReturns = Utility.GeneratePlanetStrem();
			byte[] buffer = new byte[utilityReturns.Length];
			utilityReturns.Read(buffer, 0, (int)utilityReturns.Length);
			var readBuffer = Encoding.UTF8.GetString(buffer);
			//Console.WriteLine(readBuffer);
			var readBufferSplit = readBuffer.Split(new[] { Environment.NewLine, }, StringSplitOptions.RemoveEmptyEntries);
			//Console.WriteLine(readBufferSplit.ToList().Count);
			Action<string> actionOne = (string r) => WriteLine(r);
			readBufferSplit.ToList().ForEach(actionOne);
			

			var options = Encoding.UTF8
				.GetString(buffer)
				.Split(new[] { Environment.NewLine, },
					StringSplitOptions.RemoveEmptyEntries)
	  .Select((s, ix) => Tuple.Create(ix, s))
	  .ToDictionary(k => k.Item1, v => v.Item2);
			var orderedList = Utility.GenerateOrderedList(
	   options, "thePlanets", true);

			Console.WriteLine(orderedList);
		}
	}
}
