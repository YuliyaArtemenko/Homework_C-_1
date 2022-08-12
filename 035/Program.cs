// 035 Написать программу замены элементов массива на противоположные
 //инициализация массива
int N = 12;
int[] a = new int[N];
Random random = new Random();
for (int i = 0; i < a.Length; i++)
a[i] = random.Next(-9, 10);

//вывод массива (до обработки)
for (int i = 0; i < a.Length; i++)
System.Console.Write($"{a[i],4}  ");

//решение задачи
int[] b = new int[N];
for (int i = 0; i < a.Length; i++)
  b[i] = a[i]*(-1);
for (int i = 0; i < a.Length; i++)
System.Console.Write($"new{b[i],4} ");
    
