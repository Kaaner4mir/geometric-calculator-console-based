using System.ComponentModel;
using System.Reflection;

/// <summary>
/// Provides extension methods for enum types, particularly for retrieving description attributes.
/// </summary>
public static class EnumExtensions
{
    /// <summary>
    /// Retrieves the description attribute value from an enum value, or returns the enum's string representation if no description is found.
    /// </summary>
    /// <param name="value">The enum value to get the description for.</param>
    /// <returns>
    /// The description from the <see cref="DescriptionAttribute"/> if present,
    /// otherwise the string representation of the enum value.
    /// </returns>
    /// <remarks>
    /// This method uses reflection to find the field corresponding to the enum value
    /// and retrieves its <see cref="DescriptionAttribute"/>. If the attribute is not found,
    /// it returns the enum value's string representation as a fallback.
    /// </remarks>
    public static string GetDescription(this Enum value)
    {
        var type = value.GetType();
        var field = type.GetField(value.ToString());

        if (field == null)
            return value.ToString();

        var attribute = field.GetCustomAttribute<DescriptionAttribute>();

        return attribute?.Description ?? value.ToString();
    }
}
