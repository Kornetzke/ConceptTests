using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataValidation.Constraints;
namespace DataValidation.Validation
{
    public class Is
    {
        public static EqualToConstraint EqualTo(object obj)
        {
            return new EqualToConstraint(obj);
        }
    }
}
