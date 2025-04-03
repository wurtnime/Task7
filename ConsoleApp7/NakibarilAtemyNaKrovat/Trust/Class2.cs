using System;

class Task2
{
    public void Solve()
    {
        Console.WriteLine("Задача 2: Расчет надбавки к зарплате за стаж.");
        Console.WriteLine("Введите зарплату и стаж:");
        double salary = Convert.ToDouble(Console.ReadLine());
        int experience = Convert.ToInt32(Console.ReadLine());

        double bonus = 0;
        if (experience >= 2 && experience < 5)
            bonus = salary * 0.02;
        else if (experience >= 5 && experience < 10)
            bonus = salary * 0.05;

        Console.WriteLine($"Надбавка: {bonus}, Сумма к выплате: {salary + bonus}");
    }
}