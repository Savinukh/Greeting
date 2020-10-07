using Microsoft.VisualBasic;
using System;

namespace horse
{
    class Program
    {
        static void Main()
        {
            string Letters = " ABCDEFGH";
            Console.Write("Введите ход конём: ");
            char x = Convert.ToChar(Console.Read());
            char x1 = char.ToUpper(x);

            int a = Convert.ToChar(Console.Read());
            int a1 = (int)(a - '0');
            if (a1 > 8)
                goto err;
            char l = Convert.ToChar(Console.Read());
            char y = Convert.ToChar(Console.Read());
            char x2 = char.ToUpper(y);
            int b = Convert.ToChar(Console.Read());
            int b1 = (int)(b - '0');
            if (b1 > 8)
                goto err;
            int h = Letters.IndexOf(x1);
            if (h < 0)
            {
                goto err;
            }
            if ((h + a) % 2 == 0)
            {
                Console.WriteLine("Вы играете черными");
            }
            else
            {
                Console.WriteLine("Вы играете белыми");
            }
            int n = Letters.IndexOf(x2);

            int s = Math.Abs(h - n) + Math.Abs(a - b);

            if ((s > 3) || (s < 3) || (Letters.IndexOf(x1) == Letters.IndexOf(x2)) || (a == b))
            {
                Console.WriteLine("Так кони не ходят");
            }
            else
            {
                Console.WriteLine("Ход конем правильный");
            }
            Console.ReadKey();
            return;
        err:
            Console.WriteLine("Я играю в классические шахматы. Ход должен быть в диапазоне от A1 до H8");
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}