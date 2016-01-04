using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReader
{
    public class Resultset
    {
        public int offset { get; set; }
        public int count { get; set; }
        public int limit { get; set; }
    }

    public class Metadata
    {
        public Resultset resultset { get; set; }
    }

    public class Result
    {
        public string uid { get; set; }
        public string mindate { get; set; }
        public string maxdate { get; set; }
        public string name { get; set; }
        public double datacoverage { get; set; }
        public string id { get; set; }
    }

    public class RootObject
    {
        public Metadata metadata { get; set; }
        public List<Result> results { get; set; }
    }
}
