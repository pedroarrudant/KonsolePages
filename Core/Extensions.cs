using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace Extensions
{
    [ExcludeFromCodeCoverage]
    public static class Extensions
    {
        public static string GetDescription(this Enum value)
        {
            FieldInfo? fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[]? attributes = fi?.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            if (attributes != null && attributes.Any())
            {
                return attributes[0].Description;
            }

            return value.ToString();
        }
    }
}
