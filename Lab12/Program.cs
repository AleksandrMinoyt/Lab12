using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Проверка статического класса для работы с окружностью");
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1 - Длина окружности");
            Console.WriteLine("2 - Площадь круга");
            Console.WriteLine("3 - Принадлежность точки кругу");
            try
            {
                int operation = Convert.ToInt32(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        CalculateLengthCircle();
                        break;
                    case 2:
                        CalculateSquareCircle();
                        break;
                    case 3:
                        CheckEntry();
                        break;
                    default: throw new Exception("Не правильный выбор операции!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка!!! " + ex.Message);
            }
            Console.ReadKey();
        }


        public static void CalculateLengthCircle()
        {
            Console.WriteLine("Расчет длины окружности по радиусу");
            Console.WriteLine("Введите радиус");
            try
            {
                double radius = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Периметр={0}", CircleMetod.Length(radius));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка!!! " + ex.Message);
            }
        }
        public static void CalculateSquareCircle()
        {
            Console.WriteLine("Расчет площади круга по радиусу");
            Console.WriteLine("Введите радиус");
            try
            {
                double radius = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Площадь={0}", CircleMetod.Square(radius));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка!!! " + ex.Message);
            }
        }
        public static void CheckEntry()
        {
            Console.WriteLine("Проверка принадлежности точки кругу по радиусу");           
            try
            {
                Console.WriteLine("Введите радиус");
                double radius = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите координату x");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите координату y");
                double y = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Точка {0} кругу",CircleMetod.CheckEntry(radius,x,y)?"принадлежит":"НЕ принадлежит" );
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка!!! " + ex.Message);
            }
        }


    }

}
