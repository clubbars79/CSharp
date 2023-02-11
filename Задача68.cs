Console.Write("Введите число N : ");
uint n = uint.Parse(Console.ReadLine());
Console.Write("Введите число M : ");
uint m = uint.Parse(Console.ReadLine());
Console.Write("A(" + n + "," + m + ")");
uint s = 0;
A(n,m);            
            uint A(uint n, uint m)
            {
                if (n == 0) return s = m+1;
                if (n != 0 && m == 0) return A(n - 1, 1);
                if (n > 0 && m > 0) return A(n - 1, A(n, m - 1));
                return A(n,m);
            }
Console.Write(s);

 