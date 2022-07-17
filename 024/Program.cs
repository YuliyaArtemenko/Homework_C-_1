// Показать таблицу квадратов чисел от 1 до N
System.Console.WriteLine("Введите число N");
int N=Convert.ToInt32(Console.ReadLine());
int i;
for (i=1; i<=N; i++)
{
    double s=Math.Pow(i,2);
    System.Console.Write($"{s} ");
}
