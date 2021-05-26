using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostsharpTest
{
    public class ClassApplications : ILogging
    {
        public string BasicNotImplementedMethod()
        {
            throw new NotImplementedException();
        }

        public int BasicMethodWithArgumentAndReturn(int argument)
        {
            return argument;
        }

        public IEnumerable<int> EnumerableMethod(int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return i;
            }
        }
    }
}
