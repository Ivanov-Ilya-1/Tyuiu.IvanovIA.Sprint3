using Tyuiu.IvanovIA.Sprint3.Task6.V30.Lib;
namespace Tyuiu.IvanovIA.Sprint3.Task6.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 25;
            int startvalue1 = 11;
            int stopvalue1 = 17;
            

            int res = ds.GetSumTheDivisors(startvalue1, stopvalue1);

            Assert.AreEqual(value, res);
        }
    }
}
