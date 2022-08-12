// 034 Задать массив из 12 элементов, заполненных числами из [-9, 9]. 
//Найти сумму положительных/отрицательных элементов массива

int N=12;
int[] a=new int[N];
Random random=new Random();//если в скобках указать число, то набор случайных числе бует одинаков
for(int i=0; i<a.Length; i++)
    a[i]=random.Next(-9,10);
    int sumPositive=0;//или sumNegative
for (int i=0;i<a.Length; i++)
if(a[i]>0)
    sumPositive=sumPositive+a[i];//или += a[i]
System.Console.WriteLine(sumPositive);
for (int i=0;i<a.Length; i++)
System.Console.Write($"{a[i],4}");//цифра 4 означает количество пустых пробелом между элементами массива