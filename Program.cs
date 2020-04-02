using System;

namespace DZ1_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1 
            // Пользователь вводит 2 числа (А и В). Выведите в консоль решение c = (5 * a + b* b) / (b - a)

            Console.WriteLine("Задание 1. Пользователь вводит 2 числа (А и В). Выведите в консоль решение c = (5 * a + b* b) / (b - a)");

            int a, b, c;

            Console.Write("введи a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("введи b = ");
            b = Convert.ToInt32(Console.ReadLine());

            c = DZ1_Variables.Class1.Reshenie_primera(a, b);

            Console.Write("значение c = ");
            Console.WriteLine(c);
            Console.WriteLine();

            // Задание 2
            // Пользователь вводит 2 числа (А и В). Поменяйте содержимое переменных А и В местами.

            Console.WriteLine("Задание 2. Пользователь вводит 2 числа (А и В). Поменяйте содержимое переменных А и В местами.");

            Console.Write("введи a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("введи b = ");
            b = Convert.ToInt32(Console.ReadLine());

            int tmp = a;
            a = b;
            b = tmp;

            Console.Write("значение a = ");
            Console.WriteLine(a);
            Console.Write("значение b = ");
            Console.WriteLine(b);
            Console.WriteLine();

            // Задание 3
            // Пользователь вводит 2 числа (А и В). Выведите в консоль результат деления А на В и остаток от деления.

            Console.WriteLine("Задание 3. Пользователь вводит 2 числа (А и В). Выведите в консоль результат деления А на В и остаток от деления.");
            int d;

            Console.Write("введи a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("введи b = ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a >= b)
            {
                c = a / b;
                int v = a % c;
                d = v;

                Console.Write("результат a/b=");
                Console.Write(c);
                Console.Write(" остаток ");
                Console.WriteLine(d);
            }

            else if (a < b)

            {
                Console.Write("решения нет");
            }

            Console.WriteLine();

            // Задание 4
            // Пользователь вводит 3 числа (А, В и С). Выведите в консоль решение (значение Х) линейного уравнения стандартного вида, где a*x+b=c

            Console.WriteLine("Задание 4. Пользователь вводит 3 числа (А, В и С). Выведите в консоль решение (значение Х) линейного уравнения стандартного вида, где a*x+b=c.");

            int x;

            Console.Write("введи a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("введи b = ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("введи c = ");
            c = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("a*x+b=c");
            x = DZ1_Variables.Class1.Naiti_X(a, b, c);
            Console.Write("значение x = ");
            Console.WriteLine(x);
            Console.WriteLine();

            // Задание 5
            // Пользователь вводит 4 числа (x1, y1, x2, y2), описывающие координаты 2-х точек на координатной плоскости. Выведите уравнение прямой в формате Y=AX+B, проходящей через эти точки.

            Console.WriteLine("Задание 5. Пользователь вводит 4 числа (x1, y1, x2, y2), описывающие координаты 2-х точек на координатной плоскости. Выведите уравнение прямой в формате Y=AX+B, проходящей через эти точки.");

            int x1, y1, x2, y2;
            Console.Write("введи x1 = ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("введи y1 = ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("введи x2 = ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("введи y2 = ");
            y2 = Convert.ToInt32(Console.ReadLine());

            a = (y1 - y2) / (x2 - x1);
            b = y1 - a * x1;

            Console.Write("y=");
            Console.Write(a);
            Console.Write("x+");
            Console.Write(b);
        }
    }
}
