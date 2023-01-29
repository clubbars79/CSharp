Console.Write("Введите ряд чисел, разделенных запятой : ");
int[] A = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
void PrintArry(int[] A)
{
    int count = A.Length;
    int index = 0;
    Console.Write("[");
    while (index < count)
    {
        Console.Write(A[index]);
        index++;
        if (index < count)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}
PrintArry(A);