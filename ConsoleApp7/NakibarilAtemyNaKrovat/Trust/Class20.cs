using System;

class Task20
{
    public void Solve()
    {
        Console.WriteLine("Задача 20: Сравнение объемных скоростей.");
        Console.WriteLine("Введите объемные скорости перетекания жидкости (л/с и м³/мин):");
        double lPerS = Convert.ToDouble(Console.ReadLine());
        double m3PerMin = Convert.ToDouble(Console.ReadLine());

        double m3PerS = m3PerMin / 60;

        if (lPerS > m3PerS)
            Console.WriteLine("1 л/с больше.");
        else
            Console.WriteLine("10^-3 м³/мин больше.");
    }
}