namespace RestWithASPNET10.Utils
{
    public class NumberHelper
    {
        public static decimal ConvertToDecimal(string strNumero)
        {
            decimal decimalValue;
            if (decimal.TryParse(strNumero,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out decimalValue))
            {
                return decimalValue;
            }

            return 0;
        }

        public static bool IsNumeric(string primeiroNumero)
        {
            decimal decimalValue;
            bool isNumber = decimal.TryParse(
                primeiroNumero,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out decimalValue
                );

            return isNumber;
        }
    }
}
