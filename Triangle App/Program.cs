using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using Calculations;

namespace Triangle_App
{
    class Program
    {
        static void Main(string[] args)
        {
            string receivedString = Console.ReadLine();
            int NumberOfSides = Convert.ToInt32(receivedString);    //приём количества сторон


            if ((NumberOfSides > 8))
            {
                
                Console.WriteLine("Too many sides. Yet.");
                Console.ReadKey();
                return;
            }

            if (NumberOfSides == 2)         //при вводе 2, можно выполнить проверку треугольника на прямоугольность
            {
                int[] a = new int[3];                     //создание массива для длин сторон проверяемого треугольника
                for (int i = 0; i < 3; i++)
                {
                    a[i] = Convert.ToInt32(Console.ReadLine());
                }

                bool? result = FigureType.TriangleCheck(a[0], a[1], a[2]);
                if (result != true)
                {
                    if (result != false)
                    {
                        Console.WriteLine("error");
                    } else Console.WriteLine("false");
                } else Console.WriteLine("true");
            }


            if ((NumberOfSides == 1))
            {
                Console.WriteLine(FigureType.Circle(Convert.ToDouble(Console.ReadLine())));
            }   //это я так круто в одну строку уместил вызов метода нахождения площади круга через радиус вводимый с консоли, с поправкой на преобразование типа вводимой строки в число

            if ((NumberOfSides == 3)) 
            {
                int[] a = new int[NumberOfSides];                        //создание массива для длин сторон фигуры
                for (int i = 0; i < 3; i++)                              //ввод длин трёх сторон треугольника
                {
                    a[i] = Convert.ToInt32(Console.ReadLine());
                }

                if (FigureType.TriangleCheck(a[0], a[1], a[2]) != null)  //с помощью TriangleCheck проверяем на "не ошибочность" введённых данных
                {
                    double result = FigureType.Triangle(a[0], a[1], a[2]);
                    Console.WriteLine(result);
                } 
                else Console.WriteLine("error");


            }

            Console.ReadKey();
        }
    }
}
