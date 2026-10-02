using Tyuiu.GoreykoDV.Sprint1.Task3.V2.Lib;

namespace Tyuiu.GoreykoDV.Sprint1.Task3.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double pricex = 15.5;
            int x = 5;
            double pricey = 5;
            int y = 10;
            double wait = 127.5;
            var res = ds.PurchaseAmount(pricex, x, pricey, y);
            Assert.AreEqual(wait, res);



        }
    }
}
