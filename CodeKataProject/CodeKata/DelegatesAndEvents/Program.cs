using System;               

namespace DelegatesAndEvents
{
    //public delegate int Wo    rkPerformedHandler(int hours, WorkType workType);
    public delegate int BizRulesDelegate(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            FunctionExamples.FunctionsWithLambda ff = new FunctionExamples.FunctionsWithLambda(30,40);

            var randInt = ff.GetRangeofIntegers;
            var rangeOfIntegersSorted = ff.GetRangeOfIntegersAndSort;

            BizRulesDelegate addDelegate = (x, y) => x + y;
            BizRulesDelegate multiplyDelegate = (x, y) => x * y;

            var data = new ProcessData();
            data.Process(2, 3, addDelegate);

            //WorkPerformedHandler del1 = new WorkPerformedHandler(WorkPerformed1);
            //WorkPerformedHandler del2 = new WorkPerformedHandler(WorkPerformed2);
            //WorkPerformedHandler del3 = new WorkPerformedHandler(WorkPerformed3);
            //the last delegate in the invocation list is the one where the return
            //value will come back
            //del1 += del2 + del3;
            //int finalHours = del1(10, WorkType.ReivewDocumentation);
            var worker = new Worker();
            //worker.WorkPerformed += new EventHandler<WorkPerformedEventArgs>(Worker_WorkPerformed);
            worker.WorkPerformed += Worker_WorkPerformed;
            worker.WorkCompleted += Worker_WorkCompleted;
            worker.DoWork(8, WorkType.GoToMeetings);
            Console.ReadLine();
        }

        

        static void Worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
        {
            Console.WriteLine($"{e.Hours}, {e.WorkType}");

        }
        static void Worker_WorkCompleted(object sender, EventArgs e)
        {
            Console.WriteLine($"Work Completed!");

        }
        //static void Dowork(WorkPerformedHandler del)
        //{
        //    del(5, WorkType.PullRequests);

        //}
        //static int WorkPerformed1(int hours, WorkType workType)
        //{
        //    Console.WriteLine($"WorkPerformed1 called {hours} wktype {workType}");
        //    return hours + 1;
        //}
        //static int WorkPerformed2(int hours, WorkType workType)
        //{
        //    Console.WriteLine($"WorkPerformed2 called {hours} {workType}");
        //    return hours + 2;

        //}
        //static int WorkPerformed3(int hours, WorkType workType)
        //{
        //    Console.WriteLine($"WorkPerformed2 called {hours} {workType}");
        //    return hours + 3;
        //}
    }
    public enum WorkType
    {
        GoToMeetings,
        ReivewDocumentation,
        PullRequests
    }
}
