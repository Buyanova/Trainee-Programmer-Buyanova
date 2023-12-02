using Библиотека_Площади;

namespace Юнит_тесты_Площади
{
    [TestClass]
    public class UnitTest1
    {
        Фигуры f = new Фигуры();

        /// <summary>
        /// Проверка на правильный подсчет площади круга
        /// </summary>
        [TestMethod]
        
        public void CircleArea()
        {
            f.R = 4.5;
            Assert.AreEqual(Math.Round(f.CircleArea(), 4), 63.6173);
        }

        /// <summary>
        /// Треугольник не является прямоугольным при условии, что одна сторона должна быть больше 2-х других
        /// </summary>
        [TestMethod]
        public void NotRectangular()
        {
            f.A = 2;
            f.B = 14;
            f.C = 5;

            Assert.IsFalse(f.Rectangular());
        }

        /// <summary>
        /// Треугольник не является прямоугольным при условии, что стороны одинаковы
        /// </summary>
        [TestMethod]
        public void EquelNOtRectangular()
        {
            f.A = 6;
            f.B = 6;
            f.C = 6;

            Assert.IsFalse(f.Rectangular());
        }

        /// <summary>
        /// Треугольник является прямоугольным
        /// </summary>
        [TestMethod]
        public void Rectangular()
        {
            f.A = 5;
            f.B = 3;
            f.C = 4;

            Assert.IsTrue(f.Rectangular());
        }

        /// <summary>
        /// Проверка на правильный подсчет площади треугольника
        /// </summary>
        [TestMethod]
        public void TriangleArea()
        {
            f.A = 6;
            f.B = 8;
            f.C = 13.2;

            Assert.AreEqual(f.CircleArea(), Math.Round(15.21599), 15);
        }
    }
}