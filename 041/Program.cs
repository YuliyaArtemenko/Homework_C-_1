// 41 В Указанном массиве вещественных чисел
//найдите разницу между максимальным и минимальным элементом
//инициализация массива
int N=12;
int[] a=new int[N];
Random random=new Random();
for(int i=0; i<a.Length; i++)
    a[i]=random.Next(0,100);

//вывод массива (до обработки)
for (int i=0;i<a.Length; i++)
System.Console.Write($"{a[i],4}  ");    
int max=0;
int min=100;
int diff=0;
for(int i=0; i<a.Length; i++)
  if  (a[i]>max)
   max=a[i];
System.Console.WriteLine("\nМаксимум " + max);

for(int i=0; i<a.Length; i++)

  if (min>a[i]) 
    min=a[i];
System.Console.WriteLine("Минимум " + min);
diff=max-min;
System.Console.WriteLine("Разница " + diff);
