
namespace TestResultMethod.Attributes
{
    [AttributeUsage(AttributeTargets.Class,AllowMultiple = false)]
    // AttributeTargets.Class - faqat class uchun
    //AllowMultiple - 1ta classga 1ta qo'yish zarur
    public class TestClassAttribute : Attribute
    {

    }
}
