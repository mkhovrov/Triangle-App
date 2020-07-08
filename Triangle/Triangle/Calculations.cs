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
                return Radius * Radius * 3.14159265359;
            }
            else
            {
                return -1;          //-1 это код ошибки обозначающий неправильный ввод данных
            }
        }

        public static bool? TriangleCheck(float a, float b, float c) //пользуемся bool? для возможности проверки правильности ввода
        {

//=========Проверка введённых данных==========

            if ((a + b) <= c)
            {
                return null;
            }

            if ((a + c) <= b)   //null это код ошибки обозначающий неправильный ввод данных
            {
                return null;
            }

            if ((b + c) <= a)
            {
                return null;
            }
//============================================

            if (a > b) //несколькими if находим большую сторону
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
            /*                              //данная часть кода не нужна, если используем проверку TriangleCheck, где есть проверка правильности введённых данных
                if ((a + b) <= c)
                    return -1;              //-1 это код ошибки обозначающий неправильный ввод данных

                if ((a + c) <= b)
                    return -1;

                if ((b + c) <= a)
                    return -1;
            */
            float p;
            p = (a + b + c) / 2;
            return (Math.Sqrt(p * (p - a) * (p - b) * (p - c))); //вычисляет формулой Герона
        }
    }
}
