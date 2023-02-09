Console.Write("Введите количество строк массива : ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива : ");
int columns = int.Parse(Console.ReadLine());
int[,] CreateArray(int rows, int columns, int minValue = 0, int maxValue = 20)
{
    int[,] array = new int[rows, columns];
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
void PrintArray(int[,] array)
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
void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int sort = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = sort;
                }
            }
        }
    }
}
int[,] array = CreateArray(rows, columns);
PrintArray(array);
Console.WriteLine("Отсортированный массив:");
SortArray(array);
PrintArray(array);