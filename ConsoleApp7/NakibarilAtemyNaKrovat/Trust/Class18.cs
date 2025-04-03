using System;

class Task18
{
    public void Solve()
    {
        Console.WriteLine("Задача 18: Проверка, является ли треугольник равнобедренным.");
        Console.WriteLine("Введите три стороны треугольника:");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        if (a == b || b == c || a == c)
            Console.WriteLine("Треугольник равнобедренный.");
        else
            Console.WriteLine("Треугольник не равнобедренный.");
    }
}