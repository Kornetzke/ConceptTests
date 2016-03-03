using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    public class WorkQueue
    {
        private BlockingCollection<WorkTask> workQueue;

        public WorkQueue(IProducerConsumerCollection<WorkTask> workTaskCollection)
        {
            workQueue = new BlockingCollection<WorkTask>(workTaskCollection);
        }

        public void AddTask(WorkTask task)
        {
            workQueue.Add(task);
        }

        public void AllItemsAdded()
        {
            workQueue.CompleteAdding();
        }

        public void MonitorWorkQueue()
        {
            bool moreTasks = true;
            do
            {
                try
                {
                    WorkTask wt;
                    moreTasks = workQueue.TryTake(out wt);
                    for(int i=0; i<= 10000; i++)
                    {
                        if (!moreTasks || i == wt.Number)
                            break;
                    }
                    //Debug.WriteLine(string.Format("Thread {0} processing work task {1}, Number is {2}", Thread.CurrentThread.ManagedThreadId, wt.Description, wt.Number));
                    //Thread.Sleep(250);
                    
                }
                catch (InvalidOperationException e)
                {
                    Debug.WriteLine(string.Format("Work queue on thread {0} has been closed.", Thread.CurrentThread.ManagedThreadId));
                    break;
                }
            }
            while (moreTasks);
        }
    }
}
