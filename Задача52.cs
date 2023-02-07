Console.Write("Введите размер двухмерного массива через запятую : ");
int[] size = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
int line = size[0];
int columns = size[1];
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

double[] AvgArray(int columns, int[,] array)
{
    double[] avg = new double[columns];
    Console.Write("Среднее арифметическое стобцов массива");
    Console.Write("[");
    for (int j = 0; j < array.GetLength(1); j++)
    {

        for (int i = 0; i < array.GetLength(0); i++)
        {
            avg[j] = avg[j] + array[i, j];
        }
        Console.Write(avg[j] / line);
        Console.Write(", ");
    }
    Console.WriteLine("]");
    return avg;
}

int[,] array = CreateArry(line, columns);
PrintArray(array);
double[] avg = AvgArray(columns, array);