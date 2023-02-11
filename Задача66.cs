Console.Write("Введите число M : ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число N : ");
int n = int.Parse(Console.ReadLine());
int sum = 0;
void SumNaturalNumbers(int m, int n)
{
    if (m > n)
    {
        return;
    }
    sum = sum + m;
   
    SumNaturalNumbers(m + 1, n);
}
SumNaturalNumbers(m,n);
 Console.WriteLine("Сумма всех натуральных чисел в промежутке от " + m + " до " + n + " = " + sum);