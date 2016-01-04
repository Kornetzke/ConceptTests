using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataValidation.Constraints
{
    public class EqualToConstraint
    {
        public EqualToConstraint(object obj)
        {
            obj1 = obj;
        }
        public object obj1 { get; }
        public object obj2 { get; set; }

        public bool Compare()
        {
            return obj1.Equals(obj2);
        }
    }
}
