using PostsharpTest.Aspects;
using PostSharpTest;
using System;
using System.Collections.Generic;

namespace PostsharpTest
{
   
    public class MethodApplications
    {
        [Logging]
        public string BasicNotImplementedMethod()
        {
            throw new NotImplementedException();
        }

        [Logging]
        public int BasicMethodWithArgumentAndReturn(int argument)
        {
            return argument;
        }

        [Logging]
        public IEnumerable<int> EnumerableMethod(int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return i;
            }
        }
    }
}
