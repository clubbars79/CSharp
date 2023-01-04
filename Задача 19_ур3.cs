int end2 = 0;
int first2 = 0;
int end = 0;
int first = 0;
Console.WriteLine("Введите пятизначное число:");
int a = int.Parse(Console.ReadLine());
if (a < 9999 || a > 99999)
{
    Console.WriteLine("Вы ввели не пятизначное число");
}
else
{
    end = a % 10;
    first = a / 10000;
    if (end == first)
    {
        end2 = a % 100/10;
        first2 = a / 1000%10;
        if (end2 == first2)
        {
            Console.WriteLine("Число " + a + " является палиндромом");
        }
        else
        {
            Console.WriteLine("Число " + a + " не является палиндромом");
        }
    }
    else
    {
        Console.WriteLine("Число " + a + " не является палиндромом");
    }
}