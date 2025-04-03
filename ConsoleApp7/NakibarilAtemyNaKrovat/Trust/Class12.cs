using System;

class Task12
{
    public void Solve()
    {
        Console.WriteLine("Задача 12: Проверка, лежит ли точка в первой четверти.");
        Console.WriteLine("Введите координаты точки A (x, y):");
        double x = Convert.ToDouble(Console.ReadLine());
        double y = Convert.ToDouble(Console.ReadLine());

        if (x > 0 && y > 0)
            Console.WriteLine("Точка в первой четверти.");
        else
            Console.WriteLine("Точка не в первой четверти.");
    }
}