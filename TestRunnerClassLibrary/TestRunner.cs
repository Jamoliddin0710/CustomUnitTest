using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TestResultMethod.Attributes;

namespace TestRunnerClassLibrary
{
    public static class TestRunner
    {
        public static void StartTesting()
        {

            Console.WriteLine("Test started");
            //GetAssemblies() -- hamma domainlarni yig;ib oladi
            var testclasses = AppDomain.CurrentDomain.GetAssemblies().SelectMany(a => a.GetTypes()
            .Where(t => t.IsClass && t.GetCustomAttribute<TestClassAttribute>() is not null).ToList());
            // SelectMany - bir nechta to'plamni yig'ib ketadi 

            //AppDomain.CurrentDomain.GetAssemblies().ToList().
            //ForEach(test => Console.WriteLine(test.FullName)); -- projectdagi hamma dll file (assemblylarni chiqaradi)
            foreach (var testclass in testclasses)
            {
                var testobj = Activator.CreateInstance(testclass); // typedan object oladi
                var logicServiceTestMethods = testclass.GetMethods();
                logicServiceTestMethods.Where(test => test.GetCustomAttribute<TestMethodAttribute>() is not null).
                    ToList().ForEach(testmethod => Run(testmethod, testobj)); ; // classdan type so'zi qatnashgan methodlarni oladi

            }

            void Run(MethodInfo methodInfo, Object? testobj)
            {
                Console.WriteLine(methodInfo.ReflectedType?.Name + "  " + methodInfo.Name);
                //methodinfosi mos kelaqdigan methodniObject ichidan topib ishlatib beradi  
                var attributes = methodInfo.GetCustomAttributes<TestMethodParametres>().ToList();
                if (attributes.Count > 0)
                {
                    int k = 1;
                    foreach (var attribute in attributes)
                    {
                        Console.Write($"{k++}-test  ");
                        methodInfo.Invoke(testobj, attribute?.Parameters);
                    }
                }
                else
                {
                    methodInfo.Invoke(testobj, null);
                }
            }
            Console.ReadKey();
        }
    }
}
