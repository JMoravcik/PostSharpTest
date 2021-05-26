
using PostsharpTest;
using PostsharpTest.Extern;
using PostsharpTest.Extern.NextAsm;
using System;

//[assembly: PostsharpTest.Aspects.Writer]
namespace PostSharpTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //MethodImplementationExamples();
            //ClassImplementationExamples();
            //DerivedClassImplementationExamples();
            AssemblyImplementationExamples();
        }

        static void MethodImplementationExamples()
        {
            MethodApplications methodApplications = new MethodApplications();

            methodApplications.BasicMethodWithArgumentAndReturn(1);
            methodApplications.BasicNotImplementedMethod();
            foreach (var index in methodApplications.EnumerableMethod(3))
            {
                Console.WriteLine($"index: {index}");
            }
        }

        static void ClassImplementationExamples()
        {
            ClassApplications classApplications = new ClassApplications();
            classApplications.BasicMethodWithArgumentAndReturn(1);
            classApplications.BasicNotImplementedMethod();
            foreach (var index in classApplications.EnumerableMethod(3))
            {
                Console.WriteLine($"index: {index}");
            }
        }

        static void DerivedClassImplementationExamples()
        {
            DerivedClassApplications derivedClassApplications = new DerivedClassApplications();
            derivedClassApplications.BasicMethodWithArgumentAndReturn(1);
            derivedClassApplications.BasicNotImplementedMethod();
            foreach (var index in derivedClassApplications.EnumerableMethod(3))
            {
                Console.WriteLine($"index: {index}");
            }

            derivedClassApplications.MethodInDerivedClass();
        }

        static void AssemblyImplementationExamples()
        {
            Class1 classApplications = new Class1();
            classApplications.BasicMethodWithArgumentAndReturn(1);
            classApplications.BasicNotImplementedMethod();
            foreach (var index in classApplications.EnumerableMethod(3))
            {
                Console.WriteLine($"index: {index}");
            }

            Class2 classApplications2 = new Class2();
            classApplications2.BasicMethodWithArgumentAndReturn(1);
            classApplications2.BasicNotImplementedMethod();
            foreach (var index in classApplications2.EnumerableMethod(3))
            {
                Console.WriteLine($"index: {index}");
            }

        }
    }
}
