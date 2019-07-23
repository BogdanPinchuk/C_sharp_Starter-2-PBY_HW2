using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // завдання яке вимагається
#if false
            // Створення строкових змінних
            string s1 = "\nМоя строка 1",
                s2 = "\tМоя строка 2",
                s3 = "\aМоя строка 3";

            // вивід значень
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
#endif

            // варінт як зробити економічніше
#if true
            // Масив строк
            string[] s = new string[3]
            {
                "\nМоя строка 1",
                "\tМоя строка 2",
                "\aМоя строка 3"
            };

            // вівід через цикл
            for (int i = 0; i < s.Length; i++)
                Console.WriteLine(s[i]);
#endif
            // затримка
            Console.ReadKey();
        }
    }
}
