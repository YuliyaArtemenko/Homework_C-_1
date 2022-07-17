// Возведите число А в натуральную степень B используя цикл
System.Console.WriteLine("Введите число A");
int A=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число B");
int B=Convert.ToInt32(Console.ReadLine());

while (A>0)
{
    double c=Math.Pow(A,B);
    System.Console.WriteLine(c);
    break;
}
