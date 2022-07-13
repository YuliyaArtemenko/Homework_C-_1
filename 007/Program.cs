// Выяснить является ли число чётным.
int a;
string? s=Console.ReadLine(); 
a=Convert.ToInt32(s);
if (a%2==0)
{
    Console.WriteLine("Число чётное");
}
else
{
    Console.WriteLine("Число нечетное");
}