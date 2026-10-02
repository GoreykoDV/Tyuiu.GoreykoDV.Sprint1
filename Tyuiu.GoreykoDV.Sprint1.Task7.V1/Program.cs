using Tyuiu.GoreykoDV.Sprint1.Task7.V1.Lib;

namespace Tyuiu.GoreykoDV.Sprint1.Task7.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #1 | Выполнил: Горейко Д.В. | РППб-26-1";

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                  *");
            Console.WriteLine("* Задание #7                                                               *");
            Console.WriteLine("* Вариант #1                                                               *");
            Console.WriteLine("* Выполнил: Горейко Дарья Владимировна | РППб-26-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программукоторая вычисляет                                      *");
            Console.WriteLine("* математическое выражение по исходным значениям данных                    *");
            Console.WriteLine("*          2                                                               *");
            Console.WriteLine("*       b√b+4*a*c   3     -2                                               *");
            Console.WriteLine("*z=     --------- -a  *c+b                                                 *");
            Console.WriteLine("*          2*a                                                             *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            double a, b, c;

            Console.WriteLine("Введите значение a:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение b:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение c:");
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine(ds.Calculate(a, b, c));
            Console.ReadKey();
        }
    }
}
