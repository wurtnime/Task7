using System;

class Task4
{
    public void Solve()
    {
        Console.WriteLine("Задача 4: Проверка, является ли треугольник прямоугольным.");
        Console.WriteLine("Введите три стороны треугольника:");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
            Console.WriteLine("Треугольник прямоугольный.");
        else
            Console.WriteLine("Треугольник не прямоугольный.");
    }
}