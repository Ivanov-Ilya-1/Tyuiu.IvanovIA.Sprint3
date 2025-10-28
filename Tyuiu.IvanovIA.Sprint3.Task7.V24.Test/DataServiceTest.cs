using Tyuiu.IvanovIA.Sprint3.Task7.V24.Lib;
namespace Tyuiu.IvanovIA.Sprint3.Task7.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressions()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            
            double[] wait;
            wait = new double[((stopValue - startValue) + 1)];
            wait[0] = 7.83;
            wait[1] = 6.22;
            wait[2] = 6.36;
            wait[3] = 6.96;
            wait[4] = -0.52;
            wait[5] = 0;
            wait[6] = -3.3;
            wait[7] = -5.53;
            wait[8] = -6.25;
            wait[9] = -6.63;
            wait[10] = -8.24;
            double[] res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}