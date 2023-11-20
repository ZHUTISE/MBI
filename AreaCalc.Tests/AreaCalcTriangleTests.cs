using System;
using AreaCalc.Shapes;

namespace AreaCalc.Tests
{
	[TestClass]
	public class AreaCalcTriangleTests
	{
        [TestMethod]
        public void AreaCalc_IsExists_Triangle_abc_1_2_3_return_false()
        {
            //arrange
            double s1 = 1.0;
            double s2 = 2.0;
            double s3 = 3.0;
            bool expected = false;
            //act
            var tri = new Triangle(s1, s2, s3);
            bool actual = tri.IsExists();

            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void AreaCal_IsExistsc_Triangle_abc_1_minus4_4p4_return_false()
        {
            //arrange
            double s1 = 1.0;
            double s2 = -4.0;
            double s3 = 4.4;
            bool expected = false;

            //act
            var tri = new Triangle(s1, s2, s3);
            bool actual = tri.IsExists();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
		public void AreaCalc_Triangle_abc_1_2_3_return_0()
		{
            //arrange
            double s1 = 1.0;
            double s2 = 2.0;
            double s3 = 3.0;
            double expected = 0.0;
            //act
            var tri = new Triangle(s1, s2, s3);
            double actual = tri.CalcArea();

            //assert
            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        public void AreaCalc_Triangle_abc_1_minus4_4p4_return_0()
        {
            //arrange
            double s1 = 1.0;
            double s2 = -4.0;
            double s3 = 4.4;
            double expected = 0.0;

            //act
            var tri = new Triangle(s1, s2, s3);
            double actual = tri.CalcArea();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AreaCalc_Triangle_abc_1_4_4p4_return_1p91()
        {
            //arrange
            double s1 = 1.0;
            double s2 = 4.0;
            double s3 = 4.4;
            double expected = 1.91;
            double delta = 0.01;

            //act
            var tri = new Triangle(s1, s2, s3);
            double actual = tri.CalcArea();

            //assert
            Assert.AreEqual(expected, actual, delta);
        }

        [TestMethod]
        public void AreaCalc_IsRight_Triangle_abc_1_4_4p4_return_false()
        {
            //arrange
            double s1 = 1.0;
            double s2 = 4.0;
            double s3 = 4.4;
            bool expected = false;

            //act
            var tri = new Triangle(s1, s2, s3);
            bool actual = tri.IsRight();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AreaCalc_IsRight_Triangle_abc_6_8_10_return_true()
        {
            //arrange
            double s1 = 6.0;
            double s2 = 8.0;
            double s3 = 10.0;
            bool expected = true;

            //act
            var tri = new Triangle(s1, s2, s3);
            bool actual = tri.IsRight();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}

