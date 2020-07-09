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
        public static double Circle(double Radius)
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

        public static bool TriangleCheck(float a, float b, float c)
        {

            //=========Проверка введённых данных==========

            if ((a <= 0) || (b <= 0) || (c <= 0))
                throw new ArgumentException("Sides should be > 0");

            if (((a + b) <= c) || ((a + c) <= b) || ((b + c) <= a))
                throw new ArgumentException("Not a triangle");

            //============================================

            if (a > b) //несколькими if находим большую сторону (гипотенузу)
            {
                if (a > c)
                {
                    if ((a * a) == (b * b) + (c * c)) return true;  //по теореме Пифагора проверяем, является ли треугольник прямоугольным
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
            }                                                       //не использовал поиск циклом для уменьшения затрат памяти
            return false;
        }
    
        public static double Triangle(float a, float b, float c)
        {

            //=========Проверка введённых данных==========

            if ((a <= 0) || (b <= 0) || (c <= 0))
                throw new ArgumentException("Sides should be > 0");

            if (((a + b) <= c) || ((a + c) <= b) || ((b + c) <= a))
                throw new ArgumentException("Not a triangle");

            //============================================

            float p;
            p = (a + b + c) / 2;
            return (Math.Sqrt(p * (p - a) * (p - b) * (p - c)));    //вычисляет формулой Герона
        }
    }
}
