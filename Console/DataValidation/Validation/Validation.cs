using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataValidation.Constraints;
using System.Linq.Expressions;
using System.Diagnostics;

namespace DataValidation.Validation
{
    public static class Validation 
    {
        private static List<Type> Rules { get; set; } = new List<Type>();


        public static void AddValidationFor<T>()
        {
            Rules.Add(typeof(T));
        }

        public static void AddRuleFor<T>(Expression<Func<T, object>> destination, EqualToConstraint equalToConstraint)
        {
            Debug.WriteLine(destination.Body.);

            //throw new NotImplementedException();
        }
    }
}
