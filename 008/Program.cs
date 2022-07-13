// Вывести на экран числа от -N до N
int i=0;
int a;
string? s=Console.ReadLine(); 
a=Convert.ToInt32(s);
int b=-a;

for (i=b; i<=a; i++)
{
     System.Console.Write($"{i} ");
   
}