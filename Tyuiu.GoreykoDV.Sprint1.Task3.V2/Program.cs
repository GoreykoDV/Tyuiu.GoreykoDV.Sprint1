using Tyuiu.GoreykoDV.Sprint1.Task3.V2.Lib;

namespace Tyuiu.GoreykoDV.Sprint1.Task3.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #1 | Выполнил: Горейко Д.В. | РППб-26-1";

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                      *");
            Console.WriteLine("* Задание #3                                                               *");
            Console.WriteLine("* Вариант #2                                                               *");
            Console.WriteLine("* Выполнил: Горейко Дарья Владимировна | РППб-26-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,  *");
            Console.WriteLine("* вычисления стоимости покупки, состоящей из нескольких тетрадей           *");
            Console.WriteLine("* и карандашей Ответ округляет до 3 знаков после запятой                   *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            double pricex;

            Console.WriteLine("Введите стоимость тетради");
            pricex = Convert.ToDouble(Console.ReadLine());
            
            int x;

            Console.WriteLine("Введите кол-во тетрадей");
            x = Convert.ToInt32(Console.ReadLine());

            double pricey;

            Console.WriteLine("Введите стоимость карандашей");
            pricey = Convert.ToDouble(Console.ReadLine());

            int y;

            Console.WriteLine("Введите кол-во карандашей");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Стоимость покупки =  " + ds.PurchaseAmount(pricex, x, pricey, y) + " рублей");

            Console.ReadLine();
        }
    }
}
