using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestResultMethod.Attributes
{
    [AttributeUsage(AttributeTargets.Method , AllowMultiple = true)]
    //Methodga parametr berish
    public class TestMethodParametres : Attribute
    {
        public object[]? Parameters { get; set; }
        public TestMethodParametres(params object[] parameters)
        {
            Parameters = parameters;
        }
    }
}
