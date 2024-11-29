using Tyuiu.PasechnikPA1.Sprint2.Task5.V13.Lib;
namespace Tyuiu.PasechnikPA1.Sprint2.Task5.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Пасечник П. А. | АСОиУБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Пасечник Павел Андреевич | АСОиУБ-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дата некоторого дня характеризуется тремя натуральными числами: g (год),*");
            Console.WriteLine("* m (порядковый номер месяца) и n (число). По заданным g, n и m           *");
            Console.WriteLine("* пределить дату следующего дня. Заданный год является високосным.        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            Console.WriteLine("Введите число дня: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число месяца: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите високосный год: ");
            int g = Convert.ToInt32(Console.ReadLine());

            string res = ds.FindDateOfNextDay(n, m, g);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Дата следующего дня: " + res);
            Console.ReadKey();

        }
    }
}
