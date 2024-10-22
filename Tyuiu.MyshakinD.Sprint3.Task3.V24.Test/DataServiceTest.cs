using Tyuiu.MyshakinD.Sprint3.Task3.V24.Lib;

namespace Tyuiu.MyshakinD.Sprint3.Task3.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string wait = "*ft h**t nt*";
            string value = "gft hggt ntg";
            char replaceable = 'g';
            char replacement = '*';
            string res = ds.ReplaceCharInString(value, replaceable, replacement);
        }
    }
}