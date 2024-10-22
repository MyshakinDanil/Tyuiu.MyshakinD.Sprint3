using Tyuiu.MyshakinD.Sprint3.Task0.V19.Lib;

namespace Tyuiu.MyshakinD.Sprint3.Task0.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = 1;
            int end = 11;
            var res = ds.GetSumSeries(start, end);
            var wait = Math.Round(4.3994451365253955, 3);
            Assert.AreEqual(wait, res);
        }
    }
}