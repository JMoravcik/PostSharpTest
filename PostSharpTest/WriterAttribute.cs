using PostSharp.Aspects;
using PostSharp.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PostsharpTest
{


    [PSerializable, AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
    class WriterAttribute : TypeLevelAspect, IAspectProvider
    {
        public IEnumerable<AspectInstance> ProvideAspects(object targetElement)
        {
            var type = targetElement as Type;
            return from method in type.GetMethods()
                   where method.DeclaringType == type && !AlreadyContainsAspect(method) && IsFromILogging(method)
                   select new AspectInstance(method, new LoggingAttribute());
        }

        private bool IsFromILogging(MethodInfo method)
        {
            var ILoggingType = typeof(ILogging);
            var iLoggingMethod = ILoggingType.GetMethods().FirstOrDefault(iLoggingMethod => iLoggingMethod == method);
            return iLoggingMethod == null;

        }

        private bool AlreadyContainsAspect(MethodInfo method)
        {
            foreach (var attr in method.GetCustomAttributes()) if (attr.GetType() == typeof(LoggingAttribute)) return true;
            return false;
        }
    }
}
