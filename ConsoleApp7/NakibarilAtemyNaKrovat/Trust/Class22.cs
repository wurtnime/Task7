using System;

class Task22
{
    public void Solve()
    {
        Console.WriteLine("Задача 22: Определение материала с большей плотностью.");
        Console.WriteLine("Введите объем и массу первого тела:");
        double volume1 = Convert.ToDouble(Console.ReadLine());
        double mass1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите объем и массу второго тела:");
        double volume2 = Convert.ToDouble(Console.ReadLine());
        double mass2 = Convert.ToDouble(Console.ReadLine());

        double density1 = mass1 / volume1;
        double density2 = mass2 / volume2;

        if (density1 > density2)
            Console.WriteLine("Первое тело имеет большую плотность.");
        else
            Console.WriteLine("Второе тело имеет большую плотность.");
    }
}