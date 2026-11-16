using System;

class Program
{
    static void Main()
    {
        long n = Convert.ToInt64(Console.ReadLine());
        long m = Convert.ToInt64(Console.ReadLine());
        long t = Convert.ToInt64(Console.ReadLine());

        long total = n * 60 + m + t;
        long hours = (total / 60) % 24;
        long minutes = total % 60;

        Console.Write($"{hours:D2}:{minutes:D2}"); // Красивый вывод с ведущими нулями
    }
}