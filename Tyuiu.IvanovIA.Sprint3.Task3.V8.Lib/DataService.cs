using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.IvanovIA.Sprint3.Task3.V8.Lib
{
    public class DataService : ISprint3Task3V8
    {
        public int ConvertStringToInt(string value)
        {
            string result = "";
            foreach (char c in value)
            {
                
                if (char.IsDigit(c))
                {
                    result += c;
                }
            }
            int nuber = Int32.Parse(result);
            return nuber;
        }
    }
}
