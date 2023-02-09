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
int SumRowsElement(int[,] array, int i)
{
    int sumRows = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumRows += array[i, j];
    }
    return sumRows;
}
int[,] array = CreateArray(rows, columns);
int minSumRows = 0;
int sumRows = SumRowsElement(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int resultSumRows = SumRowsElement(array, i);
    if (sumRows > resultSumRows)
    {
        sumRows = resultSumRows;
        minSumRows = i;
    }
}
PrintArray(array);
Console.WriteLine(minSumRows + 1 + "-я строкa с наименьшей суммой элементов ");