using System;
using System.ComponentModel;

namespace Solid.Helpers.Utils.Enums
{
    public static class EnumHelper
    {
        public static string GetDescription<T>(this T @enum)
            where T : struct, IConvertible
        {
            if (!(@enum is Enum))
                return null;

            var description = @enum.ToString();
            var fieldInfo = @enum.GetType().GetField(@enum.ToString());

            if (fieldInfo != null)
            {
                var attrs = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), true);
                
                if (attrs != null && attrs.Length > 0)
                {
                    description = ((DescriptionAttribute)attrs[0]).Description;
                }
            }

            return description;
        }
    }
}
