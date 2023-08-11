using CalcAreaCircleTriangleLib.Interfaces;
using CalcAreaCircleTriangleLib.Models;
using System;

namespace CalcAreaCircleTriangleLib.Services
{
    public class FigureDefinition
    {
        /// <summary>
        /// Создание фигуры без знания её типа на основе переданных параметров.
        /// </summary>
        /// <param name="linearDimensions">Линейные параметры создаваймой фигуры.</param>
        /// <returns>Фигура, у которой можно вычислить площадь.</returns>
        public IFigureArea FigureCreation(params double [] linearDimensions)
        {
            switch (linearDimensions.Length)
            {
                case 1:
                    double radius = linearDimensions[0];
                    return new Circle(radius);
                case 3:
                    double a = linearDimensions[0];
                    double b = linearDimensions[1];
                    double c = linearDimensions[2];
                    return new Triangle(a, b, c);
                default:
                    throw new ArgumentException("Неподдерживаемое количество линейных параметров для создание фигуры!");
            }
        }
    }
}
