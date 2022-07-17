// Подсчитать сумму цифр в числе
System.Console.WriteLine("Введите число");
int w=Convert.ToInt32(Console.ReadLine());
int a=w/10000;
int b=w/1000%10;
int c=w%100/10;
int d=w%10;
int f=w/100%10;
//System.Console.WriteLine($"{a} {b} {c} {d} {f}");
int sum;
sum =a+b+c+d+f;
System.Console.WriteLine(sum);