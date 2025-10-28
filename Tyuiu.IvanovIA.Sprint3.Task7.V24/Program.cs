using Tyuiu.IvanovIA.Sprint3.Task7.V24.Lib;
namespace Tyuiu.IvanovIA.Sprint3.Task7.V24
{

    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();



            Console.Title = "Спринт #3 | Выполнил: Иванов И. А. | ИИПБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Спринт #3                                                                *");
            Console.WriteLine(" Тема : Оператор цикла foreach                                            *");
            Console.WriteLine(" Задание #7                                                               *");
            Console.WriteLine(" Вариант #24                                                               *");
            Console.WriteLine(" Выполнил : Иванов Илья Анатольевич | ИИПБ-25-1                           *");
            Console.WriteLine(" Спринт #3                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции.           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;
            double[] res = ds.GetMassFunction(startValue, stopValue);
            Console.WriteLine("* Начало отрезка = " + startValue);
            Console.WriteLine("* Конец отрезка = " + stopValue);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+---------+---------+");
            Console.WriteLine("|    X    |   f(x)  |");
            Console.WriteLine("+---------+---------+");
            for (int i = 0; i <= res.Length - 1; i++)
            {
                Console.WriteLine("|{0,7:d}  | {1,7:f2} |", startValue, res[i]);
                startValue++;
            }
            Console.WriteLine("+---------+---------+");
        }
    }
}