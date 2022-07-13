// С клавиатуры вводятся три числа. Найти максимальное из трех чисел
int a;
int b;
int c;
int valMax;
string? s=Console.ReadLine(); 
string? t=Console.ReadLine();
string? o=Console.ReadLine();

a=Convert.ToInt32(s);
b=Convert.ToInt32(t);
c=Convert.ToInt32(o);
valMax=a;

if (b>valMax)
{
    valMax=b;
}
else
{
    if (c>valMax)
    valMax=c;
}
Console.WriteLine("Максимальное " + valMax);