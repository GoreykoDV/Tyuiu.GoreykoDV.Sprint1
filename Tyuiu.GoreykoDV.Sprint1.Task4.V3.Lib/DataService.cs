using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GoreykoDV.Sprint1.Task4.V3.Lib
{
    public class DataService : ISprint1Task4V3
    {
        public double Calculate(double x, double y)
        {
            var res = Math.Round((double) Math.Sqrt(3 * x) / Math.Pow((x - y), 2),3);
            return res;
        }
    }
}
