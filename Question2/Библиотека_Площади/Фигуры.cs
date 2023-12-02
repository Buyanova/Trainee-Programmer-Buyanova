namespace Библиотека_Площади
{
    public class Фигуры
    {
        // Круг
        private double r; // радиус
        public double R
        {
            get { return r; }
            set { r = value; }
        }
        /// <summary>
        /// Площадь круга
        /// </summary>
        /// <returns></returns>
        public double CircleArea()
        {
            return Math.PI * (r * r);
        }

        // Треугольник
        
        // Стороны треугольника: 
        private double a; 
        private double b;
        private double c;

        public double A
        {
            get { return a; }
            set { a = value; }
        }
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public double C
        {
            get { return c; }
            set { c = value; }
        }

        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        /// <returns></returns>
        public bool Rectangular()
        {
            //int ab = Math.Pow(a)
            if(a<c && b<c)
            {
                if (a * a + b * b == c * c)
                    return true;
                else
                    return false;
            }
            else
                if (c<a && b<a)
            {
                if (c * c + b * b == a * a)
                    return true;
                else
                    return false;

            }
            if (a < b && c < b)
            {
                if (a * a + c * c == b * b)
                    return true;
                else
                    return false;
            }
            return false;
        }
        /// <summary>
        /// Площадь треугольника
        /// </summary>
        /// <returns></returns>
        public double TriangleArea()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}