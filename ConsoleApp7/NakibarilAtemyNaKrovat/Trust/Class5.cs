using System;

class Task5
{
    public void Solve()
    {
        Console.WriteLine("Задача 5: Обработка трех чисел.");
        Console.WriteLine("Введите три числа:");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        a = a > 0 ? a * a : a;
        b = b > 0 ? b * b : b;
        c = c > 0 ? c * c : c;

        Console.WriteLine($"Результат: {a}, {b}, {c}");
    }
}