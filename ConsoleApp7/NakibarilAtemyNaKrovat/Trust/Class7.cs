using System;

class Task7
{
    public void Solve()
    {
        Console.WriteLine("Задача 7: Проверка, лежит ли точка внутри окружности.");
        Console.WriteLine("Введите координаты точки A (x, y):");
        double x = Convert.ToDouble(Console.ReadLine());
        double y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите радиус окружности R:");
        double R = Convert.ToDouble(Console.ReadLine());

        double distance = Math.Sqrt(x * x + y * y);

        if (distance <= R)
            Console.WriteLine("Точка внутри окружности.");
        else
            Console.WriteLine("Точка вне окружности.");
    }
}