using System;

class Task28
{
    public void Solve()
    {
        Console.WriteLine("Задача 28: Определение полушария.");
        Console.WriteLine("Введите географическую долготу и широту:");
        double longitude = Convert.ToDouble(Console.ReadLine());
        double latitude = Convert.ToDouble(Console.ReadLine());

        if (longitude >= 0)
            Console.WriteLine("Восточное полушарие.");
        else
            Console.WriteLine("Западное полушарие.");
    }
}