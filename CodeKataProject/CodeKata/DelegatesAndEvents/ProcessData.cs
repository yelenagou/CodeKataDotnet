using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesAndEvents
{
    class ProcessData
    {
        public void Process(int x, int y, BizRulesDelegate del)
        {
            var result = del(x, y);
            Console.WriteLine($"this is delegate result: {result}");
        }
        BizRulesDelegate calcThis = (x, y) => x.ToString().CompareTo(y.ToString());
       public void ProcessNew(int x, int y, BizRulesDelegate del) => del(x, y);
            
    }
}
