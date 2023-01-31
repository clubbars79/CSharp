Console.Write("Введите размер одномерного массива : ");
int a = int.Parse(Console.ReadLine());
int x = 0;
int i = 0;
int s = 0;
int[] array = new int[a];
if (a%2==0)
{
   i = a/2; 
}
else
{
    i = a/2+1;
}
int[] pnambers = new int[i];
Random rand = new Random();
for (x = 0; x < a; x++)
{
    array[x] = rand.Next(10);
}

void PrintArry(int[] array)
{
    Console.Write("[");
    for (x = 0; x < a; x++)
    {
        Console.Write(array[x]);
        if (x < a)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}
PrintArry(array);
void ProductofNambers(int[] array)
{
    for (x = 0; x < i; x++)
    {
        s = a-x;
       array [x] = array [x] * array [s];
    }
}
ProductofNambers(array);
void PrintProductofNambers(int[] array)
{
    Console.Write("[");
    for (x = 0; x < i; x++)
    {
        Console.Write(array[x]);
        if (x < i)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}
PrintProductofNambers(array);

