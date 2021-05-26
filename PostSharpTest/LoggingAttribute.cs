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

    [PSerializable]
    public class LoggingAttribute : OnMethodBoundaryAspect
    {

        public override void OnEntry(MethodExecutionArgs args)
        {
            Logger.LogInfo(args.Method as MethodInfo, $"Begin");
            if (args.Arguments.Count != 0) Logger.LogInfo(null, "Arguments:");
            foreach (var arg in args.Arguments) Logger.LogInfo(null, $"\t{arg.GetType().Name}: {arg}");
        }

        public override void OnException(MethodExecutionArgs args)
        {
            Logger.LogError(args.Exception);
            args.FlowBehavior = FlowBehavior.Return;
        }

        public override void OnSuccess(MethodExecutionArgs args)
        {
            Logger.LogSuccess(args.Method as MethodInfo, "Success");
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            var methodInfo = args.Method as MethodInfo;
            Logger.LogInfo(methodInfo, "Exit");
            if (methodInfo.ReturnType != typeof(void)) Logger.LogInfo(null, $"returns({methodInfo.ReturnType.Name}): {args.ReturnValue}");
        }

        public override void OnYield(MethodExecutionArgs args)
        {
            var methodInfo = args.Method as MethodInfo;
            Logger.LogInfo(methodInfo, "Yield");
            Logger.LogInfo(null, $"yields({methodInfo.ReturnType.GenericTypeArguments[0].Name}): {args.YieldValue}");
        }

        public override void OnResume(MethodExecutionArgs args)
        {
            Logger.LogInfo(args.Method as MethodInfo, "Resume");
        }
    }
}
