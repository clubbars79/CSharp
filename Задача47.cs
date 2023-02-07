Console.Write("Введите количество строк массива : ");
int line = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива : ");
int columns = int.Parse(Console.ReadLine());

double[,] CreateArray(int line, int columns)
{
    double[,] array = new double[line, columns];
    Random rand = new Random();
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.NextDouble() * 20 - 10; // магию ни кто не запрещал
        }
    }
    return array;
}

void PrintArray(double[,] array)
{

    for (int i = 0; i < line; i++)
    {
        Console.Write("[");
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j]); //Conaole.Write("{array[i,j]:f3}") - не помогла, все вчто в "" выводит text. Пусть будут такие, в условие не сказано, какие!
            if (i < line)
            {
                Console.Write(" "); // Пусть не будут запятых!!!, - опять магию использовал, сорри
            }
        }
        Console.WriteLine("]");
    }

}
double[,] array = CreateArray(line, columns);
PrintArray(array);
