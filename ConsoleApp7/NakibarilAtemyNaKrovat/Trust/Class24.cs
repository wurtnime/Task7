using System;

class Task24
{
    public void Solve()
    {
        Console.WriteLine("Задача 24: Проверка, уместится ли круг в треугольнике и треугольник в круге.");
        Console.WriteLine("Введите сторону равностороннего треугольника и радиус круга:");
        double a = Convert.ToDouble(Console.ReadLine());
        double r = Convert.ToDouble(Console.ReadLine());

        double circleRadiusInTriangle = a * Math.Sqrt(3) / 6;
        double circleRadiusAroundTriangle = a * Math.Sqrt(3) / 3;

        if (r <= circleRadiusInTriangle)
            Console.WriteLine("Круг уместится в треугольнике.");
        else
            Console.WriteLine("Круг не уместится в треугольнике.");

        if (r >= circleRadiusAroundTriangle)
            Console.WriteLine("Треугольник уместится в круге.");
        else
            Console.WriteLine("Треугольник не уместится в круге.");
    }
}