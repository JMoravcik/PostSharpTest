using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostsharpTest.Aspects
{
    /// <summary>
    /// Every class where is implemented this interface and simultaneously every class what is derived from base class 
    /// which is implementing this interface will receive on every method aspect for logging
    /// </summary>
    [Writer(AttributeInheritance = PostSharp.Extensibility.MulticastInheritance.Strict)]
    public interface ILogging
    {

    }
}
