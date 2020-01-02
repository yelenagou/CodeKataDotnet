using Microsoft.VisualStudio.TestTools.UnitTesting;
using HandlingNulls;
using System;

namespace TestKataCode
{
    [TestClass]
    public class ValidateNullValues
    {
        [TestMethod]
        public void StringNulls_AllNullsHandled()
        {
            var returnedValue = CheckStringsFowNulls.ChecIsNullOrEmpty("");
            Console.Out.WriteLine($"this is returned value {returnedValue}");
        }
    }
}
