int a;
int b;
int c;
int max;
Console.WriteLine ("Введите число:");
a = int.Parse (Console.ReadLine ());
Console.WriteLine ("Введите 2-е число:");
b = int.Parse (Console.ReadLine ());
Console.WriteLine ("Введите 3-е число:");
c = int.Parse (Console.ReadLine ());
if (a>b && a>c)
{
max = a;
}
else if (b>c)
{
max = b;
}
else 
{
max = c;
}
Console.WriteLine ("Наибольшее число: " + max);
