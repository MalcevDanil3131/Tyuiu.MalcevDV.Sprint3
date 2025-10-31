using Tyuiu.MalcevDV.Sprint3.Task4.V14.Lib;
namespace Tyuiu.MalcevDV.Sprint3.Task4.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);
            double wait = 6.263;
            Assert.AreEqual(wait, res);
        }
    }
}
