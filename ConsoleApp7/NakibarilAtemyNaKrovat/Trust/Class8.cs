using System;

class Task8
{
    public void Solve()
    {
        Console.WriteLine("Задача 8: Определение площади треугольника с наибольшей площадью.");
        Console.WriteLine("Введите стороны первого треугольника (a1, b1, c1):");
        double a1 = Convert.ToDouble(Console.ReadLine());
        double b1 = Convert.ToDouble(Console.ReadLine());
        double c1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите стороны второго треугольника (a2, b2, c2):");
        double a2 = Convert.ToDouble(Console.ReadLine());
        double b2 = Convert.ToDouble(Console.ReadLine());
        double c2 = Convert.ToDouble(Console.ReadLine());

        double p1 = (a1 + b1 + c1) / 2;
        double area1 = Math.Sqrt(p1 * (p1 - a1) * (p1 - b1) * (p1 - c1));

        double p2 = (a2 + b2 + c2) / 2;
        double area2 = Math.Sqrt(p2 * (p2 - a2) * (p2 - b2) * (p2 - c2));

        if (area1 > area2)
            Console.WriteLine("Площадь первого треугольника больше.");
        else
            Console.WriteLine("Площадь второго треугольника больше.");
    }
}