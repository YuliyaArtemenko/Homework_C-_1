// Найти сумму чисел от 1 до А
System.Console.WriteLine("Введите число A");
int A=Convert.ToInt32(Console.ReadLine());
int i;
int sum=0;
for (i=1; i<=A; i++)
{
   sum=sum+i;
}
 System.Console.WriteLine(sum );