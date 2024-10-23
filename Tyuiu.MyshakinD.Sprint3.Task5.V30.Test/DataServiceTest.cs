using Tyuiu.MyshakinD.Sprint3.Task5.V30.Lib;

namespace Tyuiu.MyshakinD.Sprint3.Task5.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var wait = 132;
            var res = ds.GetSumSumSeries(2, 1, 1, 3, 11);
            Assert.AreEqual(wait, res);
        }
    }
}