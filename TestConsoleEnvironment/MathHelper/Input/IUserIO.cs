using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHelper.Input
{
    public interface IUserIO
    {
        T GetUserInput<T>();
        void WriteToUser(string message);
    }
}
