
using UnitTestConsole;

Console.WriteLine("Hello, World!");
var logic = new LogicService();

// 2ta natijani tekshirish noqulay shuning uchun boshqa projectga olib o'tamiz
if (logic.Sum(1, 2) == 3) Console.WriteLine("true");
else Console.WriteLine("false");