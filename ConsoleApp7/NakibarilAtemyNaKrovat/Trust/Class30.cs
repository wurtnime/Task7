using System;

class Task30
{
    public void Solve()
    {
        Console.WriteLine("Задача 30: Проверка числа на четность или окончание на 7.");
        Console.WriteLine("Введите натуральное число:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0 || number % 10 == 7)
            Console.WriteLine("Число четное или оканчивается на 7.");
        else
            Console.WriteLine("Число не четное и не оканчивается на 7.");
    }
}