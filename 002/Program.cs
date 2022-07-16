//С клавиатуры вводятся два вещественных числа.
//Проверять является ли одно из них квадратом второго.
/*
if (2*2==4)//полное условие
{
  //true
}
else
{
   //false
}
if (2*2==4)//неполное условие
{
  //true
}
==, !=.>,<,>=,<=
*/

int a,b;
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
s=Console.ReadLine();
b=Convert.ToInt32(s);
if(a*a==b)
{
   Console.WriteLine("b явялется квадратом a");
}
else
{
    if (b*b==a)
    {
    Console.WriteLine("a явялется квадратом b");
    }
    else
    {
     Console.WriteLine("Числа не являются квадратами друг друга");
    }
}
