using System;

class Task14
{
    public void Solve()
    {
        Console.WriteLine("Задача 14: Сравнение разности квадратов и квадрата разности.");
        Console.WriteLine("Введите два числа:");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());

        double differenceOfSquares = a * a - b * b;
        double squareOfDifference = Math.Pow(a - b, 2);

        if (differenceOfSquares > squareOfDifference)
            Console.WriteLine("Разность квадратов больше.");
        else
            Console.WriteLine("Квадрат разности больше.");
    }
}