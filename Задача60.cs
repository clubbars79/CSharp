Console.WriteLine("Введите размер массива X x Y x Z:");
Console.Write("Введите Х : ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите Y : ");
int y = int.Parse(Console.ReadLine());
Console.Write("Введите Z : ");
int z = int.Parse(Console.ReadLine());
int[,,] arrayXYZ = new int[x, y, z];
void CreateArray(int[,,] arrayXYZ)
{
    int[] size = new int[arrayXYZ.GetLength(0) * arrayXYZ.GetLength(1) * arrayXYZ.GetLength(2)];
    int number = 0;
    for (int i = 0; i < size.GetLength(0); i++)
    {
        size[i] = new Random().Next(10, 100);
        number = size[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (size[i] == size[j])
                {
                    size[i] = new Random().Next(10, 100);
                    j = 0;
                    number = size[i];
                }
                number = size[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < arrayXYZ.GetLength(0); x++)
    {
        for (int y = 0; y < arrayXYZ.GetLength(1); y++)
        {
            for (int z = 0; z < arrayXYZ.GetLength(2); z++)
            {
                arrayXYZ[x, y, z] = size[count];
                count++;
            }
        }
    }
}
void PrintArray(int[,,] arrayXYZ)
{
    for (int i = 0; i < arrayXYZ.GetLength(0); i++)
    {
        for (int j = 0; j < arrayXYZ.GetLength(1); j++)
        {
            Console.Write("(" + i + "," + j + ",)");
            for (int k = 0; k < arrayXYZ.GetLength(2); k++)
            {
                Console.Write("(по Z " + k + ") = " +arrayXYZ[i, j, k] + "; ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
CreateArray(arrayXYZ);
PrintArray(arrayXYZ);