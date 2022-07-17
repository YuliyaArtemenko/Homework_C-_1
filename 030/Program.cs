// Написать программу вычисления произведения чисел от 1 до N
int CountDigits(int N)
{
    int i;
    int k=1;
    for (i=1; i<=N; i++)
    {
        k=k*i;
    }
    return k;
}
System.Console.WriteLine(CountDigits(5));
