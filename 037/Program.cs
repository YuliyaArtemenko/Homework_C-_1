// 37 Задать массив, заполнить случайными положительными трёхзначными числами. 
//Показать количество нечетных\четных чисел

//инициализация массива
int N=12;
int[] a=new int[N];
Random random=new Random();
for(int i=0; i<a.Length; i++)
    a[i]=random.Next(100,1000);
//вывод массива (до обработки)
for (int i=0;i<a.Length; i++)
System.Console.Write($"{a[i],4}  ");
 //решение
int countEven=0;
int countUneven=0;
for (int i=0;i<a.Length; i++)
if (a[i]%2==0)
countEven=countEven+1;
countUneven=12-countEven;
System.Console.WriteLine("\nКоличество четных элементов " + countEven);
System.Console.WriteLine("Количество нечетных элементов " + countUneven);