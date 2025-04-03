using System;

class Task10
{
    public void Solve()
    {
        Console.WriteLine("Задача 10: Обработка трех чисел.");
        Console.WriteLine("Введите три числа:");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        a = a > 0 ? Math.Pow(a, 3) : 0;
        b = b > 0 ? Math.Pow(b, 3) : 0;
        c = c > 0 ? Math.Pow(c, 3) : 0;

        Console.WriteLine($"Результат: {a}, {b}, {c}");
    }
}