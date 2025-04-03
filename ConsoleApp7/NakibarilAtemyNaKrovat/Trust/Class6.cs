using System;

class Task6
{
    public void Solve()
    {
        Console.WriteLine("Задача 6: Определение четверти точки.");
        Console.WriteLine("Введите координаты точки A (x, y):");
        double x = Convert.ToDouble(Console.ReadLine());
        double y = Convert.ToDouble(Console.ReadLine());

        if (x > 0 && y > 0)
            Console.WriteLine("Точка в первой четверти.");
        else if (x < 0 && y > 0)
            Console.WriteLine("Точка во второй четверти.");
        else if (x < 0 && y < 0)
            Console.WriteLine("Точка в третьей четверти.");
        else
            Console.WriteLine("Точка в четвертой четверти.");
    }
}