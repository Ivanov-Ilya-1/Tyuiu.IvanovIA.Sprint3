using Tyuiu.IvanovIA.Sprint3.Task0.V11.Lib;
namespace Tyuiu.IvanovIA.Sprint3.Task0.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 5;
            int startvalue = 1;
            int stopvalue = 10;

            double wait = 0.042;
            double res = ds.GetSumSeries(value, startvalue, stopvalue);

            Assert.AreEqual(wait,res);



        }
    }
}
