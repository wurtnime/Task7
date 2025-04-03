using System;

class Task17
{
    public void Solve()
    {
        Console.WriteLine("Задача 17: Проверка, лежит ли точка в четвертой четверти.");
        Console.WriteLine("Введите координаты точки A (x, y):");
        double x = Convert.ToDouble(Console.ReadLine());
        double y = Convert.ToDouble(Console.ReadLine());

        if (x > 0 && y < 0)
            Console.WriteLine("Точка в четвертой четверти.");
        else
            Console.WriteLine("Точка не в четвертой четверти.");
    }
}