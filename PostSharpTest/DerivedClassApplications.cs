using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostsharpTest
{
    public class DerivedClassApplications : ClassApplications
    {
        public void MethodInDerivedClass()
        {
            PrivateMethodCalledFromDerivedClass();
        }

        private void PrivateMethodCalledFromDerivedClass()
        {
            Console.WriteLine("I was called");
        }
    }
}
