// Дано число обозначающее день недели. Выяснить является номер дня
//недели выходным
System.Console.WriteLine("Введите число дня недели");
int a=Convert.ToInt32(Console.ReadLine());
if (a>5)
{
    System.Console.WriteLine("Выходной день");
}
else{
    System.Console.WriteLine("Будний день");
}