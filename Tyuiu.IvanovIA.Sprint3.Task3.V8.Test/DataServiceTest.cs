using Tyuiu.IvanovIA.Sprint3.Task3.V8.Lib;
namespace Tyuiu.IvanovIA.Sprint3.Task3.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "vc,x12fc fc!e";

            int res = 12;
            int wait = ds.ConvertStringToInt(str);
            Assert.AreEqual(res, wait);

        }
    }
}
