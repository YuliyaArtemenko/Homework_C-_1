
//int a = Convert.ToInt32("Введите число а");
//int b = a **2;
// Console.WriteLien("b");
/*
string s = "Hello"+"asd" конкатенация строк (склеивание)
Console.WriteLine(double.MaxValue); // максимальное значение сохрания
Console.WriteLine("Hello World");
Console.WriteLine(11%3);
System.Console.WriteLine();
*/
//Exs 1
double a;
double b;
string? s=Console.ReadLine();//ввод данных
a=Convert.ToDouble(s);

b = a*a;//обработка данных

//вывод результата
Console.WriteLine("{0}^2={1}", a,b); //строка форматирования либо
Console.WriteLine($"{a}^2={b}"); //строка интерполяции либо

/*
string? s;//объявили переменную
s=Console.ReadLine();//присвоили переменной значение

Console.WriteLine(s);
*/
