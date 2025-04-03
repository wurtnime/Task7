using System;

class Task11
{
    public void Solve()
    {
        Console.WriteLine("Задача 11: Проверка числа на четность или окончание на 3.");
        Console.WriteLine("Введите натуральное число:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0 || number % 10 == 3)
            Console.WriteLine("Число четное или оканчивается на 3.");
        else
            Console.WriteLine("Число не четное и не оканчивается на 3.");
    }
}