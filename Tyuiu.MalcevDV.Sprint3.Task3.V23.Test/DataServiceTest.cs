using Tyuiu.MalcevDV.Sprint3.Task3.V23.Lib;
namespace Tyuiu.MalcevDV.Sprint3.Task3.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value = "fdsst siu vsrs";
            char replaceable = 's';
            char replacement = '8';
            var res = ds.ReplaceCharOnNum(value, replaceable, replacement);
            string wait = "fd88t 8iu v8r8";
            Assert.AreEqual(wait, res);

        }
    }
}
