using CalcAreaCircleTriangleLib.Helpers;
using CalcAreaCircleTriangleLib.Interfaces;
using System;

namespace CalcAreaCircleTriangleLib.Models
{
    public class Triangle : IFigureArea
    {
        public double sideA { get; private set; }
        public double sideB { get; private set; }
        public double sideC { get; private set; }


        /// <summary>
        /// Является ли треугольник прямоугольным по-теореме Пифагора,  
        /// где неизвестно какая из сторон - гипотенуза.
        /// </summary>       
        public bool RightTriangle
        {
            get
            {
                if ((sideA * sideA + sideB * sideB == sideC * sideC) ||
                    (sideA * sideA + sideC * sideC == sideB * sideB) ||
                    (sideC * sideC + sideB * sideB == sideA * sideA))
                    return true;
                return false;
            }            
        }

        /// <summary>
        /// Конструктор для простого создания треуголника с "автопроверкой" на прямой угол.
        /// Предусмотрен контроль параметров на "корректность".
        /// </summary>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        /// <param name="RightTriangle">если "true" есть прямой угол</param>
        public Triangle(double sideA, double sideB, double sideC, bool RightTriangle = false)
        {
            if (!ValidationExtensions.PositiveNumber(sideA, sideB, sideC) ||
                !ValidationExtensions.TriangleExistence(sideA, sideB, sideC))
                throw new ArgumentException("Недопустимые стороны треугольника !");

            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }


        /// <summary>
        /// Вычисление площади треугольника по-формуле Герона.
        /// </summary>
        /// <returns>Площадь треуголника.</returns>
        public double CalculateArea()
        {
            double semiPerimeter = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) *
                                             (semiPerimeter - sideB) * 
                                             (semiPerimeter - sideC));
        }

        /// <summary>
        /// Метод для наглядности(отладки) отображения параметров созданного треугольника.
        /// </summary>
        /// <returns>Выводит параметры треугольника до 2х знаков после запятой.</returns>
        //public override string ToString()
        //{
        //    return $"sideA={sideA.ToStringF2()}; " +
        //           $"sideB={sideB.ToStringF2()}; " +
        //           $"sideC={sideC.ToStringF2()}; " +
        //           $"RightTriangle={RightTriangle.ToString()}; " +
        //           $"Area={CalculateArea().ToStringF2()}"; ;
        //}
    }
}
