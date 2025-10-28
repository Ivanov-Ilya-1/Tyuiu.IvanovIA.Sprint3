using Tyuiu.IvanovIA.Sprint3.Task5.V18.Lib;
namespace Tyuiu.IvanovIA.Sprint3.Task5.V18
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
            Console.WriteLine(" Задание #4                                                               *");
            Console.WriteLine(" Вариант #16                                                               *");
            Console.WriteLine(" Выполнил : Иванов Илья Анатольевич | ИИПБ-25-1                           *");
            Console.WriteLine(" Спринт #3                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" УСЛОВИЕ:                                                                 *");
            Console.WriteLine(" Используя цикл foreach удалить все буквы и знаки препинания,оставить цифр*");
            Console.WriteLine(" затем преобразовать в число в строке: vc,x12fc fc!e                      *");
            Console.WriteLine(" *                                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            int value = 5;
            int startvalue1 = 1;
            int stopvalue1 = 3;
            int startvalue2 = 1;
            int stopvalue2 = 11;



            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Сумма = " +  ds.GetSumSumSeries(value, startvalue1, startvalue2, stopvalue1, stopvalue2));

            Console.ReadKey();


        }
    }
}