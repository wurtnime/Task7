using System;

class Task16
{
    public void Solve()
    {
        Console.WriteLine("Задача 16: Проверка, лежит ли точка внутри тора.");
        Console.WriteLine("Введите координаты точки A (x, y):");
        double x = Convert.ToDouble(Console.ReadLine());
        double y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите радиусы r и R:");
        double r = Convert.ToDouble(Console.ReadLine());
        double R = Convert.ToDouble(Console.ReadLine());

        double distance = Math.Sqrt(x * x + y * y);

        if (distance > r && distance < R)
            Console.WriteLine("Точка внутри тора.");
        else
            Console.WriteLine("Точка вне тора.");
    }
}