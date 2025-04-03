using System;

class Task21
{
    public void Solve()
    {
        Console.WriteLine("Задача 21: Проверка, уместится ли круг в квадрате и квадрат в круге.");
        Console.WriteLine("Введите площадь круга и квадрата:");
        double circleArea = Convert.ToDouble(Console.ReadLine());
        double squareArea = Convert.ToDouble(Console.ReadLine());

        double circleRadius = Math.Sqrt(circleArea / Math.PI);
        double squareSide = Math.Sqrt(squareArea);

        if (2 * circleRadius <= squareSide)
            Console.WriteLine("Круг уместится в квадрате.");
        else
            Console.WriteLine("Круг не уместится в квадрате.");

        if (squareSide * Math.Sqrt(2) <= 2 * circleRadius)
            Console.WriteLine("Квадрат уместится в круге.");
        else
            Console.WriteLine("Квадрат не уместится в круге.");
    }
}