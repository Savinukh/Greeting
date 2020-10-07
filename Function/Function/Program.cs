using System;
using System.ComponentModel.DataAnnotations;

namespace Function
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Задайте значение X: ");
                double x = double.Parse(Console.ReadLine());
                Console.Write("Задайте шаг построения функции: ");
                double s = double.Parse(Console.ReadLine());
                Console.Write("Введите диапазон значения X в формате 'значение-значение' : ");
                string range = Console.ReadLine();
                // определяем индекс разделителя
                int l = range.IndexOf("-");
                // определяем макс. значение X
                string a = range.Substring(l + 1);
                double Rmax = double.Parse(a);
                // определяем мин. значение X
                string aa = range.Substring(0, range.LastIndexOf('-'));
                double Rmin = double.Parse(aa);
                // определяем макс. кол. знаков Y
                string ch = Convert.ToString((Rmax + s));
                int chs = ch.Length + 1;
                int f = 0; // отсечка для шапки таблицы
                           // запускаем цикл
                for (double i = x; i < Rmax; i++)
                {
                    // выравнивание строк
                    x = Math.Round(i, 3);
                    i = Math.Round((i + s), 2);
                    // определяем количество пробелов для центровки данных в таблице             
                    int chX = x.ToString().Length;
                    int SpaceX = Math.Abs(chs - chX);
                    string spX = "".PadRight(SpaceX);
                    int chY = i.ToString().Length;
                    int SpaceY = Math.Abs(chs - chY);
                    string spY = "".PadRight(SpaceY);
                    // определяем длину границы строки
                    string b = "|" + x + "|" + i + "|";
                    int str = b.Length + SpaceX + SpaceY;
                    // шапка таблицы
                    if (f == 0)
                    {
                        string sp = "".PadRight(SpaceX + chX - 1);
                        Console.WriteLine("|x{0}|y{0}|", sp);// центруем шапку
                        f = 1;
                    }
                    if (x > Rmin) // отсечка по мин. значению X
                    {
                        Console.WriteLine("".PadRight(str, '_')); // нижняя граница строк таблицы
                        Console.WriteLine("|{0}{1}|{2}{3}|", x, spX, i, spY);
                    }
                    i = i - 1;
                }

                Console.WriteLine("Поиграем ещё? 0-нет, 1-да");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        break;
                    case 1:
                        Console.Clear();
                        Main();
                        break;

                }
            }
            catch
            {
                Console.WriteLine("Данные введены некорректно! Повторите ввод.");
                Console.ReadKey();
                Console.Clear();
                Main();
            }
        }
    }
}
