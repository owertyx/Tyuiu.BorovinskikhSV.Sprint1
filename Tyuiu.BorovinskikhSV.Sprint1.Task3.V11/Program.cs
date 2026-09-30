using Tyuiu.BorovinskikhSV.Sprint1.Task3.V11.Lib;
namespace Tyuiu.BorovinskikhSV.Sprint1.Task3.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Боровинских С.В. | СМАРТб-26-1 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Боровинских Степан Владимирович | СМАРТб-26-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
            Console.WriteLine("***************************************************************************");

            double x1;
            double y1;
            double x2;
            double y2;
            double x3;
            double y3;
            Console.WriteLine("Введите 1 координату: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2 координату: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 3 координату: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 4 координату: ");
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 5 координату: ");
            x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 6 координату: ");
            y3 = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Площадь треугольника = " + ds.TriangleArea(x1, y1, x2, y2, x3, y3).ToString("F3") + " кв.см");
        }
    }
}
