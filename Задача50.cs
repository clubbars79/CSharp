Console.Write("Введите позицию числа в двухмерном массиве через запятую : ");
int[] position = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
int[,] CreateArry(int line, int columns, int minValue = 0, int maxValue = 10)
{
    int[,] array = new int[line, columns];
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArry(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            if (i < array.GetLength(0))
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }

}
int[,] array = CreateArry(5, 5);
PrintArry(array);
int i = 0;
for (i = 0; i < 2; i++)
{
    if (position[i] > array.GetLength(0) || position[i] < 0)
    {
        Console.WriteLine("Такого числа в массиве нет");
        break;
    }

}
Console.WriteLine("Позиции числа в массиве: [" + position[0] + "," + position[1] + "] число = " + array[position[0], position[1]]);