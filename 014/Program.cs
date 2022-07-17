// SС клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a
// числу b, если нет, вывести остаток от деления a на b.
System.Console.WriteLine("Введите положительное число a");
int a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите положительное число b");
int b=Convert.ToInt32(Console.ReadLine());
if (a%b==0)
{
    System.Console.WriteLine("Число а кратно b");
}
else
{
    int c=a%b;
    System.Console.WriteLine(c);
}