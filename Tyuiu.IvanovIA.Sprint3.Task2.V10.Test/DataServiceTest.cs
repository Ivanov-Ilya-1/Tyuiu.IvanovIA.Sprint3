using Tyuiu.IvanovIA.Sprint3.Task2.V10.Lib;
namespace Tyuiu.IvanovIA.Sprint3.Task2.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 1;
            int startvalue = 1;
            int stopvalue = 13;

            double wait = 1;
            double res = ds.GetMultiplySeries(value, startvalue, stopvalue);

            Assert.AreEqual(wait, res);
        }
    }
}
