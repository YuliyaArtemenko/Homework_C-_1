// С клавиатуры вводится целое число. Вывести третью цифру числа или
//сообщить, что её нет.
System.Console.WriteLine("Введите положительное число");
int a=Convert.ToInt32(Console.ReadLine());
int b=a%100;
if(b<10)
{
    System.Console.WriteLine(b);
}
else
{
if(b>9)
{
   int d=b%10;
   System.Console.WriteLine(d);
}
else
{
    if(b<100)
    {
      int c=b%10;
      System.Console.WriteLine(c);
    }
}
}
