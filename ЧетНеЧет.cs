int a;
Console.WriteLine ("Введите число:");
a = int.Parse (Console.ReadLine ());

Console.WriteLine(a % 2 == 0 ? "Четное" : "Не четное");