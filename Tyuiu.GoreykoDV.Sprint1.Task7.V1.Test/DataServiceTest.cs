using Tyuiu.GoreykoDV.Sprint1.Task7.V1.Lib;

namespace Tyuiu.GoreykoDV.Sprint1.Task7.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double b = 1;
            double c = 2;
            double a = 2;
            double wait = -13.719;
            var res = ds.Calculate(a, b, c);
            Assert.AreEqual(wait, res);
        }
    }
}
