// Показать кубы чисел, заканчивающихся на четную цифру
System.Console.WriteLine("Введите число");
int w=Convert.ToInt32(Console.ReadLine());


if (w<10)
{
    if (w%2==0)

 System.Console.WriteLine(w);
}
else 
{
    int b=w%10;
    if (b%2==0)
    {
        System.Console.WriteLine(w);
    }
    
}

