// По заданному с клавиатуры номеру дня недели вывести его название
int a;
string? s=Console.ReadLine(); 
a=Convert.ToInt32(s);
if(a==1)
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
     
    
    
