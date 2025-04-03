using System;

class Task15
{
    public void Solve()
    {
        Console.WriteLine("Задача 15: Определение ближайшей точки к началу координат.");
        Console.WriteLine("Введите координаты точки A (x0, y0):");
        double x0 = Convert.ToDouble(Console.ReadLine());
        double y0 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите координаты точки B (x1, y1):");
        double x1 = Convert.ToDouble(Console.ReadLine());
        double y1 = Convert.ToDouble(Console.ReadLine());

        double distanceA = Math.Sqrt(x0 * x0 + y0 * y0);
        double distanceB = Math.Sqrt(x1 * x1 + y1 * y1);

        if (distanceA < distanceB)
            Console.WriteLine("Точка A ближе к началу координат.");
        else
            Console.WriteLine("Точка B ближе к началу координат.");
    }
}