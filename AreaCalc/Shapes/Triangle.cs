using System;
using AreaCalc.Interface;

namespace AreaCalc.Shapes
{
    public class Triangle : IShape
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        /// <summary>
        /// Треугольник
        /// </summary>
        /// <param name="side1">Длина первой стороны треугольника</param>
        /// <param name="side2">Длина второй стороны треугольника</param>
        /// <param name="side3">Длина третьей стороны треугольника</param>
        public Triangle(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }


        /// <summary>
        /// Проверка существования треугольника
        /// </summary>
        public bool IsExists()
        {
            if (Side1 <= 0 || Side2 <= 0 || Side3 <= 0)
            {
                return false;
            }

            return !(Side1 + Side2 <= Side3 || Side1 + Side3 <= Side2 || Side2 + Side3 <= Side1);
        }

        /// <summary>
        /// Проверка, является ли треугольник прямоугольным
        /// </summary>
        public bool IsRight()
        {
            if (!IsExists())
            {
                return false;
            }

            return (Math.Pow(Side1, 2) == Math.Pow(Side2, 2) + Math.Pow(Side3, 2) || Math.Pow(Side2, 2) == Math.Pow(Side1, 2) + Math.Pow(Side3, 2) || Math.Pow(Side3, 2) == Math.Pow(Side1, 2) + Math.Pow(Side2, 2));
        }

        /// <summary>
        /// Вычисленеие площади треугольника
        /// </summary>
        public double CalcArea()
        {

            if (!IsExists())
            {
                return 0;
            }

            var perimeter = (Side1 + Side2 + Side3) * 0.5;

            return Math.Sqrt(perimeter * (perimeter - Side1) * (perimeter - Side2) * (perimeter - Side3));
        }
    }
}

