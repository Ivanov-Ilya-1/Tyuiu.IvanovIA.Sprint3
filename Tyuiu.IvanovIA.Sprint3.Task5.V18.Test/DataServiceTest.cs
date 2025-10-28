using Tyuiu.IvanovIA.Sprint3.Task5.V18.Lib;
namespace Tyuiu.IvanovIA.Sprint3.Task5.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 5;
            int startvalue1 = 1;
            int stopvalue1 = 3;
            int startvalue2 = 1;
            int stopvalue2 = 11;

            double wait = 768.36;
            double res = ds.GetSumSumSeries(value, startvalue1, startvalue2, stopvalue1, stopvalue2);

            Assert.AreEqual(wait, res);
        }
    }
}
