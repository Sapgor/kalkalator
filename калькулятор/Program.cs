using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
class Calculator
{
    static double Add(double x, double y)
    {
        return x + y;
    }
    static double Subtract(double x, double y)
    {
        return x - y;
    }
    static double Multiply(double x, double y)
    {
        return x * y;
    }
    static double Divide(double x, double y)
    {
        if (y == 0)
        { }
        return x / y;
    }

    static double Power(double x, double n)
    {
        return Math.Pow(x, n);
    }
    static double SquareRoot(double x)
    {
        if (x < 0)
        { }
        return Math.Sqrt(x);
    }
    static double Percent(double x)
    {
        return x / 100;
    }
    static double Factorial(double x)
    {
        if (x < 0)
        {
        }
        if (x == 0)
        { }
        double result = 1; for (int i = 1; i <= x; i++)
        {
            result *= i;
        }
        return result;
    }
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Выберите операцию:"); Console.WriteLine("1. Сложить 2 числа");
            Console.WriteLine("2. Вычитание второго числа из первого"); Console.WriteLine("3. Перемножить два числа");
            Console.WriteLine("4. Разделить первое на второе"); Console.WriteLine("5. Возвести в степень N первое число");
            Console.WriteLine("6. Найти квадратный корень из числа"); Console.WriteLine("7. Найти 1 процент от числа");
            Console.WriteLine("8. Найти факториал из числа"); Console.WriteLine("9. Выйти из программы");
            string choice = Console.ReadLine();
            if (choice == "9")
            {
                break;
            }
            if (choice != "1" && choice != "2" && choice != "3" && choice != "4" && choice != "5" && choice != "6" && choice != "7" && choice != "8")
            {
                Console.WriteLine("Неверный выбор операции. Пожалуйста, выберите снова."); continue;
            }
            Console.Write("Введите первое число: ");
            double num1 = double.Parse(Console.ReadLine());
            if (choice != "5" && choice != "6" && choice != "7" && choice != "8")
            {
                Console.Write("Введите второе число: "); double num2 = double.Parse(Console.ReadLine());
                { }
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Результат: " + Add(num1, num2));
                        break;
                    case "2":
                        Console.WriteLine("Результат: " + Subtract(num1, num2)); break;
                    case "3":
                        Console.WriteLine("Результат: " + Multiply(num1, num2));
                        break;
                    case "4":
                        if (num2 == 0) Console.WriteLine("Ошибка: деление на 0 невозможно");
                        else Console.WriteLine("Результат: " + Divide(num1, num2));
                        break;
                }
            }
            else
            {
                switch (choice)
                {
                    case "5":
                        Console.Write("Введите степень N: ");
                        double n = double.Parse(Console.ReadLine()); Console.WriteLine("Результат: " + Power(num1, n));
                        break;
                    case "6":
                        if (num1 < 0) Console.WriteLine("Ошибка: нельзя извлекать квадратный корень из отрицательного числа");
                        else Console.WriteLine("Результат: " + SquareRoot(num1));
                        break;
                    case "7":
                        Console.WriteLine("Результат: " + Percent(num1)); break;
                    case "8":
                        if (num1 < 0)
                            Console.WriteLine("Ошибка: нельзя вычислить факториал отрицательного числа");
                        else
                            Console.WriteLine("Результат: " + Factorial(num1)); break;
                }
            }
        }
    }
}