// /NET
//значимые типы (value types)
int a;
double  b;
a=4;
//ссылочные типы (reference types)
string  s;
s="Hello";
string s1;
s1=s;//копирует
int[] arr;
arr=new int[5];
//переменные храняться в стеке (очередь)
arr[0]=1;
int[] arr2;
arr2=arr;//массив ссылается на тот же массив, при изменении нвого старый тоже еняется
arr2[0]=2;

System.Console.WriteLine();