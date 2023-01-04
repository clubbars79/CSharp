bool b;
Console.WriteLine("Введите число N");
int a = int.Parse(Console.ReadLine());
for (int i =1; i <= a; i++)
{
    b = true;
    for (int s = 2; s < i; s++)
    {
        if (i % s == 0)
        {
            b = false;
            break;
        }
    }
    if (b)
    {
        Console.WriteLine(i);
    }
}