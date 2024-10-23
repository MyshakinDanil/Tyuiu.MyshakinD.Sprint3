using Tyuiu.MyshakinD.Sprint3.Task6.V25.Lib;

namespace Tyuiu.MyshakinD.Sprint3.Task6.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int wait = 89;
            int res = ds.GetSumTheDivisors(16, 24);
            Assert.AreEqual(wait, res);
        }
    }
}