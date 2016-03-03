using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    public class BlockingCollectionSampleService
    {
        public void RunBlockingCollectionCodeSample()
        {
            Console.WriteLine("Tasks started...");

            DateTime start = DateTime.Now;
            

            WorkQueue workQueue = new WorkQueue(new ConcurrentQueue<WorkTask>());
            WorkItemProducer producerOne = new WorkItemProducer(workQueue);

            
            Task producerTaskOne = Task.Run(() => producerOne.ProduceWorkItems());
            

            Task[] taskConsumerArray = new Task[5];
            for(int i =0; i < taskConsumerArray.Length; i++)
            {
                taskConsumerArray[i] = Task.Run(() => workQueue.MonitorWorkQueue());
            }
            Task.WaitAll(producerTaskOne);
            workQueue.AllItemsAdded();
            Console.WriteLine("added all");
            Task.WaitAll(taskConsumerArray);
            Console.WriteLine("Tasks are finished...");
            Console.WriteLine(string.Format("Finished in {0} seconds", (DateTime.Now - start).TotalSeconds));

        }
    }
}
