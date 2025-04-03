using System;
using System.Threading.Tasks;

// 11:11 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Практическая работа №7");
        Console.WriteLine("Выберите задачу 1-30:");
        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                new Task1().Solve();
                break;
            case "2":
                new Task2().Solve();
                break;
            case "3":
                new Task3().Solve();
                break;
            case "4":
                new Task4().Solve();
                break;
            case "5":
                new Task5().Solve();
                break;
            case "6":
                new Task6().Solve();
                break;
            case "7":
                new Task7().Solve();
                break;
            case "8":
                new Task8().Solve();
                break;
            case "9":
                new Task9().Solve();
                break;
            case "10":
                new Task10().Solve();
                break;
            case "11":
                new Task11().Solve();
                break;
            case "12":
                new Task12().Solve();
                break;
            case "13":
                new Task13().Solve();
                break;
            case "14":
                new Task14().Solve();
                break;
            case "15":
                new Task15().Solve();
                break;
            case "16":
                new Task16().Solve();
                break;
            case "17":
                new Task17().Solve();
                break;
            case "18":
                new Task18().Solve();
                break;
            case "19":
                new Task19().Solve();
                break;
            case "20":
                new Task20().Solve();
                break;
            case "21":
                new Task21().Solve();
                break;
            case "22":
                new Task22().Solve();
                break;
            case "23":
                new Task23().Solve();
                break;
            case "24":
                new Task24().Solve();
                break;
            case "25":
                new Task25().Solve();
                break;
            case "26":
                new Task26().Solve();
                break;
            case "27":
                new Task27().Solve();
                break;
            case "28":
                new Task28().Solve();
                break;
            case "29":
                new Task29().Solve();
                break;
            case "30":
                new Task30().Solve();
                break;
            default:
                Console.WriteLine("Неверный номер задачи.");
                break;
        }
    }
}