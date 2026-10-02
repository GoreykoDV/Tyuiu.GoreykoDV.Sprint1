using Tyuiu.GoreykoDV.Sprint1.Task4.V3.Lib;

namespace Tyuiu.GoreykoDV.Sprint1.Task4.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #1 | Выполнил: Горейко Д.В. | РППб-26-1";

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Class Math                                                         *");
            Console.WriteLine("* Задание #4                                                               *");
            Console.WriteLine("* Вариант #3                                                               *");
            Console.WriteLine("* Выполнил: Горейко Дарья Владимировна | РППб-26-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,  *");
            Console.WriteLine("* вычисляет результат по формуле √(3*x)/((x-y)в квадрате)                  *");
            Console.WriteLine("* Ответ округляет до 3 знаков после запятой                                *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            double x;

            Console.WriteLine("Введите значение x");
            x = Convert.ToDouble(Console.ReadLine());

            double y;

            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Результат для формулы = " + ds.Calculate(x, y));

            Console.ReadLine();
        }
    }
}
