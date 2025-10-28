using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.IvanovIA.Sprint3.Task7.V24.Lib
{
    public class DataService : ISprint3Task7V24
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] result = new double[length];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                // Точная проверка деления на ноль (x = -1.2)
                if (x == -1.2)
                {
                    result[count] = 0;
                }
                else
                {
                    double fx = Math.Sin(x) / (x + 1.2) - 2 * Math.Sin(x) - 2 * x;
                    result[count] = Math.Round(fx, 2);
                }
                count++;
            }
            return result;
        }
    }
}