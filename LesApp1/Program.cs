using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задані значення змінних
            decimal pi = 3.141592653m,      // число пі
                eps = 2.7182818284590452m;  // число Ейлера

            // Вивід базових даних в консоль
            Console.WriteLine("Константы в С#\n" +
                $"Число pi: {Math.PI};\n" +
                $"Чиcло Эйлера e: {Math.E};\n");

            // Вивід вказаних даних в консоль
            Console.WriteLine("Задание значения\n" +
                "Число pi: {0};\n" +
                "Чсило Эйлера e: {1};", pi, eps);

            // Затримка
            Console.ReadKey();
        }
    }
}
