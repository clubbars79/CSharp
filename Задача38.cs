Console.Write("Введите размер одномерного массива : ");
int a = int.Parse(Console.ReadLine());
int x = 0;
int max = 0;
int min = 0;
int maxmin = 0;
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
void Max(int[] array)
{
    max = array[0];

    for (x = 0; x < a; x++)
    {
        if (array[x] > max)
        {
            max = array[x];
        }
    }
}
void Min(int[] array)
{
    min = array[0];

    for (x = 0; x < a; x++)
    {
        if (array[x] < min)
        {
            min = array[x];
        }
    }
}
Max(array);
Min(array);
Console.WriteLine(" Разница между максимальным и минимальным элементами массива : ");
Console.Write(maxmin = max - min);