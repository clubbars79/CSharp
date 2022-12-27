Console.WriteLine ("Введите число:");
int a = int.Parse (Console.ReadLine ());
int GetLastNum (int a)
{
    while (a>999)
    {
        a = a / 10;
    }
return a = a % 10;
}
if (a<99)
{
Console.WriteLine ("У данного числа  не трех цифр");
}
else 
{
        Console.WriteLine ($"Последняя цивра числа:  {a} - {GetLastNum(a)}");
}