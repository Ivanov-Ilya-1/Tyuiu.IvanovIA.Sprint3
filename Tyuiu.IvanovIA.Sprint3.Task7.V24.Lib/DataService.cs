using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.IvanovIA.Sprint3.Task7.V24.Lib
{
    public class DataService : ISprint3Task7V24
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] result = new double[(stopValue - startValue + 1)];
            double fx = 0;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    continue;
                }
                if (x + 1.2 != 0)
                {
                    fx = Math.Round((Math.Sin(x) / x + 1.2) - Math.Sin(x) * 2 - 2 * x, 2);
                    result[count] = fx;
                }
                else
                {
                    result[count] = 0;
                }
                count++;
            }
            return result;
        }
    }
}
