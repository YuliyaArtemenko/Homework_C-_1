// Программа проверяет пятизначное число на палиндромом.
System.Console.WriteLine("Введите пятизначное число");
int w=Convert.ToInt32(Console.ReadLine());
int a=w/10000;
int b=w/1000%10;
int c=w%100/10;
int d=w%10;
//System.Console.WriteLine($"{a} {b} {c} {d}");
if (a==d)
{
    if (b==c)
    {
    System.Console.WriteLine("Число палиндром");
    }
}
else
{
    System.Console.WriteLine("Число не является палиндромом");
}
