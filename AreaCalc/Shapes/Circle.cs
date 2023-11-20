using System;
using AreaCalc.Interface;

namespace AreaCalc.Shapes
{
    public class Circle : IShape
    {
        public double Radius { get; set; }

        /// <summary>
        /// Круг
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        public Circle(double radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// Проверка существования круга
        /// </summary>
        public bool IsExists()
        {
            if (Radius <= 0)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Вычисленеие площади круга
        /// </summary>
        public double CalcArea()
        {
            if (!IsExists())
            {
                return 0;
            }

            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}