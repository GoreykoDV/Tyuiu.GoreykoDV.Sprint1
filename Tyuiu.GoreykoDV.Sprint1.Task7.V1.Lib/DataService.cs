using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GoreykoDV.Sprint1.Task7.V1.Lib
{
    public class DataService : ISprint1Task7V1
    {
        public double Calculate(double a, double b, double c)
        {
            double res = (b + Math.Sqrt(Math.Pow(b, 2) + 4 * a * c)) / (2 * a);
            double res1 = Math.Pow(a, 3) * c;
            double res2 = Math.Pow(b,-2);
            double z = res - res1 + res2;
            return Math.Round(z,3);
        }
    }
}
