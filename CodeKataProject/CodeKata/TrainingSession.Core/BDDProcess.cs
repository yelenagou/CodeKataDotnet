using System;
using System.Collections.Generic;

namespace TrainingSession.Core
{
    public class BDDProcess 
    {
        public string ProcessName { get; set; }
        public IEnumerable<ProcessStep> ProcessSteps { get; set; }
        public IEnumerable<ProcessOutput> ProcessOutput { get; set; }
    }
}
