using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesAndEvents
{
    //Delegate or a pipeline to send data over
    //public delegate int WorkPerformedHandler(object sender, WorkPerformedEventArgs e);
    public class Worker
    {
        //replaces the delegate definition above
        public event EventHandler <WorkPerformedEventArgs>  WorkPerformed;
        //notification that work is done
        public event EventHandler WorkCompleted;
       
       
        
        //As work is being done, we want to know how work is progressing
        //Since we can't get any values while the work is being performed,
        //we can raise an event
        public void DoWork(int hours, WorkType workType)
        {
            for(int i = 0; i < hours; i++)
            {
                OnWorkPerformed(i + 1, workType);
            }
            OnWorkCompleted();
        }
        //Events are raised by calling the event like a method:
        //Check invocation list before calling method.
        protected virtual void OnWorkPerformed(int hours, WorkType workType)
        {
            //if(WorkPerformed != null)
            //{
            //    WorkPerformed(hours, workType);
            //}

            var del = WorkPerformed;
            if(del != null)
            {
                del(this, new WorkPerformedEventArgs(hours, workType));
            }
        }
        protected virtual void OnWorkCompleted()
        {
            var del = WorkCompleted as EventHandler;
            if (del != null)
            {
                del(this, EventArgs.Empty);
            }
        }
    }

}
