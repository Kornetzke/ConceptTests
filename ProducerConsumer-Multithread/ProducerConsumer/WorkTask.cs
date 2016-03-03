using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    public class WorkTask
    {
        public string Description { get; internal set; }
        public DateTime InsertedUtc { get; internal set; }
        public int Number { get; internal set; }

        public WorkTask(string description, DateTime inserted)
        {
            Description = description;
            InsertedUtc = inserted;
            Random random = new Random();
            Number = random.Next(0, 10000);
        }
    }
}
