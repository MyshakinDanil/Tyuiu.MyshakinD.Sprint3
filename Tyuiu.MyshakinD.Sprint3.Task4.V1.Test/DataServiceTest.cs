using Tyuiu.MyshakinD.Sprint3.Task4.V1.Lib;

namespace Tyuiu.MyshakinD.Sprint3.Task4.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double wait = 0.962;
            double res = ds.Calculate(-5, 6);
            Assert.AreEqual(wait, res);
        }
    }
}