int Exponent(int value_1, int value_2)
{
    int result = 1;
    for (int i = 1; i <= value_2; i++)
    {
        result = result * value_1;
    }
    return result;
}
Console.Write("Введите число A: ");
int value_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int value_2 = Convert.ToInt32(Console.ReadLine());
int exp = Exponent(value_1, value_2);
Console.WriteLine("Число А в степени В = " + exp);