using CalcAreaCircleTriangleLib.Helpers;
using CalcAreaCircleTriangleLib.Interfaces;
using System;

namespace CalcAreaCircleTriangleLib.Models
{
    public class Circle : IFigureArea
    {
        public double radius { get; private set; }

        /// <summary>
        /// Конструктор для простого создания круга.
        /// Предусмотрен контроль параметров на "корректность".
        /// </summary>
        /// <param name="radius"></param>
        public Circle(double radius)
        {
            if (!ValidationExtensions.PositiveNumber(radius)) 
                throw new ArgumentException("Радиус не может быть отрицательным !");

            this.radius = radius;
        }

        /// <summary>
        /// Вычисление площади круга : S = π * r*r
        /// </summary>
        /// <returns></returns>
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        /// <summary>
        /// Метод для наглядности(отладки) отображения параметров созданного круга.
        /// </summary>
        /// <returns>Выводит параметры круга до 2х знаков после запятой.</returns>
        //public override string ToString()
        //{
        //    return $"Radius={radius.ToStringF2()} " +
        //           $"Area={CalculateArea().ToStringF2()}";
        //}
    }
}
