// Удалить вторую цифру целого числа введенного с клавиатуры.

/*System.Console.WriteLine("Введите положительное число");
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
*/
int n=Convert.ToInt32(Console.ReadLine());
int d0=n%10;
int d1=n/10%10;
int d2=n/100;
int n1=d2*10+d0;
System.Console.WriteLine($"{d0}{d1}{d2}");
System.Console.WriteLine($"{n1}");






