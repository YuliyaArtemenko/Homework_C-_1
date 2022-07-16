// Написать программу вычисления значения функции y = sin(a). (Класс Math)
double a;
double b;
string? s=Console.ReadLine(); 
a=Convert.ToDouble(s);
b=Math.Sin(a);
Console.WriteLine(b);
/*или вот так
double x,y;
x=3,14;
y=Math.Sin(x);
*/ Console.WriteLine($"sin({x})={y}");