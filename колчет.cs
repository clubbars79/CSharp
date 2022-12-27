int a;
int i;
Console.WriteLine ("Введите число:");
a = int.Parse (Console.ReadLine ());
for (i = 1; i <= a; i++)
if (i % 2 == 0)
{
Console.WriteLine(i);
}