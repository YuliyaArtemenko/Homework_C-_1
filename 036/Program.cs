﻿// 036 Определить, присутствует ли в заданном массиве, некоторое число

int N=12;//инициализация массива
int[] a=new int[N];
Random random=new Random();
for(int i=0; i<a.Length; i++)
    a[i]=random.Next(-9,10);

//решение задачи
int f=400;
//a[3]=f;

//вывод массива (до обработки)
for (int i=0;i<a.Length; i++)
System.Console.Write($"{a[i],4}  ");

//Линейный поиск
int j=0;
while(j<a.Length && a[j]!=f) j++;
if (j==a.Length) System.Console.WriteLine("Not found");
else System.Console.WriteLine($"\nElement {f} founded at {j}");//\n new line
//вывод результатов

