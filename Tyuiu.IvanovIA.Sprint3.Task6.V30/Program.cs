using Tyuiu.IvanovIA.Sprint3.Task6.V30.Lib;
namespace Tyuiu.IvanovIA.Sprint3.Task6.V30
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

            
            int startvalue1 = 11;
            int stopvalue1 = 17;
            



            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Количество = " + ds.GetSumTheDivisors(startvalue1,stopvalue1));

            Console.ReadKey();


        }
    }
}