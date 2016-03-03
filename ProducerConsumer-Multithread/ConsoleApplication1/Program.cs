using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProducerConsumer;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockingCollectionSampleService s = new BlockingCollectionSampleService();
            s.RunBlockingCollectionCodeSample();
            Console.ReadLine();
        }
    }
}
