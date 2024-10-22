using Tyuiu.MyshakinD.Sprint3.Task1.V2.Lib;

namespace Tyuiu.MyshakinD.Sprint3.Task1.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.GetSumSeries(1, 15);
            double wait = Math.Round(0.9678437396727501, 3);
            Assert.AreEqual(res, wait);
        }
    }
}