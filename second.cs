Console.WriteLine ("Введите трехзначное число:");
int a = int.Parse (Console.ReadLine ());
int GetLastNum (int a)
{
return a = (a % 100) / 10;
}
if (a<100)
{
Console.WriteLine ("Данное число меньше трехзначного");
}
else if (a>999)
{
    Console.WriteLine ("Данное число больше трехзначного");
}
else 
{
        Console.WriteLine ($"Последняя цивра числа:  {a} - {GetLastNum(a)}");
}