// Написать программу вычисления значения функции y = sin(a). (Класс Math)
/*double a;
double b;
string? s=Console.ReadLine(); 
a=Convert.ToDouble(s);
b=Math.Sin(a);
Console.WriteLine(b);
*/
// или вот так
//double x,y;
//x=3,14;
//y=Math.Sin(x);
// Console.WriteLine($"sin({x})={y}");

//тип возвращаемого знаяения Имя функции(аргументы функции)
double Sin(double x) //методы-функция
{
    return Math.Sin(x);
}

double Sum(double a, double b);
{
    return a + b;
}

double Sum(int a, int b);
{
    return a+b;
}

void Pause()//метод
{
    return;
    System.Console.WriteLine("Press any key");
}

double y =Sin(3.14);
Console.WriteLine(y);
Pause();
