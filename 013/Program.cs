// Удалить вторую цифру целого числа введенного с клавиатуры.

/*System.Console.WriteLine("Введите положительное число");
int a=Convert.ToInt32(Console.ReadLine());
int b=a/100;
int c=a%10;
int d=b%10;
if(c>0)
{
   System.Console.WriteLine($"{d}{c}");
}
else
{
   System.Console.WriteLine(b);
}
*/
/*
int n=Convert.ToInt32(Console.ReadLine());
int d0=n%10;
int d1=n/10%10;
int d2=n/100;
int n1=d2*10+d0;
System.Console.WriteLine($"{d0}{d1}{d2}");
System.Console.WriteLine($"{n1}");
*/
//Вариант 2 - Удаление с начала

int n=Convert.ToInt32(Console.ReadLine());
int k=CountDigits(n);
int n2=n%(int)Math.Pow(10,k-2);//берем в типы int вместо double
int n3=n/(int)Math.Pow(10,k-1);
int nn=n3*(int)Math.Pow(10,k-2)+n2;
//System.Console.WriteLine($"{n3}{n2}");
System.Console.WriteLine(nn);
//12346%1000=346
//12346/10000=1000+346
int CountDigits(int N)
{
    if (N==0) return 1;
    int k=0;
    while(N!=0)
    {
        k++;
        N=N/10;
    }
    return k;
}







