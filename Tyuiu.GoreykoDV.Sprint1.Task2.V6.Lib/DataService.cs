using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GoreykoDV.Sprint1.Task2.V6.Lib
{
    public class DataService : ISprint1Task2V6
    {
        public double ConvertMToKm(int value)
        {
            return Math.Round((double)value / 1000, 3);
        }
    }
}
