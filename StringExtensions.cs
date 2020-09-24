using System.Globalization;

namespace sler
{
    public static class StringExtensions
    {
        public static decimal ToAmount(this string amount)
        {
            decimal decimalAmount;
            decimal.TryParse(amount, NumberStyles.Any, CultureInfo.InvariantCulture , out decimalAmount);
            return decimalAmount;
        }
    }
}