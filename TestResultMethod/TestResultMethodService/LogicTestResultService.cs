using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestResultMethod.Attributes;
using UnitTestConsole;
// 2-projectga 1ni reference qilib qo'shib qo'yamiz Solution Explorer/Add/Reference
namespace TestResultMethod.TestResultMethodService
{
    [TestClass]
    
    public  class LogicTestResultService
    {
        private  readonly  LogicService _logicService;

        public  LogicTestResultService()
        {
            _logicService = new LogicService();
        }

        [TestMethod]
        [TestMethodParametres(2,5,7)]
        [TestMethodParametres(2, 5, 8)]
        public void SumTest(int a ,int b , int c)
       {
            if (_logicService.Sum(a, b) == c)
                Console.WriteLine("True");
            else Console.WriteLine("False");
       }
        [TestMethod]
        [TestMethodParametres(2,3,4)]
        public void MinusTest(int a , int b , int c)
        {
            if (_logicService.Minus(a, b) == c)
                Console.WriteLine("True");
            else Console.WriteLine("False");
        }


    }
}
