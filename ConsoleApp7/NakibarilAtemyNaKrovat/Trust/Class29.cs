using System;

class Task29
{
    public void Solve()
    {
        Console.WriteLine("Задача 29: Определение, какая звезда дальше.");
        double siriusDistance = 8.14e12; // Расстояние до Сириуса в км
        double arcturusDistance = 103 * 3.259 * 9.461e12; // Расстояние до Арктура в км

        if (siriusDistance > arcturusDistance)
            Console.WriteLine("Сириус дальше.");
        else
            Console.WriteLine("Арктур дальше.");
    }
}