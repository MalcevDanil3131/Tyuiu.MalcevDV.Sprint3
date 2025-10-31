using Tyuiu.MalcevDV.Sprint3.Task6.V24.Lib;
namespace Tyuiu.MalcevDV.Sprint3.Task6.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 17;
            int stopValue = 26;

            double wait = 41;
            double res = ds.GetSumTheDivisors(startValue, stopValue);
            Assert.AreEqual(wait, res);
        }
    }
}
