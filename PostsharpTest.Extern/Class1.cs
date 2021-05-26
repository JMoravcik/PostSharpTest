using PostsharpTest.Aspects;
using System;
using System.Collections.Generic;

[assembly: Writer]
namespace PostsharpTest.Extern
{
    public class Class1
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
