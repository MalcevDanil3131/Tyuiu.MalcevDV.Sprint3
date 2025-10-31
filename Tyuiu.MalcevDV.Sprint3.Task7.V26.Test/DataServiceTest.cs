using Tyuiu.MalcevDV.Sprint3.Task7.V26.Lib;
namespace Tyuiu.MalcevDV.Sprint3.Task7.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ds = new DataService();
            int startValue = -5; int endValue = 5;
            int len = endValue - startValue + 1;
            double[] valueWaitArray = new double[len];
            valueWaitArray[0] = 19.81;
            valueWaitArray[1] = 16.79;
            valueWaitArray[2] = 13.87;
            valueWaitArray[3] = 10.98;
            valueWaitArray[4] = 7.94;
            valueWaitArray[5] = 3.00;
            valueWaitArray[6] = 3.23;
            valueWaitArray[7] = -0.45;
            valueWaitArray[8] = -3.79;
            valueWaitArray[9] = -6.97;
            valueWaitArray[10] = -10.00;
            double[] res = new double[len];
            res = ds.GetMassFunction(startValue, endValue);
            CollectionAssert.AreEqual(valueWaitArray, res);

        }
    }
}
