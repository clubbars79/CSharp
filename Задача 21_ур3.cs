int n = 3;
Console.WriteLine("Введите координаты точки A (x,y,z) через запятую");
int[] pointA = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
Console.WriteLine("Введите координаты точки B (x,y,z) через запятую");
int[] pointB = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
double dist = Math.Sqrt((pointB[0] - pointA[0])*(pointB[0] - pointA[0]) + (pointB[1] - pointA[1])*(pointB[1] - pointA[1]) + (pointB[2] - pointA[2])*(pointB[2] - pointA[2]));
Console.WriteLine(dist);