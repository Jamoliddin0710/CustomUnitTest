using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestConsole
{
   
    public class CalCulateService
    {
        public CalCulateService()
        {

        }

        public int CalCulate( int a , int b ,Operation operation)
        {
            return operation switch
            {
                Operation.Plus => a + b,
                Operation.Minus => a - b,
                Operation.Bolish => a / b,
                Operation.Kopaytirish => a * b,
                _ => throw new ArgumentOutOfRangeException(nameof(operation), operation, null)
            };
        }
    }
    public enum Operation
    {
        Plus , 
        Minus ,
        Kopaytirish,
        Bolish,
    }
}
