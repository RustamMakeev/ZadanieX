using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieX
{
    internal class Program
    {
        static void Main()
        {
            // 1. Создать целочисленную переменную и присвоить ей значение 1
            int a = 1;
            // 2. Создать вещественную переменную и присвоить ей любое значение
            double b = 0.2;
            // 3. Создать не явно типизированную переменную и присвоить ей любое значение
            var c = 12;
            // 4.Вывести на консоль все переменные в строчку 1 методом
            Console.WriteLine($"{a},{b},{c}");
            // 5. Возвести в квадрат целочисленную переменную и вывести результат на консоль
            Console.WriteLine(a * a);
            // 6. Найти остаток от деления 12 на 4 и вывести на консоль
            int d = 12;
            int e = 4;
            Console.WriteLine(d% e);
            // 7. Принять с консоли 3 числа и перемножить их, результат вывести на консоль
            Console.Write("Введите a: ");
            int f = int.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            int g = int.Parse(Console.ReadLine());
            Console.Write("Введите c: ");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Произведение трех чисел равно: " + a * b * c);
            // 8. Принять с консоли 2 числа и найти большее из них
            Console.Write("Введите первое число: ");
            int i = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int j = int.Parse(Console.ReadLine());
            if (i > j)
            {
                Console.WriteLine($"Число {i} больше {j}");
            }
            else
            {
                Console.WriteLine($"Число {j} больше {i}");
            }
            // 9. Принять с консоли 2 числа если оба четные то сложить их иначе перемножить, ответ вывести на консоль
            Console.Write("Введите первое число: ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int l = int.Parse(Console.ReadLine());
            if ((k % 2 + l % 2) == 0)
            {
                Console.WriteLine($"Числа четные, складываем и получаем: {k + l}");
            }
            else
            {
                Console.WriteLine($"Числа не четные, перемножаем и получаем: {k * l}");
            }
            // 10. Бесконечно выводить 1 в консоль
            while (true)
            {
                Console.WriteLine(1);
            }
        }
    }
}
