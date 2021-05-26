using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PostsharpTest.Aspects
{
    public static class Logger
    {
        private static void Log(string message)
        {
            Console.WriteLine($"{DateTime.Now} {message}");
        }

        public static void LogInfo(MethodInfo methodInfo, string state)
        {
            Console.ForegroundColor = ConsoleColor.White;
            if (methodInfo == null)
            {
                Log($"{state}");
            }
            else
            {
                Log($"{methodInfo?.DeclaringType.Name}.{methodInfo.Name} {state}");
            }
            Console.ResetColor();
        }

        public static void LogError(Exception exception)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Log($"Exception({exception.GetType().Name}): {exception.Message}");
            Log("Stack trace:");
            Log(exception.StackTrace);
            Console.ResetColor();
        }

        internal static void LogSuccess(MethodInfo method, string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            if (method == null)
            {
                Log($"{message}");
            }
            else
            {
                Log($"{method.DeclaringType.Name}.{method.Name} {message}");
            }
            Console.ResetColor();
        }
    }
}
