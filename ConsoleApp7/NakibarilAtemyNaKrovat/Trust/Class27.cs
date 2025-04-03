using System;

class Task27
{
    public void Solve()
    {
        Console.WriteLine("Задача 27: Определение времени суток.");
        Console.WriteLine("Введите текущее время (часы):");
        int hours = Convert.ToInt32(Console.ReadLine());

        if (hours >= 0 && hours < 12)
            Console.WriteLine("Утро.");
        else
            Console.WriteLine("Вечер.");
    }
}