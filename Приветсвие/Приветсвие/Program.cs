using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
            метка1:
                try
                {
                    string yourName;
                    Console.WriteLine("Здраствуйте, назовите ваше имя");
                    yourName = Console.ReadLine();
                    Console.WriteLine("Приятно познакомится, " + yourName + "!" + " Теперь введи сегодняшнюю дату:");
                    Console.WriteLine("Год");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Месяц");
                    int y = Convert.ToInt32(Console.ReadLine());
                    if (y < 1 || y > 12)
                    {
                        Console.WriteLine("Нет такого месяца как {y}");
                        return;
                    }
                    Console.WriteLine("Число");
                    int z = Convert.ToInt32(Console.ReadLine());
                    if (y == 2) //если месяц февраль, то проверяем на високосный год
                    {
                        if (x % 4 == 0)
                        {
                            if (z < 1 || z > 29)
                            {
                                Console.WriteLine("В этом месяце нет такого дня как {z}" + ". Проверте еще раз введёную дату");
                                return;
                            }
                        }
                        else
                        {
                            if (z < 1 || z > 28)
                            {
                                Console.WriteLine("В этом месяце нет такого дня как {z}" + ". Проверте еще раз введёную дату");
                                return;
                            }
                        }
                    }
                    else if (y == 1 | y == 3 | y == 5 | y == 7 | y == 8 | y == 10 | y == 12) //если у месяца всего 31 день, то выполняем проверку
                    {
                        if (z < 1 || z > 31)
                        {
                            Console.WriteLine("В этом месяце нет такого дня как {z}" + ". Проверте еще раз введёную дату");
                            return;
                        }
                    }
                    else if (y == 4 | y == 6 | y == 9 | y == 11) //если у месяца всего 30 дней, то выполняем проверку
                    {
                        if (z < 1 || z > 30)
                        {
                            Console.WriteLine("В этом месяце нет такого дня как {z}" + ". Проверте еще раз введёную дату");
                            return;
                        }
                    }

                    Console.WriteLine("Хорошо, теперь введи дату своего рождения");
                    {
                        {

                            DateTime др = DateTime.Parse(Console.ReadLine());
                            TimeSpan возраст = DateTime.Today - др;
                            Console.WriteLine("Привет," + yourName + " тебе {0} лет" + ", приятно было познакомится", Math.Floor(возраст.Days / 365.255));
                            Console.ReadKey();
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Не балуйтесь и введите корректную дату");
                    goto метка1;
                }
                finally
                {

                }
            }
        }
    }
}
