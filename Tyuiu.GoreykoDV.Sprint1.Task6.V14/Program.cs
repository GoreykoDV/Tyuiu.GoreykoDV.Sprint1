using Tyuiu.GoreykoDV.Sprint1.Task6.V14.Lib;

namespace Tyuiu.GoreykoDV.Sprint1.Task6.V14
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
            Console.WriteLine("* Задание #6                                                               *");
            Console.WriteLine("* Вариант #14                                                              *");
            Console.WriteLine("* Выполнил: Горейко Дарья Владимировна | РППб-26-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу: пользователь вводит текст                            *");
            Console.WriteLine("* Проверить, что строка составлена только из строчных русских букв         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
                        
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine(ds.CheckLowerCaseRusLetters(str));

            Console.ReadLine();
        }
    }
}
