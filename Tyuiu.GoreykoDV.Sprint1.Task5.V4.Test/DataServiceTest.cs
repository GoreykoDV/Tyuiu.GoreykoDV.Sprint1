using Tyuiu.GoreykoDV.Sprint1.Task5.V4.Lib;

namespace Tyuiu.GoreykoDV.Sprint1.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int k = 5000;
            int res = ds.SecondsToHours(k);

            int result = Convert.ToInt32(res);

            int wait = 1;
            Assert.AreEqual(wait, result);
        }
    }
}
