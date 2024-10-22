using System.Security.Cryptography.X509Certificates;
using Tyuiu.MyshakinD.Sprint3.Task2.V1.Lib;

namespace Tyuiu.MyshakinD.Sprint3.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double wait = Math.Round(0.48880237052684505, 3);
            int x = 1; int y = 10;
            double res = ds.GetSumSeries(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}