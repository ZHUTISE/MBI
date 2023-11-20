using System;
using AreaCalc.Shapes;

namespace AreaCalc.Tests
{
	[TestClass]
	public class AreaCalcCircleTests
	{
        [TestMethod]
        public void AreaCalc_IsExists_circle_radius_0_return_false()
        {
            //arrange
            double radius = 0.0;
            bool expected = false;
            //act
            var cir = new Circle(radius);
            bool actual = cir.IsExists();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AreaCalc_IsExists_circle_radius_minus1p1_return_false()
        {
            //arrange
            double radius = -1.1;
            bool expected = false;
            //act
            var cir = new Circle(radius);
            bool actual = cir.IsExists();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AreaCalc_circle_radius_0_return_0()
        {
            //arrange
            double radius = 0.0;
            double expected = 0.0;
            //act
            var cir = new Circle(radius);
            double actual = cir.CalcArea();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AreaCalc_circle_radius_minus1p1_return_0()
        {
            //arrange
            double radius = -1.1;
            double expected = 0.0;
            //act
            var cir = new Circle(radius);
            double actual = cir.CalcArea();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AreaCalc_circle_radius_3p1_return_30p19()
        {
            //arrange
            double radius = 3.1;
            double expected = 30.19;
            double delta = 0.01;
            //act
            var cir = new Circle(radius);
            double actual = cir.CalcArea();

            //assert
            Assert.AreEqual(expected, actual, delta);
        }
    }
}

