// 
int N=10;
int i=0;
while(i<N)//пока - универсальный цикл
{
    i=i+1;
    System.Console.WriteLine($"{i} ");
}
//for
for (i=0, i<N, i=i+1)
{
    System.Console.WriteLine($"{i} ");
}
//do
int a;
do 
{
   System.Console.WriteLine("Введите положительное число");
   int a=Convert.ToInt32(Console.ReadLine());
}
while(a<=0);