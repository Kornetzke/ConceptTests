using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    public class WorkItemProducer
    {
        private WorkQueue workQueue;
        public WorkItemProducer(WorkQueue workQueue)
        {
            this.workQueue = workQueue;
        }

        public void ProduceWorkItems()
        {
            //while (true)
            //{
            for(int i =0;  i <= 1000000; i++)
            {
                Guid jobID = Guid.NewGuid();
                WorkTask wt = new WorkTask(string.Concat("Work with job ID ", jobID), DateTime.UtcNow);
               // Debug.WriteLine(string.Format("Thread {0} added work {1} at {2} to the work queue.",Thread.CurrentThread.ManagedThreadId, wt.Description, wt.InsertedUtc));
                workQueue.AddTask(wt);
                //Thread.Sleep(500);
            }
            
            //}
        }
    }
}
