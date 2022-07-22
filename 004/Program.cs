// 4. По заданному с клавиатуры номеру дня недели вывести его название
//массивом
Console.Write("Введите номер недели: ");
string userD=Console.ReadLine();
int d=Convert.ToInt32(userD);
string[] weekDays = new string[] {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
System.Console.WriteLine(weekDays[d-1]);
/*
a=Convert.ToInt32(s);
int a;
string? s=Console.ReadLine(); 
a=Convert.ToInt32(s);
switch(a)
{
    case 1://метка
    System.Console.WriteLine("Monday");
    break;
    case 2:
    System.Console.WriteLine("Tuesday");
    break;
    case 3:
    System.Console.WriteLine("Wednesday");
    break;
    default:
    System.Console.WriteLine("Wrong");
    break;
    

}
*/
//или int dayOfWeek=Convert.ToInt(Console.ReadLine()); camelCase
//int DayOfWeek-PascalCase
/*if(a==1)
{
    Console.WriteLine("Понедельник");
}
    else
    {
    if(a==2)
    {
         Console.WriteLine("Вторник"); 
    }
        else
       {
          if(a==3)
          {
         Console.WriteLine("Среда"); 
          }
           else
           {
            if(a==4)
             {
                Console.WriteLine("Четверг"); 
             }
                else
                {
                 if(a==5)
                  {
                      Console.WriteLine("Пятница"); 
                  }
                    else
                    {
                     if(a==6)
                      {
                          Console.WriteLine("Суббота"); 
                      }
                         else 
                             {
                                Console.WriteLine("Воскресенье");
                             }
                    }
                }
           }
       }
    }
     
*/

    
    
