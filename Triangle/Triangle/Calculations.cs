using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    public static class FigureType
    {
        public static double Circle(double Radius)                      //высчитывает площадь круга через её радиус
        {
            if (Radius > 0)
            {
                return Radius * Radius * Math.PI;
            }
            else
            {
                throw new ArgumentException("Radius should be > 0");
            }
        }

        public static bool TriangleCheck(double a, double b, double c)     //проверка прямоугольности треугольника
        {

            //=========Проверка введённых данных==========

            if ((a <= 0) || (b <= 0) || (c <= 0))
                throw new ArgumentException("Sides should be > 0");

            if (((a + b) <= c) || ((a + c) <= b) || ((b + c) <= a))
                throw new ArgumentException("Not a triangle");

            //============================================

            if (a > b) //древом if находим большую сторону (гипотенузу) и проверяем, работает ли теорема Пифагора
            {
                if (a > c)
                {
                    if ((a * a) == (b * b) + (c * c)) return true;
                }
                else
                {
                    if ((c * c) == (b * b) + (a * a)) return true;
                }
            }
            else
            {
                if (c < b)
                {
                    if ((b * b) == (a * a) + (c * c)) return true;
                }
                else
                {
                    if ((c * c) == (a * a) + (b * b)) return true;
                }
            }       //не использовал поиск циклом для уменьшения затрат памяти

            return false;
        }
    
        public static double Triangle(double a, double b, double c)
        {

            //=========Проверка введённых данных==========

            if ((a <= 0) || (b <= 0) || (c <= 0))
                throw new ArgumentException("Sides should be > 0");

            if (((a + b) <= c) || ((a + c) <= b) || ((b + c) <= a))
                throw new ArgumentException("Not a triangle");

            //============================================

            //вычисляем формулой Герона
            return (Math.Sqrt(((a + b + c) / 2) * (((a + b + c) / 2) - a) * (((a + b + c) / 2) - b) * (((a + b + c) / 2) - c)));        
        }
    }
}
