using Tyuiu.IvanovIA.Sprint3.Task1.V7.Lib;
namespace Tyuiu.IvanovIA.Sprint3.Task1.V7
{

    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();



            Console.Title = "Спринт #3 | Выполнил: Иванов И. А. | ИИПБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Спринт #3                                                                *");
            Console.WriteLine(" Тема : Оператор цикла while                                              *");
            Console.WriteLine(" Задание #0                                                               *");
            Console.WriteLine(" Вариант #11                                                              *");
            Console.WriteLine(" Выполнил : Иванов Илья Анатольевич | ИИПБ-25-1                           *");
            Console.WriteLine(" Спринт #3                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" УСЛОВИЕ:                                                                 *");
            Console.WriteLine(" Написать программу используя цикл while, которая вычисляет произведение  *");
            Console.WriteLine(" ряда по формуле, при a=0,25                                              *");
            Console.WriteLine(" *                                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            double value = 0.25;
            int startvalue = 1;
            int stopvalue = 9;

            Console.WriteLine("Переменная a =  " + value);
            Console.WriteLine("Старт шага =  " + startvalue);
            Console.WriteLine("Конец шага =  " + stopvalue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Произведение ряда = " + ds.GetMultiplySeries(value, startvalue, stopvalue));

            Console.ReadKey();


        }
    }
}