using Tyuiu.IvanovIA.Sprint3.Task4.V16.Lib;
namespace Tyuiu.IvanovIA.Sprint3.Task4.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = -5;
            int b = 5;

            double res = 6.719;
            double wait = ds.Calculate(a,b);
            Assert.AreEqual(res, wait);

        }
    }
}

