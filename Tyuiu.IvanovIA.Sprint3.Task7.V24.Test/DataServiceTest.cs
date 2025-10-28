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
            wait[0] = 9.09;
            wait[1] = 7.50;
            wait[2] = 7.53;
            wait[3] = 7.47;
            wait[4] = 5.72;
            wait[5] = -1.64;
            wait[6] = -4.16;
            wait[7] = -5.04;
            wait[8] = -5.48;
            wait[9] = -7.07;
            double[] res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}