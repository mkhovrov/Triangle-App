using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using Calculations;

namespace Triangle_App //приложение для проверки работоспособности библиотеки
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write number of sides: 1) Circle; 2) TriangleCheck; 3) Triangle \n");
            int NumberOfSides = Convert.ToInt32(Console.ReadLine());    //приём количества сторон

            if ((NumberOfSides == 1))   //проверка работоспособности функции Circle
            {
                Console.Write("\nRadius: ");
                Console.WriteLine(FigureType.Circle(Convert.ToDouble(Console.ReadLine())));
            }  //приём с консоли радиуса, конвертирование её в числовое значение и нахождение её площади вызовом функции Circle


            if (NumberOfSides == 2)     //проверка работоспособности функции TriangleCheck
            {
                Console.Write("\nWrite down 3 sides of triangle you want to check");
                double[] a = new double[3];
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("\nSide ");
                    Console.Write(i + 1);
                    Console.Write(": ");
                    a[i] = Convert.ToDouble(Console.ReadLine()); //приём данных в массив
                }

                Console.WriteLine();
                Console.WriteLine(FigureType.TriangleCheck(a[0], a[1], a[2]));
            }


            if ((NumberOfSides == 3))   //проверка работоспособности функции Triangle
            {
                Console.Write("\nWrite down below values of 3 sides of the triangle to know his area");

                double[] a = new double[3];
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("\nSide ");
                    Console.Write(i + 1);
                    Console.Write(": ");
                    a[i] = Convert.ToDouble(Console.ReadLine()); //приём данных в массив
                }

                Console.Write("\nArea of triangle: ");
                Console.Write(Convert.ToDouble(FigureType.Triangle(a[0], a[1], a[2])));
                
            }

            if ((NumberOfSides > 3))
            {
                Console.WriteLine("Too many sides. Yet.");
            }

            Console.ReadKey();
        }
    }
}
