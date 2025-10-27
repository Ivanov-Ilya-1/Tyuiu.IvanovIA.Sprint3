using Tyuiu.IvanovIA.Sprint3.Task2.V10.Lib;
namespace Tyuiu.IvanovIA.Sprint3.Task2.V10
{

    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();



            Console.Title = "Спринт #3 | Выполнил: Иванов И. А. | ИИПБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Спринт #3                                                                *");
            Console.WriteLine(" Тема : Оператор цикла d0...while                                         *");
            Console.WriteLine(" Задание #2                                                               *");
            Console.WriteLine(" Вариант #10                                                              *");
            Console.WriteLine(" Выполнил : Иванов Илья Анатольевич | ИИПБ-25-1                           *");
            Console.WriteLine(" Спринт #3                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" УСЛОВИЕ:                                                                 *");
            Console.WriteLine(" Написать программу используя цикл dowhile, которая вычисляет произведение*");
            Console.WriteLine(" ряда по формуле, при t=1                                                 *");
            Console.WriteLine(" *                                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            int value = 1;
            int startvalue = 1;
            int stopvalue = 13;

            Console.WriteLine("Переменная t =  " + value);
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