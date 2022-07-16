// По двум заданным числам проверять является ли одно квадратом
//другого. Используйте подпрограмму

bool Check(int a, int b)
{
    return a*a==b;
}
int a,b;
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
s=Console.ReadLine();
b=Convert.ToInt32(s);
if(Check(a,b))
{
   Console.WriteLine("b явялется квадратом a");
}
else
{
    if (Check(b,a))
    {
    Console.WriteLine("a явялется квадратом b");
    }
    else
    {
     Console.WriteLine("Числа не являются квадратами друг друга");
    }
}