using System;
using System.Windows;
using System.Windows.Controls;

// Fmoz

namespace PracticalWork7
{
    public partial class MainWindow : Window
    {
        private int _currentTaskNumber = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SelectTaskButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(TaskNumberInput.Text, out int taskNumber) && taskNumber >= 1 && taskNumber <= 30)
            {
                _currentTaskNumber = taskNumber;
                UpdateInputFields(taskNumber);
            }
            else
            {
                MessageBox.Show("Введите номер задачи от 1 до 30.", "Ошибка");
            }
        }

        private void UpdateInputFields(int taskNumber)
        {
            InputFieldsPanel.Children.Clear(); 

            switch (taskNumber)
            {
                case 1:
                    AddInputField("Введите первое число:");
                    AddInputField("Введите второе число:");
                    break;
                case 2:
                    AddInputField("Введите зарплату:");
                    AddInputField("Введите стаж (в годах):");
                    break;
                case 3:
                    AddInputField("Введите координату X точки A:");
                    AddInputField("Введите координату Y точки A:");
                    AddInputField("Введите координату X точки B:");
                    AddInputField("Введите координату Y точки B:");
                    break;
                case 4:
                    AddInputField("Введите сторону A:");
                    AddInputField("Введите сторону B:");
                    AddInputField("Введите сторону C:");
                    break;
                case 5:
                    AddInputField("Введите первое число:");
                    AddInputField("Введите второе число:");
                    AddInputField("Введите третье число:");
                    break;
                case 6:
                    AddInputField("Введите координату X:");
                    AddInputField("Введите координату Y:");
                    break;
                case 7:
                    AddInputField("Введите координату X:");
                    AddInputField("Введите координату Y:");
                    AddInputField("Введите радиус R:");
                    break;
                case 8:
                    AddInputField("Введите сторону A1:");
                    AddInputField("Введите сторону B1:");
                    AddInputField("Введите сторону C1:");
                    AddInputField("Введите сторону A2:");
                    AddInputField("Введите сторону B2:");
                    AddInputField("Введите сторону C2:");
                    break;
                case 9:
                    AddInputField("Введите сторону квадрата:");
                    AddInputField("Введите радиус окружности:");
                    break;
                case 10:
                    AddInputField("Введите первое число:");
                    AddInputField("Введите второе число:");
                    AddInputField("Введите третье число:");
                    break;
                case 11:
                    AddInputField("Введите число:");
                    break;
                case 12:
                    AddInputField("Введите координату X:");
                    AddInputField("Введите координату Y:");
                    break;
                case 13:
                    AddInputField("Введите сумму вклада:");
                    AddInputField("Введите срок договора (в месяцах):");
                    break;
                case 14:
                    AddInputField("Введите первое число:");
                    AddInputField("Введите второе число:");
                    break;
                case 15:
                    AddInputField("Введите координату X точки A:");
                    AddInputField("Введите координату Y точки A:");
                    AddInputField("Введите координату X точки B:");
                    AddInputField("Введите координату Y точки B:");
                    break;
                case 16:
                    AddInputField("Введите координату X:");
                    AddInputField("Введите координату Y:");
                    AddInputField("Введите радиус r:");
                    AddInputField("Введите радиус R:");
                    break;
                case 17:
                    AddInputField("Введите координату X:");
                    AddInputField("Введите координату Y:");
                    break;
                case 18:
                    AddInputField("Введите сторону A:");
                    AddInputField("Введите сторону B:");
                    AddInputField("Введите сторону C:");
                    break;
                case 19:
                    AddInputField("Введите число A:");
                    AddInputField("Введите число B:");
                    AddInputField("Введите число C:");
                    break;
                case 20:
                    AddInputField("Введите скорость 1 (л/с):");
                    AddInputField("Введите скорость 2 (м³/мин):");
                    break;
                case 21:
                    AddInputField("Введите площадь круга:");
                    AddInputField("Введите площадь квадрата:");
                    break;
                case 22:
                    AddInputField("Введите объем тела 1:");
                    AddInputField("Введите массу тела 1:");
                    AddInputField("Введите объем тела 2:");
                    AddInputField("Введите массу тела 2:");
                    break;
                case 23:
                    AddInputField("Введите скорость 1 (км/ч):");
                    AddInputField("Введите скорость 2 (м/с):");
                    break;
                case 24:
                    AddInputField("Введите сторону треугольника:");
                    AddInputField("Введите радиус круга:");
                    break;
                case 25:
                    AddInputField("Введите сопротивление R1:");
                    AddInputField("Введите напряжение U1:");
                    AddInputField("Введите сопротивление R2:");
                    AddInputField("Введите напряжение U2:");
                    break;
                case 26:
                    AddInputField("Введите массу Венеры (в кг):");
                    AddInputField("Введите радиус Венеры (в км):");
                    AddInputField("Введите массу Сатурна (в кг):");
                    AddInputField("Введите радиус Сатурна (в км):");
                    break;
                case 27:
                    AddInputField("Введите текущее время (часы):");
                    break;
                case 28:
                    AddInputField("Введите долготу:");
                    AddInputField("Введите широту:");
                    break;
                case 29:
                    AddInputField("Введите расстояние до Сириуса (в км):");
                    AddInputField("Введите расстояние до Арктура (в парсеках):");
                    break;
                case 30:
                    AddInputField("Введите число:");
                    break;
                default:
                    MessageBox.Show("Окно для этой задачи еще не реализовано.");
                    break;
            }
        }

        private void AddInputField(string labelText)
        {
            var stackPanel = new StackPanel { Orientation = Orientation.Horizontal, Margin = new Thickness(0, 5, 0, 5) };
            stackPanel.Children.Add(new TextBlock { Text = labelText, Width = 150 });
            stackPanel.Children.Add(new TextBox { Width = 100 });
            InputFieldsPanel.Children.Add(stackPanel);
        }

        private void SolveButton_Click(object sender, RoutedEventArgs e)
        {
            if (_currentTaskNumber == 0)
            {
                MessageBox.Show("Сначала выберите задачу.", "Ошибка");
                return;
            }

            try
            {
                string result = "";

                switch (_currentTaskNumber)
                {
                    case 1:
                        result = SolveTask1();
                        break;
                    case 2:
                        result = SolveTask2();
                        break;
                    case 3:
                        result = SolveTask3();
                        break;
                    case 4:
                        result = SolveTask4();
                        break;
                    case 5:
                        result = SolveTask5();
                        break;
                    case 6:
                        result = SolveTask6();
                        break;
                    case 7:
                        result = SolveTask7();
                        break;
                    case 8:
                        result = SolveTask8();
                        break;
                    case 9:
                        result = SolveTask9();
                        break;
                    case 10:
                        result = SolveTask10();
                        break;
                    case 11:
                        result = SolveTask11();
                        break;
                    case 12:
                        result = SolveTask12();
                        break;
                    case 13:
                        result = SolveTask13();
                        break;
                    case 14:
                        result = SolveTask14();
                        break;
                    case 15:
                        result = SolveTask15();
                        break;
                    case 16:
                        result = SolveTask16();
                        break;
                    case 17:
                        result = SolveTask17();
                        break;
                    case 18:
                        result = SolveTask18();
                        break;
                    case 19:
                        result = SolveTask19();
                        break;
                    case 20:
                        result = SolveTask20();
                        break;
                    case 21:
                        result = SolveTask21();
                        break;
                    case 22:
                        result = SolveTask22();
                        break;
                    case 23:
                        result = SolveTask23();
                        break;
                    case 24:
                        result = SolveTask24();
                        break;
                    case 25:
                        result = SolveTask25();
                        break;
                    case 26:
                        result = SolveTask26();
                        break;
                    case 27:
                        result = SolveTask27();
                        break;
                    case 28:
                        result = SolveTask28();
                        break;
                    case 29:
                        result = SolveTask29();
                        break;
                    case 30:
                        result = SolveTask30();
                        break;
                    default:
                        result = "Задача не реализована.";
                        break;
                }

                ResultText.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
            }
        }

        private string SolveTask1()
        {
            var textBox1 = (TextBox)InputFieldsPanel.Children[0];
            var textBox2 = (TextBox)InputFieldsPanel.Children[1];

            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);

            double sumOfSquares = a * a + b * b;
            double squareOfSum = Math.Pow(a + b, 2);

            if (sumOfSquares > squareOfSum)
                return "Сумма квадратов больше.";
            else
                return "Квадрат суммы больше.";
        }

        private string SolveTask2()
        {
            var textBox1 = (TextBox)InputFieldsPanel.Children[0];
            var textBox2 = (TextBox)InputFieldsPanel.Children[1];

            double salary = double.Parse(textBox1.Text);
            int experience = int.Parse(textBox2.Text);

            double bonus = 0;
            if (experience >= 2 && experience < 5)
                bonus = salary * 0.02;
            else if (experience >= 5 && experience < 10)
                bonus = salary * 0.05;

            return $"Надбавка: {bonus}, Сумма к выплате: {salary + bonus}";
        }

        private string SolveTask3()
        {
            var textBox1 = (TextBox)InputFieldsPanel.Children[0];
            var textBox2 = (TextBox)InputFieldsPanel.Children[1];
            var textBox3 = (TextBox)InputFieldsPanel.Children[2];
            var textBox4 = (TextBox)InputFieldsPanel.Children[3];

            double x0 = double.Parse(textBox1.Text);
            double y0 = double.Parse(textBox2.Text);
            double x1 = double.Parse(textBox3.Text);
            double y1 = double.Parse(textBox4.Text);

            double distanceA = Math.Sqrt(x0 * x0 + y0 * y0);
            double distanceB = Math.Sqrt(x1 * x1 + y1 * y1);

            if (distanceA > distanceB)
                return "Точка A дальше от начала координат.";
            else
                return "Точка B дальше от начала координат.";
        }

        private string SolveTask4()
        {
            var textBox1 = (TextBox)InputFieldsPanel.Children[0];
            var textBox2 = (TextBox)InputFieldsPanel.Children[1];
            var textBox3 = (TextBox)InputFieldsPanel.Children[2];

            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);

            if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                return "Треугольник прямоугольный.";
            else
                return "Треугольник не прямоугольный.";
        }

        private string SolveTask5()
        {
            var textBox1 = (TextBox)InputFieldsPanel.Children[0];
            var textBox2 = (TextBox)InputFieldsPanel.Children[1];
            var textBox3 = (TextBox)InputFieldsPanel.Children[2];

            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);

            a = a > 0 ? a * a : a;
            b = b > 0 ? b * b : b;
            c = c > 0 ? c * c : c;

            return $"Результат: {a}, {b}, {c}";
        }

        private string SolveTask6()
        {
            var textBox1 = (TextBox)InputFieldsPanel.Children[0];
            var textBox2 = (TextBox)InputFieldsPanel.Children[1];

            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);

            if (x > 0 && y > 0)
                return "Точка в первой четверти.";
            else if (x < 0 && y > 0)
                return "Точка во второй четверти.";
            else if (x < 0 && y < 0)
                return "Точка в третьей четверти.";
            else
                return "Точка в четвертой четверти.";
        }

        private string SolveTask7()
        {
            var textBox1 = (TextBox)InputFieldsPanel.Children[0];
            var textBox2 = (TextBox)InputFieldsPanel.Children[1];
            var textBox3 = (TextBox)InputFieldsPanel.Children[2];

            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);
            double R = double.Parse(textBox3.Text);

            double distance = Math.Sqrt(x * x + y * y);

            if (distance <= R)
                return "Точка внутри окружности.";
            else
                return "Точка вне окружности.";
        }

        private string SolveTask8()
        {
            var textBox1 = (TextBox)InputFieldsPanel.Children[0];
            var textBox2 = (TextBox)InputFieldsPanel.Children[1];
            var textBox3 = (TextBox)InputFieldsPanel.Children[2];
            var textBox4 = (TextBox)InputFieldsPanel.Children[3];
            var textBox5 = (TextBox)InputFieldsPanel.Children[4];
            var textBox6 = (TextBox)InputFieldsPanel.Children[5];

            double a1 = double.Parse(textBox1.Text);
            double b1 = double.Parse(textBox2.Text);
            double c1 = double.Parse(textBox3.Text);
            double a2 = double.Parse(textBox4.Text);
            double b2 = double.Parse(textBox5.Text);
            double c2 = double.Parse(textBox6.Text);

            double p1 = (a1 + b1 + c1) / 2;
            double area1 = Math.Sqrt(p1 * (p1 - a1) * (p1 - b1) * (p1 - c1));

            double p2 = (a2 + b2 + c2) / 2;
            double area2 = Math.Sqrt(p2 * (p2 - a2) * (p2 - b2) * (p2 - c2));

            if (area1 > area2)
                return "Площадь первого треугольника больше.";
            else
                return "Площадь второго треугольника больше.";
        }

        private string SolveTask9()
        {
            var textBox1 = (TextBox)InputFieldsPanel.Children[0];
            var textBox2 = (TextBox)InputFieldsPanel.Children[1];

            double a = double.Parse(textBox1.Text);
            double R = double.Parse(textBox2.Text);

            double squareArea = a * a;
            double circleArea = Math.PI * R * R;

            if (squareArea > circleArea)
                return "Площадь квадрата больше.";
            else
                return "Площадь окружности больше.";
        }

        private string SolveTask10()
        {
            var textBox1 = (TextBox)InputFieldsPanel.Children[0];
            var textBox2 = (TextBox)InputFieldsPanel.Children[1];
            var textBox3 = (TextBox)InputFieldsPanel.Children[2];

            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);

            a = a > 0 ? Math.Pow(a, 3) : 0;
            b = b > 0 ? Math.Pow(b, 3) : 0;
            c = c > 0 ? Math.Pow(c, 3) : 0;

            return $"Результат: {a}, {b}, {c}";
        }

        private string SolveTask11()
        {
            var textBox1 = (TextBox)InputFieldsPanel.Children[0];

            int number = int.Parse(textBox1.Text);

            if (number % 2 == 0 || number % 10 == 3)
                return "Число четное или оканчивается на 3.";
            else
                return "Число не четное и не оканчивается на 3.";
        }

        private string SolveTask12()
        {
            var textBox1 = (TextBox)InputFieldsPanel.Children[0];
            var textBox2 = (TextBox)InputFieldsPanel.Children[1];

            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);

            if (x > 0 && y > 0)
                return "Точка в первой четверти.";
            else
                return "Точка не в первой четверти.";
        }

        private string SolveTask13()
        {
            var textBox1 = (TextBox)InputFieldsPanel.Children[0];
            var textBox2 = (TextBox)InputFieldsPanel.Children[1];

            double deposit = double.Parse(textBox1.Text);
            int term = int.Parse(textBox2.Text);

            double rate = term == 6 ? 0.06 : 0.08;
            double monthlyInterest = deposit * rate / 12;

            return $"Сумма ежемесячных выплат: {monthlyInterest}";
        }

        private string SolveTask14()
        {
            var textBox1 = (TextBox)InputFieldsPanel.Children[0];
            var textBox2 = (TextBox)InputFieldsPanel.Children[1];

            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);

            double differenceOfSquares = a * a - b * b;
            double squareOfDifference = Math.Pow(a - b, 2);

            if (differenceOfSquares > squareOfDifference)
                return "Разность квадратов больше.";
            else
                return "Квадрат разности больше.";
        }

        private string SolveTask15()
        {
            var textBox1 = (TextBox)InputFieldsPanel.Children[0];
            var textBox2 = (TextBox)InputFieldsPanel.Children[1];
            var textBox3 = (TextBox)InputFieldsPanel.Children[2];
            var textBox4 = (TextBox)InputFieldsPanel.Children[3];

            double x0 = double.Parse(textBox1.Text);
            double y0 = double.Parse(textBox2.Text);
            double x1 = double.Parse(textBox3.Text);
            double y1 = double.Parse(textBox4.Text);

            double distanceA = Math.Sqrt(x0 * x0 + y0 * y0);
            double distanceB = Math.Sqrt(x1 * x1 + y1 * y1);

            if (distanceA < distanceB)
                return "Точка A ближе к началу координат.";
            else
                return "Точка B ближе к началу координат.";
        }

        private string SolveTask16()
        {
            var textBox1 = (TextBox)InputFieldsPanel.Children[0];
            var textBox2 = (TextBox)InputFieldsPanel.Children[1];
            var textBox3 = (TextBox)InputFieldsPanel.Children[2];
            var textBox4 = (TextBox)InputFieldsPanel.Children[3];

            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);
            double r = double.Parse(textBox3.Text);
            double R = double.Parse(textBox4.Text);

            double distance = Math.Sqrt(x * x + y * y);

            if (distance > r && distance < R)
                return "Точка внутри тора.";
            else
                return "Точка вне тора.";
        }

        private string SolveTask17()
        {
            var textBox1 = (TextBox)InputFieldsPanel.Children[0];
            var textBox2 = (TextBox)InputFieldsPanel.Children[1];

            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);

            if (x > 0 && y < 0)
                return "Точка в четвертой четверти.";
            else
                return "Точка не в четвертой четверти.";
        }

        private string SolveTask18()
        {
            var textBox1 = (TextBox)InputFieldsPanel.Children[0];
            var textBox2 = (TextBox)InputFieldsPanel.Children[1];
            var textBox3 = (TextBox)InputFieldsPanel.Children[2];

            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);

            if (a == b || b == c || a == c)
                return "Треугольник равнобедренный.";
            else
                return "Треугольник не равнобедренный.";
        }

        private string SolveTask19()
        {
            var textBox1 = (TextBox)InputFieldsPanel.Children[0];
            var textBox2 = (TextBox)InputFieldsPanel.Children[1];
            var textBox3 = (TextBox)InputFieldsPanel.Children[2];

            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);

            if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                return "Числа являются тройкой Пифагора.";
            else
                return "Числа не являются тройкой Пифагора.";
        }

        private string SolveTask20()
        {
            var textBox1 = (TextBox)InputFieldsPanel.Children[0];
            var textBox2 = (TextBox)InputFieldsPanel.Children[1];

            double lPerS = double.Parse(textBox1.Text);
            double m3PerMin = double.Parse(textBox2.Text);

            double m3PerS = m3PerMin / 60;

            if (lPerS > m3PerS)
                return "1 л/с больше.";
            else
                return "10^-3 м³/мин больше.";
        }

        private string SolveTask21()
        {
            var textBox1 = (TextBox)InputFieldsPanel.Children[0];
            var textBox2 = (TextBox)InputFieldsPanel.Children[1];

            double circleArea = double.Parse(textBox1.Text);
            double squareArea = double.Parse(textBox2.Text);

            double circleRadius = Math.Sqrt(circleArea / Math.PI);
            double squareSide = Math.Sqrt(squareArea);

            if (2 * circleRadius <= squareSide)
                return "Круг уместится в квадрате.";
            else
                return "Круг не уместится в квадрате.";

            if (squareSide * Math.Sqrt(2) <= 2 * circleRadius)
                return "Квадрат уместится в круге.";
            else
                return "Квадрат не уместится в круге.";
        }

        private string SolveTask22()
        {
            var textBox1 = (TextBox)InputFieldsPanel.Children[0];
            var textBox2 = (TextBox)InputFieldsPanel.Children[1];
            var textBox3 = (TextBox)InputFieldsPanel.Children[2];
            var textBox4 = (TextBox)InputFieldsPanel.Children[3];

            double volume1 = double.Parse(textBox1.Text);
            double mass1 = double.Parse(textBox2.Text);
            double volume2 = double.Parse(textBox3.Text);
            double mass2 = double.Parse(textBox4.Text);

            double density1 = mass1 / volume1;
            double density2 = mass2 / volume2;

            if (density1 > density2)
                return "Первое тело имеет большую плотность.";
            else
                return "Второе тело имеет большую плотность.";
        }

        private string SolveTask23()
        {
            var textBox1 = (TextBox)InputFieldsPanel.Children[0];
            var textBox2 = (TextBox)InputFieldsPanel.Children[1];

            double kmPerH = double.Parse(textBox1.Text);
            double mPerS = double.Parse(textBox2.Text);

            double kmPerHToMPerS = kmPerH * 1000 / 3600;

            if (kmPerHToMPerS > mPerS)
                return "Скорость в км/ч больше.";
            else
                return "Скорость в м/с больше.";
        }

        private string SolveTask24()
        {
            var textBox1 = (TextBox)InputFieldsPanel.Children[0];
            var textBox2 = (TextBox)InputFieldsPanel.Children[1];

            double a = double.Parse(textBox1.Text);
            double r = double.Parse(textBox2.Text);

            double circleRadiusInTriangle = a * Math.Sqrt(3) / 6;
            double circleRadiusAroundTriangle = a * Math.Sqrt(3) / 3;

            if (r <= circleRadiusInTriangle)
                return "Круг уместится в треугольнике.";
            else
                return "Круг не уместится в треугольнике.";

            if (r >= circleRadiusAroundTriangle)
                return "Треугольник уместится в круге.";
            else
                return "Треугольник не уместится в круге.";
        }

        private string SolveTask25()
        {
            var textBox1 = (TextBox)InputFieldsPanel.Children[0];
            var textBox2 = (TextBox)InputFieldsPanel.Children[1];
            var textBox3 = (TextBox)InputFieldsPanel.Children[2];
            var textBox4 = (TextBox)InputFieldsPanel.Children[3];

            double R1 = double.Parse(textBox1.Text);
            double U1 = double.Parse(textBox2.Text);
            double R2 = double.Parse(textBox3.Text);
            double U2 = double.Parse(textBox4.Text);

            double I1 = U1 / R1;
            double I2 = U2 / R2;

            if (I1 < I2)
                return "Меньший ток на первом участке.";
            else
                return "Меньший ток на втором участке.";
        }

        private string SolveTask26()
        {
            var textBox1 = (TextBox)InputFieldsPanel.Children[0];
            var textBox2 = (TextBox)InputFieldsPanel.Children[1];
            var textBox3 = (TextBox)InputFieldsPanel.Children[2];
            var textBox4 = (TextBox)InputFieldsPanel.Children[3];

            double mv = double.Parse(textBox1.Text);
            double rv = double.Parse(textBox2.Text);
            double ms = double.Parse(textBox3.Text);
            double rs = double.Parse(textBox4.Text);

            double G = 6.7e-8; 

            double gv = G * mv / (rv * rv);
            double gs = G * ms / (rs * rs);

            if (gv > gs)
                return "Венера имеет большее ускорение силы тяжести.";
            else
                return "Сатурн имеет большее ускорение силы тяжести.";
        }

        private string SolveTask27()
        {
            var textBox1 = (TextBox)InputFieldsPanel.Children[0];

            int hours = int.Parse(textBox1.Text);

            if (hours >= 0 && hours < 12)
                return "Утро.";
            else
                return "Вечер.";
        }

        private string SolveTask28()
        {
            var textBox1 = (TextBox)InputFieldsPanel.Children[0];
            var textBox2 = (TextBox)InputFieldsPanel.Children[1];

            double longitude = double.Parse(textBox1.Text);
            double latitude = double.Parse(textBox2.Text);

            if (longitude >= 0)
                return "Восточное полушарие.";
            else
                return "Западное полушарие.";
        }

        private string SolveTask29()
        {
            var textBox1 = (TextBox)InputFieldsPanel.Children[0];
            var textBox2 = (TextBox)InputFieldsPanel.Children[1];

            double siriusDistance = double.Parse(textBox1.Text);
            double arcturusDistance = double.Parse(textBox2.Text);

            if (siriusDistance > arcturusDistance)
                return "Сириус дальше.";
            else
                return "Арктур дальше.";
        }

        private string SolveTask30()
        {
            var textBox1 = (TextBox)InputFieldsPanel.Children[0];

            int number = int.Parse(textBox1.Text);

            if (number % 2 == 0 || number % 10 == 7)
                return "Число четное или оканчивается на 7.";
            else
                return "Число не четное и не оканчивается на 7.";
        }
    }
}