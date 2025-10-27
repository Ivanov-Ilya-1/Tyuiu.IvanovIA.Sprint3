using Tyuiu.IvanovIA.Sprint3.Task3.V8.Lib;
namespace Tyuiu.IvanovIA.Sprint3.Task3.V8
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
            Console.WriteLine(" Задание #3                                                               *");
            Console.WriteLine(" Вариант #8                                                               *");
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

            string str = "vc,x12fc fc!e";

            Console.WriteLine("Строка =   " + str);
            

            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Число = " + ds.ConvertStringToInt(str));

            Console.ReadKey();


        }
    }
}