// Найти расстояние между точками в пространстве 2D
System.Console.WriteLine("Введите координату x1");
double x1=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите координату x2");
double x2=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите координату y1");
double y1=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите координату y2");
double y2=Convert.ToDouble(Console.ReadLine());
double a=(x2-x1);
double b=(y2-y1);
double a2=Math.Pow(a,2);
double b2=Math.Pow(b,2);
double c=Math.Sqrt(a2+b2);
System.Console.WriteLine("Длина отрезка равна " + c);
