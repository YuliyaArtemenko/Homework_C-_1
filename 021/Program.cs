// Задать номер четверти, показать диапазоны для возможных координат
System.Console.WriteLine("Введите номер четверти");
int v=Convert.ToInt32(Console.ReadLine());
if (v==1)
{
    System.Console.WriteLine("Координаты X [0;+▲], Координата Y [0;+▲]");
}
else
{
 if (v==2)
 {
 System.Console.WriteLine("Координаты X [0;-▲], Координата Y [0;+▲]");
 }
 else 
 {
    if (v==3)
    {
        System.Console.WriteLine("Координаты X [0;-▲], Координата Y [0;-▲]");
    }
    else
        {
        System.Console.WriteLine("Координаты X [0;+▲], Координата Y [0;-▲]");
        }
 }
 
}
