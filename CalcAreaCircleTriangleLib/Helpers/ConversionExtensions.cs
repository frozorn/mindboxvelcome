using System.Globalization;

namespace CalcAreaCircleTriangleLib.Helpers
{
    internal static class ConversionExtensions
    {   
        // Исполульзется для отладки и форматирования.
        /// <summary>
        /// Форматирует число с плавающей точкой(double) до двух знаков в дробной части. 
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Формат отображаемого числа: разделитель дробной части - точка, 2 знака после точки.</returns>
        internal static string ToStringF2(this double value)
        {
            return value.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
