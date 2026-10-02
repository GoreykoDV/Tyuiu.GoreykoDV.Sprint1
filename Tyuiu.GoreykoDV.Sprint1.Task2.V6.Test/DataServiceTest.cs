using Newtonsoft.Json.Linq;
using Tyuiu.GoreykoDV.Sprint1.Task2.V6.Lib;

namespace Tyuiu.GoreykoDV.Sprint1.Task2.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 3;
            var res =ds.ConvertMToKm(x);
            Assert.AreEqual(0.003,res);
        }
    }
}
