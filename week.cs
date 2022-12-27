Console.WriteLine ("Введите число дня недели:");
int a = int.Parse (Console.ReadLine ());
if (a==6 || a==7)
{
Console.WriteLine ("Выходной");
}
else if (a>7 || a<1)
{
    Console.WriteLine ("В неделе 7 дней");
}
else 
{
        Console.WriteLine ("Работаем(");
}
