using System;

class Task9
{
    public void Solve()
    {
        Console.WriteLine("Задача 9: Сравнение площади квадрата и окружности.");
        Console.WriteLine("Введите сторону квадрата a и радиус окружности R:");
        double a = Convert.ToDouble(Console.ReadLine());
        double R = Convert.ToDouble(Console.ReadLine());

        double squareArea = a * a;
        double circleArea = Math.PI * R * R;

        if (squareArea > circleArea)
            Console.WriteLine("Площадь квадрата больше.");
        else
            Console.WriteLine("Площадь окружности больше.");
    }
}