using System;

class Task19
{
    public void Solve()
    {
        Console.WriteLine("Задача 19: Проверка, являются ли числа тройкой Пифагора.");
        Console.WriteLine("Введите три целых числа:");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
            Console.WriteLine("Числа являются тройкой Пифагора.");
        else
            Console.WriteLine("Числа не являются тройкой Пифагора.");
    }
}