﻿string answer;
string yes = "да";
do
{
    Console.WriteLine("Какое действие будет выполняться? ");
    Console.WriteLine("1) Сложение" + "\n" + "2) Вычитание");
    Console.WriteLine("3) Умножение" + "\n" + "4) Деление");
    Console.WriteLine("5) Возведение в степень");
    Console.WriteLine("6) Квадратный корень числа");
    Console.WriteLine("7) Найти 1% из числа" + "\n" + "8) Найти факториал из числа");
    Console.WriteLine("9) Выйти из программы ");
    int action = Convert.ToInt32(Console.ReadLine());
    if (action == 9)
    {
        Console.WriteLine("Вы вышли из программы ");
        return;
    }
    if (action == 9)
    {
        Console.WriteLine("Вы вышли из программы ");
        return;
    }

    if (action == 5)
    {
        Console.WriteLine("Введите число которое хотите возвести в степень: ");
        int a1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите степень");
        int N = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Math.Pow(a1, N));
    }
    else if (action == 6)
    {
        Console.WriteLine("Введите число из которого хотите извлечь корень: ");
        int L = Convert.ToInt32(Console.ReadLine());
        double d = Math.Sqrt(L);
        Console.WriteLine(d);
    }
    else if (action == 7)
    {
        Console.WriteLine("Введите число: ");
        int u = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(u / 100);
    }
    else if (action == 8)
    {
        Console.WriteLine("Введите число из которого хотите вычислить факториал: ");
        int e = Convert.ToInt32(Console.ReadLine());
        int c = 1;
        for (int i = 1; e >= i; ++i)
        {
            c = c * i;
        }
        Console.WriteLine(c);
    }
    else
        Console.WriteLine("Введите первое число ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число ");
    int b = Convert.ToInt32(Console.ReadLine());
    if (action == 1)
    {
        Console.WriteLine(a + b);
    }
    else if (action == 2)
    {
        Console.WriteLine(a - b);
    }
    else if (action == 3)
    {
        Console.WriteLine(a * b);
    }
    else if (action == 4)
    {
        Console.WriteLine(a / b);
    }
    Console.WriteLine("Желаете повторить?(да/нет) ");
    answer = Console.ReadLine();
} while (answer.Equals(yes, StringComparison.OrdinalIgnoreCase));
