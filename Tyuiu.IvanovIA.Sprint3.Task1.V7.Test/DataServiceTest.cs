using Tyuiu.IvanovIA.Sprint3.Task1.V7.Lib;
namespace Tyuiu.IvanovIA.Sprint3.Task1.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double value = 0.25;
            int startvalue = 1;
            int stopvalue = 9;

            double wait = -0.93;
            double res = ds.GetMultiplySeries(value, startvalue, stopvalue);

            Assert.AreEqual(wait, res);
        }
    }
}
