// Определить номер четверти плоскости, в которой находится точка с
//координатами Х и У, причем X ≠ 0 и Y ≠ 0
System.Console.WriteLine("Введите координату x");
int x=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату y");
int y=Convert.ToInt32(Console.ReadLine());
if (x>0)
{
    if (y>0)
    {
      System.Console.WriteLine("Первая четверть");
    }
    else
    {
        System.Console.WriteLine("Четвертая четверть");
    }
}

if (x<0)
{
    if(y<0)
    {
        System.Console.WriteLine("Третья четверть");
    }
    else 
    {
        System.Console.WriteLine("Вторая четверть");
    }
}