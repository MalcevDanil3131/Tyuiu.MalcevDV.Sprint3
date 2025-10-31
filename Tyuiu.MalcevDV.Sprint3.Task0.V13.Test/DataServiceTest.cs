using Tyuiu.MalcevDV.Sprint3.Task0.V13.Lib;

namespace Tyuiu.MalcevDV.Sprint3.Task0.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Checkvalid()
        {
            DataService ds = new DataService();

            double value = 0.5;
            int startValue = 1;
            int stopValue = 20;

            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 0.298;
            Assert.AreEqual(wait, res);
        }
    }
}
