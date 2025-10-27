using Tyuiu.IvanovIA.Sprint3.Task0.V11.Lib;
namespace Tyuiu.IvanovIA.Sprint3.Task0.V11
{

    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();



            Console.Title = "Спринт #3 | Выполнил: Иванов И. А. | ИИПБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Спринт #3                                                                *");
            Console.WriteLine(" Тема : Оператор цикла for                                                *");
            Console.WriteLine(" Задание #0                                                               *");
            Console.WriteLine(" Вариант #11                                                              *");
            Console.WriteLine(" Выполнил : Иванов Илья Анатольевич | ИИПБ-25-1                           *");
            Console.WriteLine(" Спринт #3                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" УСЛОВИЕ:                                                                 *");
            Console.WriteLine(" Написать программу используя цикл for, которая вычисляет сумму           *");
            Console.WriteLine(" ряда по формуле, при n = 5                                               *");
            Console.WriteLine(" *                                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            int value = 5;
            int startvalue = 1;
            int stopvalue = 10;

            Console.WriteLine("Переменная n =  " + value);
            Console.WriteLine("Старт шага =  " + startvalue);
            Console.WriteLine("Конец шага =  " + stopvalue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(value, startvalue, stopvalue));

            Console.ReadKey();


        }
    }
}