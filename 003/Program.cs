//С клавиатуры вводятся два числа a и b. Найти максимальное из них.
int a;
int b;
string? s=Console.ReadLine(); 
string? t=Console.ReadLine();

a=Convert.ToInt32(s);
b=Convert.ToInt32(t);
if (a>b)
{
    Console.WriteLine("Максимальное " + a);
}
else
{
Console.WriteLine("Максимальное " + b);
}