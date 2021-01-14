namespace Solid.Helpers.Utils
{
    public static class Stringfier
    {
        // TO DO: Melhorar a lógica pra poder receber o tipo da moeda
        public static string ToCurrencyString(this int value)
        {
            return string.Format($"R$ {value.ToString("0.##")}");
        }

        // TO DO: Melhorar a lógica pra poder receber o tipo da moeda
        public static string ToCurrencyString(this double value)
        {
            return string.Format($"R$ {value.ToString("0.##")}");
        }

        // TO DO: Melhorar a lógica pra poder receber o tipo da moeda
        public static string ToCurrencyString(this decimal value)
        {
            return string.Format($"R$ {value.ToString("0.##")}");
        }
    }
}