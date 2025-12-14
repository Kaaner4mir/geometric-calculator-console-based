/// <summary>
/// Provides methods for displaying various menu screens in the console application.
/// </summary>
class Menu
{
    /// <summary>
    /// Displays the main menu with options for perimeter, area, volume calculations, and exit.
    /// </summary>
    /// <remarks>
    /// The menu is displayed with color-coded options using different console colors for
    /// visual appeal and easy navigation.
    /// </remarks>
    public static void MainMenu()
    {
        var mainMenuItems = new (string text, ConsoleColor Color)[]
        {
            ( $"{"".PadLeft(6)}📝 Main Menu", ConsoleColor.Magenta),
            ( $"{new string('-',26)}",ConsoleColor.White),
            ( " 1. Perimeter Calculation", ConsoleColor.Blue),
            ( " 2. Area Calculation", ConsoleColor.DarkRed),
            ( " 3. Volume Calculation", ConsoleColor.Green),
            ( " 4. Exit", ConsoleColor.White),
        };

        foreach (var item in mainMenuItems)
        {
            Utils.WriteColored(item.text, item.Color);
        }
    }

    /// <summary>
    /// Displays the perimeter calculation menu with available shape options.
    /// </summary>
    /// <remarks>
    /// Shows options for calculating perimeter of: Square, Rectangle, Circle,
    /// Parallelogram, and Regular Polygon.
    /// </remarks>
    public static void PerimeterMenu()
    {
        var perimeterMenuItems = new (string text, ConsoleColor Color)[]
        {
            ( $"{"".PadLeft(6)}📏 Perimeter Menu", ConsoleColor.Magenta),
            ( $"{new string('-',26)}",ConsoleColor.White),
            ( " 1. Square", ConsoleColor.Blue),
            ( " 2. Rectangle", ConsoleColor.DarkRed),
            ( " 3. Circle", ConsoleColor.Green),
            ( " 4. Parallelogram", ConsoleColor.DarkYellow),
            ( " 5. Regular Polygon", ConsoleColor.White),
        };

        foreach (var item in perimeterMenuItems)
        {
            Utils.WriteColored(item.text, item.Color);
        }
    }

    /// <summary>
    /// Displays the area calculation menu with available shape options.
    /// </summary>
    /// <remarks>
    /// Shows options for calculating area of: Triangle, Square, Rectangle, Trapezoid,
    /// Parallelogram, Circle, and Rhombus.
    /// </remarks>
    public static void AreaMenu()
    {
        var areaMenuItems = new (string text, ConsoleColor Color)[]
        {
            ( $"{"".PadLeft(6)}📐 Area Menu", ConsoleColor.Magenta),
            ( $"{new string('-',26)}",ConsoleColor.White),
            ( " 1. Triangle", ConsoleColor.Blue),
            ( " 2. Square", ConsoleColor.DarkRed),
            ( " 3. Rectangle", ConsoleColor.Green),
            ( " 4. Trapezoid", ConsoleColor.DarkYellow),
            ( " 5. Parallelogram", ConsoleColor.White),
            ( " 6. Circle", ConsoleColor.Cyan),
            ( " 7. Rhombus", ConsoleColor.DarkBlue),
        };

        foreach (var item in areaMenuItems)
        {
            Utils.WriteColored(item.text, item.Color);
        }
    }

    /// <summary>
    /// Displays the volume calculation menu with available 3D shape options.
    /// </summary>
    /// <remarks>
    /// Shows options for calculating volume of: Cube, Cuboid, Cylinder, Cone, Sphere,
    /// Square Pyramid, Triangular Prism, Hemisphere, and Regular Pyramid.
    /// </remarks>
    public static void VolumeMenu()
    {
        var volumeMenuItems = new (string text, ConsoleColor Color)[]
        {
            ( $"{"".PadLeft(6)}🔵 Volume Menu", ConsoleColor.Magenta),
            ( $"{new string('-',26)}",ConsoleColor.White),
            ( " 1. Cube", ConsoleColor.Blue),
            ( " 2. Cuboid", ConsoleColor.DarkRed),
            ( " 3. Cylinder", ConsoleColor.Green),
            ( " 4. Cone", ConsoleColor.DarkYellow),
            ( " 5. Sphere", ConsoleColor.White),
            ( " 6. Square Pyramid", ConsoleColor.Cyan),
            ( " 7. Triangular Prism", ConsoleColor.DarkBlue),
            ( " 8. Hemisphere", ConsoleColor.DarkGreen),
            ( " 9. Regular Pyramid", ConsoleColor.DarkRed),
        };

        foreach (var item in volumeMenuItems)
        {
            Utils.WriteColored(item.text, item.Color);
        }
    }
}