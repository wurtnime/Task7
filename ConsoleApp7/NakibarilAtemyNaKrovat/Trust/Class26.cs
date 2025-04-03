using System;

class Task26
{
    public void Solve()
    {
        Console.WriteLine("Задача 26: Определение планеты с наибольшим ускорением силы тяжести.");
        double G = 6.7e-8; // Гравитационная постоянная
        double mv = 4.86e27; // Масса Венеры
        double rv = 6175 * 1000; // Радиус Венеры
        double ms = 5.68e29; // Масса Сатурна
        double rs = 57750 * 1000; // Радиус Сатурна

        double gv = G * mv / (rv * rv);
        double gs = G * ms / (rs * rs);

        if (gv > gs)
            Console.WriteLine("Венера имеет большее ускорение силы тяжести.");
        else
            Console.WriteLine("Сатурн имеет большее ускорение силы тяжести.");
    }
}