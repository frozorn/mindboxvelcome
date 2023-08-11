using CalcAreaCircleTriangleLib.Interfaces;
using CalcAreaCircleTriangleLib.Models;
using CalcAreaCircleTriangleLib.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FiguresTestProject
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// ¬ысчитываетс€ ли площадь круга?
        /// </summary>
        [TestMethod]
        public void TestCircleAreaCalculation()
        {
            double radius = 1;

            Circle circle = new Circle(radius);

            Assert.AreEqual(Math.PI, circle.CalculateArea());
        }

        /// <summary>
        /// явл€етс€ ли кругом(и только) созданна€ динамически фигура ? 
        /// </summary>
        [TestMethod]
        public void TestCirleDinamicDefinition()
        {
            double radius = 1;

            FigureDefinition creatorFigures = new FigureDefinition();
            IFigureArea circleOfCreator = creatorFigures.FigureCreation(radius);

            Assert.IsFalse(circleOfCreator is Triangle);
            Assert.IsTrue(circleOfCreator is Circle);
        }


        /// <summary>
        /// ¬ысчитываетс€ ли площадь треугольника?
        /// </summary>
        [TestMethod]
        public void TestTriangleAreaCalculation()
        {
            double sideA = 3, sideB = 4, sideC = 5;
            double expectedArea = 6;

            FigureDefinition calculator = new FigureDefinition();
            IFigureArea triangle = calculator.FigureCreation(sideA, sideB, sideC);

            Assert.AreEqual(expectedArea, triangle.CalculateArea());
        }

        // явл€етс€ ли треугольником(и только) созданна€ динамически фигура ?
        [TestMethod]
        public void TestTriangleDinamicDefinition()
        {
            double sideA = 2, sideB = 2, sideC = 3;

            FigureDefinition creatorFigures = new FigureDefinition();
            IFigureArea triangleOfCreator = creatorFigures.FigureCreation(sideA, sideB, sideC);

            Assert.IsFalse(triangleOfCreator is Circle);
            Assert.IsTrue(triangleOfCreator is Triangle);
        }

        /// <summary>
        /// явл€етс€ ли треугольник пр€моуголным ?
        /// </summary>
        [TestMethod]
        public void TestRightTriangle()
        {
            // 3*3 + 4*4  = 5*5
            // 9   + 16   = 25
            double sideA = 3, sideB = 4, sideC = 5;

            Triangle triangle = new Triangle(sideA, sideB, sideC);

            Assert.IsTrue(triangle.RightTriangle);
        }
    }
}
