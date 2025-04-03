using System;

class Task23
{
    public void Solve()
    {
        Console.WriteLine("Задача 23: Сравнение скоростей.");
        Console.WriteLine("Введите скорость в км/ч и м/с:");
        double kmPerH = Convert.ToDouble(Console.ReadLine());
        double mPerS = Convert.ToDouble(Console.ReadLine());

        double kmPerHToMPerS = kmPerH * 1000 / 3600;

        if (kmPerHToMPerS > mPerS)
            Console.WriteLine("Скорость в км/ч больше.");
        else
            Console.WriteLine("Скорость в м/с больше.");
    }
}