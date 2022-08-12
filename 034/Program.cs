// 034 Задать массив из 12 элементов, заполненных числами из [-9, 9]. 
//Найти сумму положительных/отрицательных элементов массива

int N=12;//инициализация массива
int[] a=new int[N];
Random random=new Random();//если в скобках указать число, то набор случайных числе бует одинаков
for(int i=0; i<a.Length; i++)
    a[i]=random.Next(-9,10);

//вывод массива (до обработки)
for (int i=0;i<a.Length; i++)
System.Console.Write($"{a[i],4}  ");//цифра 4 означает количество пустых пробелом между элементами массива    

//решение задачи
int sumPositive=0;//или sumNegative, если считаем отрицательные
for (int i=0;i<a.Length; i++)
if(a[i]>0)
    sumPositive=sumPositive+a[i];//или += a[i] - увеличить сумму на a[i]


int sumNegative=0;
for (int i=0;i<a.Length; i++)
   if(a[i]<0)
      sumNegative+=a[i];

System.Console.WriteLine(sumPositive);
System.Console.WriteLine(sumNegative);