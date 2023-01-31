Console.Write("Введите размер одномерного массива : ");
int a = int.Parse(Console.ReadLine());
int i = 0;
int x = 0;
int s = 0;
int[] array = new int[a];
Random rand = new Random();
for (x = 0; x < a; x++)
{
    array[x] = rand.Next(100, 999);
}

void PrintArry(int[] array)
{
    Console.Write("[");
    for (x = 0; x < a; x++)
    {
        Console.Write(array[x]);
        if (x < a)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}
PrintArry(array);
int SumEven(int i)
{
    int result = 0;
    for (x = 0; x < a; x++)
        if (array[x] % 2 == 0)
        {
            result = result + 1;
        }
    return result;
}
int sum = SumEven(i);
Console.WriteLine(" Количество четных чисел в массиве: " + sum);
