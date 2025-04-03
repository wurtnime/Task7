using System;

class Task25
{
    public void Solve()
    {
        Console.WriteLine("Задача 25: Определение участка с меньшим током.");
        Console.WriteLine("Введите сопротивления и напряжения для двух участков цепи:");
        double R1 = Convert.ToDouble(Console.ReadLine());
        double U1 = Convert.ToDouble(Console.ReadLine());
        double R2 = Convert.ToDouble(Console.ReadLine());
        double U2 = Convert.ToDouble(Console.ReadLine());

        double I1 = U1 / R1;
        double I2 = U2 / R2;

        if (I1 < I2)
            Console.WriteLine("Меньший ток на первом участке.");
        else
            Console.WriteLine("Меньший ток на втором участке.");
    }
}