int count = 0;
int x = 0;
Console.WriteLine("Введите количество чисел для записи в массив: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите " + m + " чисел через запятую");
int[] array = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
for (x = 0; x < m; x++)
{
    if (array[x] > 0)
    {
        count = count + 1;
    }
}
Console.WriteLine(count);