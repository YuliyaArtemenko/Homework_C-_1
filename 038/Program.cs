// 038 В одномерном массиве из 123 чисел 
//найти количество элементов из отрезка [10,99]
int N=123;
int[] a=new int[N];
Random random=new Random();
for(int i=0; i<a.Length; i++)
    a[i]=random.Next(0,124);


//вывод массива (до обработки)
for (int i=0;i<a.Length; i++)
System.Console.Write($"{a[i],4}  ");

//решение задачи
int count=0;
for (int i=10;i<100; i++)
     count=count+1;   
System.Console.WriteLine(count);