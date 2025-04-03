using System;

class Task1
{
    public void Solve()
    {
        Console.WriteLine("Задача 1: Сравнение суммы квадратов и квадрата суммы.");
        Console.WriteLine("Введите два числа:");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());

        double sumOfSquares = a * a + b * b;
        double squareOfSum = Math.Pow(a + b, 2);

        if (sumOfSquares > squareOfSum)
            Console.WriteLine("Сумма квадратов больше.");
        else
            Console.WriteLine("Квадрат суммы больше.");
    }
}