using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculations;

namespace UnitTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void CalculateArea_Sides3_4_5_return6()
        {
            //arrange
            int a = 3;
            int b = 4;
            int c = 5;

            int expected = 6;

            //act
            double actual = Calculations.FigureType.Triangle(a, b, c);

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void CheckRectangularity_Sides5_12_13_returnTrue()
        {
            //arrange
            int a = 5;
            int b = 12;
            int c = 13;

            bool? expected = true;

            //act
            bool? actual = Calculations.FigureType.TriangleCheck(a, b, c);

            //assert
            Assert.AreEqual(expected, actual);

        } //тест на проверку прямугольности треугольника

        [TestMethod]
        public void CheckRectangularity_Sides1_1_100_returnNULL()
        {
            //arrange
            int a = 1;
            int b = 1;
            int c = 100;

            bool? expected = null;

            //act
            bool? actual = Calculations.FigureType.TriangleCheck(a, b, c);

            //assert
            Assert.AreEqual(expected, actual);

        } //тест на проверку прямугольности треугольника
    }

    [TestClass]
    public class CircleAreaTests
    {
        [TestMethod]
        public void CalculateAreaOfCircle_Rad5_78point54return()
        {
            //arrange
            int rad = 5;
            double expected = 78.53981633975;

            //act
            double actual = Calculations.FigureType.Circle(rad);

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void CalculateAreaOfCircle_Rad0_returnMinus1()
        {
            //arrange
            int rad = 0;
            double expected = -1;

            //act
            double actual = Calculations.FigureType.Circle(rad);

            //assert
            Assert.AreEqual(expected, actual);

        } //тест кода ошибки вводных данных
    }
}
