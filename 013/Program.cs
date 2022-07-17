// Удалить вторую цифру целого числа введенного с клавиатуры.

System.Console.WriteLine("Введите положительное число");
int a=Convert.ToInt32(Console.ReadLine());
int b=a/100;
int c=a%10;
int d=b%10;
if(c>0)
{
   System.Console.WriteLine($"{d}{c}");
}
else
{
   System.Console.WriteLine(b);
}






