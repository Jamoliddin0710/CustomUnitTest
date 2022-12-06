using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestResultMethod.Attributes;
using UnitTestConsole;

namespace TestResultMethod.TestResultMethodService;
[TestClass]
public class CalCulateTestResultService
{
    private readonly CalCulateService calCulateService;


    public CalCulateTestResultService()
    {
        calCulateService = new CalCulateService();
    }
    [TestMethod]
    [TestMethodParametres(3,4)]
    [TestMethodParametres(3, 2)]
    [TestMethodParametres(3, 5)]
    public void CalculateTestKopaytma(int a , int b)
    {
        if (calCulateService.CalCulate(a, b, Operation.Kopaytirish) == 6)
            Console.WriteLine("true");
        else Console.WriteLine("false");
    }

    
}

