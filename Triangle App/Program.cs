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


            if ((NumberOfSides > 3))
            {
                Console.WriteLine("Too many sides. Yet.");
            }

            if (NumberOfSides == 2)         //при вводе 2, можно выполнить проверку треугольника на прямоугольность
            {
                int[] a = new int[3];                     //создание массива для длин сторон проверяемого треугольника
                for (int i = 0; i < 3; i++)
                {
                    a[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine(FigureType.TriangleCheck(a[0], a[1], a[2]));

            }


            if ((NumberOfSides == 1)) //проверка работоспособности функции Circle
            {
                Console.WriteLine(FigureType.Circle(Convert.ToDouble(Console.ReadLine())));
            }  //приём с консоли радиуса конвертирование её в числовое значение и нахождение её площади вызовом функции Circle


            if ((NumberOfSides == 3)) //проверка работоспособности функции Triangle
            {
                int[] a = new int[NumberOfSides];                        
                for (int i = 0; i < 3; i++)                              
                {
                    a[i] = Convert.ToInt32(Console.ReadLine()); //приём данных в массив
                }

                double result = FigureType.Triangle(a[0], a[1], a[2]);
                Console.WriteLine(result);
                
            }

            Console.ReadKey();
        }
    }
}
