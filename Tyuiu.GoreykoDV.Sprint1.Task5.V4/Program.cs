using Tyuiu.GoreykoDV.Sprint1.Task5.V4.Lib;

namespace Tyuiu.GoreykoDV.Sprint1.Task5.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #1 | Выполнил: Горейко Д.В. | РППб-26-1";

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                               *");
            Console.WriteLine("* Задание #5                                                               *");
            Console.WriteLine("* Вариант #4                                                               *");
            Console.WriteLine("* Выполнил: Горейко Дарья Владимировна | РППб-26-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                     *");
            Console.WriteLine("* Идет k-я секунда суток.                                                  *");
            Console.WriteLine("* Определить, сколько полных часов прошло к этому моменту                  *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            int k;

            Console.WriteLine("Введите какая секунда идет");
            k = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            int res = Convert.ToInt32(ds.SecondsToHours(k));
            Console.WriteLine(res);

            Console.ReadLine();
        }
    }
}
