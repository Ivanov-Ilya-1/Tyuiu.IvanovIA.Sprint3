using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.IvanovIA.Sprint3.Task4.V16.Lib
{
    public class DataService : ISprint3Task4V16
    {
        public double Calculate(int startValue, int stopValue)
        {
            int x;
            double sp = 1;
            int i = 0;
            for (x = startValue; x <= stopValue; x++) 
            {
                if (x == 0)
                {
                    continue;
                }
                sp *= ((Math.Cos(x) + x) / x) + 0.25;
                i++;

            }
            return Math.Round(sp,3);



        }
    }
}
