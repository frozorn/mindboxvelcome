namespace CalcAreaCircleTriangleLib.Helpers
{
    internal static class ValidationExtensions
    {
        /// <summary>
        /// Проверка параметров создаваемой фигуры на неотрицательность. Их количество нефиксированное.
        /// </summary>
        /// <param name="numbers">Параметры создаваемой фигуры.</param>
        /// <returns></returns>
        internal static bool PositiveNumber(params double[] numbers)
        {
            foreach (var item in numbers)
            {
                if (item < 0) return false;
            }
            return true;
        }

        /// <summary>
        /// Проверка сторон треуголника на "признак сущестования треуголника".
        /// </summary>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        /// <returns></returns>
        internal static bool TriangleExistence(double sideA, double sideB, double sideC)
        {
            if ((sideA + sideB > sideC) &&
                (sideB + sideC > sideA) &&
                (sideA + sideC > sideB))
                return true;
            return false;
        }
    }
}
