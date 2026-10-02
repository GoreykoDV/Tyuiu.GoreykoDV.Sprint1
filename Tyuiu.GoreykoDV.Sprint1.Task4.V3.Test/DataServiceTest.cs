using Tyuiu.GoreykoDV.Sprint1.Task4.V3.Lib;

namespace Tyuiu.GoreykoDV.Sprint1.Task4.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 5;
            double wait = 0.75;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
