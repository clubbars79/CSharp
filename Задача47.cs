Console.Write("Введите количество строк массива : ");
int line = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива : ");
int columns = int.Parse(Console.ReadLine());

double[,] CreateArry(int line, int columns)
{
    double[,] array = new double[line, columns];
    Random rand = new Random();
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.NextDouble() * 20 - 10;
        }
    }
    return array;
}

void PrintArry(double[,] array)
{

    for (int i = 0; i < line; i++)
    {
        Console.Write("[");
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] - array[i, j] % 0.01);
            if (i < line)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }

}
double[,] array = CreateArry(line, columns);
PrintArry(array);
