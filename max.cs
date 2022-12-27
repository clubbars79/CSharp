int a;
int b;
int max;
Console.WriteLine ("Введите число:");
a = int.Parse (Console.ReadLine ());
Console.WriteLine ("Введите 2-е число:");
b = int.Parse (Console.ReadLine ());
if (a>b)
{
max = a;
}
else 
{
max = b;
}
Console.WriteLine ("Наибольшее число: " + max);
