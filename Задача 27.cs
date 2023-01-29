Console.Write("Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());
int SumNumber(int numN)
{
    int count = Convert.ToString(numN).Length;
    int s = 0;
    int result = 0;
    for (int i = 0; i < count; i++)
    {
        s = numN - numN % 10;
        result = result + (numN - s);
        numN = numN / 10;
    }
    return result;
}
int sumN = SumNumber(numN);
Console.WriteLine("Сумма цифр в числе: " + numN + " = " + sumN);