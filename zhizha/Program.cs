//Голубихин Данила 22-ИСП-2/2 Вариант 7
//starter
//Записать лог. выражение, описывающее область определения функции a) y=2tg x b) y=3/(x-1)
Console.WriteLine("a)");
Console.WriteLine("Введите х:");
double x = double.Parse(Console.ReadLine());
double y = 2*Math.Tan(x);
Console.WriteLine("y равен:");
Console.Write(y);
Console.WriteLine();

Console.WriteLine("b)");
Console.WriteLine("Введите х:");
double x1 = double.Parse(Console.ReadLine());
double y1 = 3 / (x1 - 1);
Console.WriteLine("y равен:");
Console.Write(y);

//middle
//Записать лог. выражение, которое является истинным, когда число N четное делится на 7, но не делится на 11 и 13 без остатка.
Console.WriteLine("Введите N:");
int n=int.Parse(Console.ReadLine());
if ((n % 2 == 1) && (n % 7 >= 2) && (n % 13 >= 2)) Console.WriteLine("True");
else Console.WriteLine("False");

