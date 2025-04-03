using System;

class Task13
{
    public void Solve()
    {
        Console.WriteLine("Задача 13: Расчет суммы ежемесячных выплат по депозиту.");
        Console.WriteLine("Введите сумму вклада и срок договора (в месяцах):");
        double deposit = Convert.ToDouble(Console.ReadLine());
        int term = Convert.ToInt32(Console.ReadLine());

        double rate = term == 6 ? 0.06 : 0.08;
        double monthlyInterest = deposit * rate / 12;

        Console.WriteLine($"Сумма ежемесячных выплат: {monthlyInterest}");
    }
}