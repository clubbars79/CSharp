Console.Write("Введите размер одномерного массива : ");
int a = int.Parse(Console.ReadLine());
int i = 0;
int x = 0;
int[] array = new int[a];
Random rand = new Random();
for (x = 0; x < a; x++)
{
    array[x] = rand.Next(-100, 100);
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
    for (x = 1; x < a;)
    {
        result = result + array[x];
        x = x + 2;
    }
    return result;
}
int sum = SumEven(i);
Console.WriteLine(" Сумма элементов массива на четных позициях: " + sum);