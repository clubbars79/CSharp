Console.Write("Введите количество строк 1-го массива : ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов 1-го массива и строк 2-го массива: ");
int columnsrows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов 1-го массива и строк 2-го массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] firstArray = new int[rows, columnsrows];
int[,] secondArray = new int[columnsrows, columns];
int[,] resultArray = new int[columnsrows, columns];
void CreateArray(int[,] array, int minValue = 0, int maxValue = 20)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(minValue, maxValue + 1);
        }
    }
}
void PrintArray(int[,] firstArray)
{
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < firstArray.GetLength(1); j++)
        {
            Console.Write(firstArray[i, j]);
            if (i < firstArray.GetLength(0))
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }
}

void ArrayResult(int[,] resultArray)
{
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstArray.GetLength(1); k++)
            {
                sum += firstArray[i, k] * secondArray[k, j];
            }
            resultArray[i, j] = sum;
            Console.Write(resultArray[i, j]);
            if (i < resultArray.GetLength(0))
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }
}

CreateArray(firstArray);
Console.WriteLine("Первый массив:");
PrintArray(firstArray);

CreateArray(secondArray);
Console.WriteLine("Второй массив:");
PrintArray(secondArray);


Console.WriteLine("Произведение первого и второго массива: ");
ArrayResult(resultArray);

