namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
1 завдання
using System;

class Program
{
    static void Main()
    {
        int N;

        Console.Write("Введіть кількість повторень (N): ");
        while (!int.TryParse(Console.ReadLine(), out N) || N <= 0)
        {
            Console.WriteLine("Помилка! Введіть додатне ціле число.");
            Console.Write("Спробуйте ще раз: ");
        }

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine("Дейко Влад"); // Заміни на своє прізвище
        }

        Console.WriteLine("Натисніть будь-яку клавішу для завершення...");
        Console.ReadKey();
    }
}
2 завдання
using System;

class Program
{
    static void Main()
    {
        int n;
        Console.WriteLine("Дейко Влад");
        Console.Write("Введіть ціле додатне число n: ");
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("Помилка! Введіть додатне ціле число.");
            Console.Write("Спробуйте ще раз: ");
        }

        long product = 1;
        bool hasEven = false;

        for (int i = 2; i <= n; i += 2)
        {
            product *= i;
            hasEven = true;
        }

        if (hasEven)
        {
            Console.WriteLine($"Добуток усіх парних чисел від 1 до {n} дорівнює: {product}");
        }
        else
        {
            Console.WriteLine("У вказаному діапазоні немає парних чисел.");
        }

        Console.WriteLine("Натисніть будь-яку клавішу для завершення...");
        Console.ReadKey();
    }
}

3 завдання 
using System;

class Program
{
    static void Main()
    {
        int k;
        double x;
        Console.WriteLine("Дейко Влад");
        // Введення x
        Console.Write("Введіть дійсне число x: ");
        while (!double.TryParse(Console.ReadLine(), out x))
        {
            Console.WriteLine("Помилка! Введіть коректне дійсне число.");
        }

        // Введення k
        Console.Write("Введіть ціле додатне число k: ");
        while (!int.TryParse(Console.ReadLine(), out k) || k < 0)
        {
            Console.WriteLine("Помилка! Введіть додатне ціле число.");
        }

        double result = 1;

        for (int i = 0; i < k; i++)
        {
            result *= x;
        }

        Console.WriteLine($"{x}^{k} = {result}");

        Console.WriteLine("Натисніть будь-яку клавішу для завершення...");
        Console.ReadKey();
    }
}

4 завдання
using System;

class Program
{
    static void Main()
    {
        int positiveCount = 0;
        int negativeCount = 0;
        double sum = 0;
        double number;
        Console.WriteLine("Дейко Влад");
        Console.WriteLine("Вводьте числа (0 — для завершення):");

        while (true)
        {
            Console.Write("Введіть число: ");
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Помилка! Введіть дійсне число.");
                Console.Write("Спробуйте ще раз: ");
            }

            if (number == 0)
            {
                break; // Завершення введення
            }

            sum += number;

            if (number > 0)
                positiveCount++;
            else
                negativeCount++;
        }

        Console.WriteLine("\nРезультати:");
        Console.WriteLine($"Сума всіх чисел: {sum}");
        Console.WriteLine($"Кількість додатних чисел: {positiveCount}");
        Console.WriteLine($"Кількість від’ємних чисел: {negativeCount}");

        Console.WriteLine("\nНатисніть будь-яку клавішу для завершення...");
        Console.ReadKey();
    }
}
5 завдання 
using System;

class Program
{
    static void Main()
    {
        double x = -2.0;
        double y;
        double h = 0.2;
        Console.WriteLine("Дейко Влад");
        Console.WriteLine(" x\t|\ty = sin(x)/ln(x+4)");
        Console.WriteLine("------------------------------");

        while (x <= 5.0)
        {
            // Перевірка, щоб логарифм не мав 0 або від’ємного аргументу
            if (x + 4 > 0)
            {
                y = Math.Sin(x) / Math.Log(x + 4);
                Console.WriteLine($"{x:F1}\t|\t{y:F4}");
            }
            else
            {
                Console.WriteLine($"{x:F1}\t|\tневизначено (ln(x+4) ≤ 0)");
            }

            x += h;
        }

        Console.WriteLine("\nНатисніть будь-яку клавішу для завершення...");
        Console.ReadKey();
    }
}
