class Menu
{
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

    public static void AreaMenu()
    {
        var perimeterMenuItems = new (string text, ConsoleColor Color)[]
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

        foreach (var item in perimeterMenuItems)
        {
            Utils.WriteColored(item.text, item.Color);
        }
    }
}