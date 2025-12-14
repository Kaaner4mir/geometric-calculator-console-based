using System.ComponentModel;

/// <summary>
/// Provides methods for calculating the area of various geometric shapes.
/// </summary>
class Area
{
    public enum Message
    {
        [Description("The area of the triangle")]
        triangle,

        [Description("The area of the square")]
        square,

        [Description("The area of the rectangle")]
        rectangle,

        [Description("The area of the trapezoid")]
        trapezoid,

        [Description("The area of the parallelogram")]
        parallelogram,

        [Description("The area of the circle")]
        circle,

        [Description("The area of the rhombus")]
        rhombus,

    }

    /// <summary>
    /// Displays the area calculation menu and processes user selection to perform the appropriate area calculation.
    /// </summary>
    /// <remarks>
    /// Clears the console, displays the area menu, and routes the user's selection to the
    /// corresponding area calculation method. Handles exceptions and displays error messages.
    /// </remarks>
    public static void AreaOperations()
    {
        try
        {
            Console.Clear();
            Menu.AreaMenu();

            short inputVal = Utils.GetInput<short>("\n 👉 Please enter the operation you wish to perform numerically: ");

            switch (inputVal)
            {
                case 1: Triangle(); break;
                case 2:Square();break;
                case 3:Rectangle();break;
                case 4:Trapezoid();break;
                case 5:Parallelogram();break;
                case 6:Circle();break;
                case 7:Rhombus();break;
                default: Utils.WriteColored("\n ❓ You have made an invalid transaction!", ConsoleColor.Red); break;
            }
        }
        catch (Exception ex)
        {
            Utils.WriteColored($"\n ⛔ An error has occurred in area operations: {ex.Message}", ConsoleColor.Red);
        }
    }

    /// <summary>
    /// Calculates and displays the area of a triangle.
    /// </summary>
    /// <remarks>
    /// Prompts the user for the base length and height, then calculates the area using
    /// the formula: Area = (base × height) / 2
    /// </remarks>
    public static void Triangle()
    {
        double baseLength = Utils.GetInput<double>("\n ➡️ Enter the base length: ");
        double height = Utils.GetInput<double>(" ➡️ Enter the height: ");

        double result = (baseLength * height) / 2;

        ShowResult(Message.triangle, result);
    }

    /// <summary>
    /// Calculates and displays the area of a square.
    /// </summary>
    /// <remarks>
    /// Prompts the user for the side length, then calculates the area using
    /// the formula: Area = side²
    /// </remarks>
    public static void Square()
    {
        double sideLength = Utils.GetInput<double>("\n ➡️ Enter the side length: ");

        double result = sideLength * sideLength;

        ShowResult(Message.square, result);
    }

    /// <summary>
    /// Calculates and displays the area of a rectangle.
    /// </summary>
    /// <remarks>
    /// Prompts the user for the short side and long side lengths, then calculates the area using
    /// the formula: Area = short side × long side
    /// </remarks>
    public static void Rectangle()
    {
        double shortSide = Utils.GetInput<double>("\n ➡️ Enter the short side: ");
        double longSide = Utils.GetInput<double>(" ➡️ Enter the long side: ");

        double result =shortSide * longSide;

        ShowResult(Message.rectangle, result);
    }

    /// <summary>
    /// Calculates and displays the area of a trapezoid.
    /// </summary>
    /// <remarks>
    /// Prompts the user for the lower base, upper base, and height, then calculates the area using
    /// the formula: Area = ((lower base + upper base) × height) / 2
    /// </remarks>
    public static void Trapezoid()
    {
        double lowerBase = Utils.GetInput<double>("\n ➡️ Enter the lower base: ");
        double upperBase = Utils.GetInput<double>(" ➡️ Enter the upper base: ");
        double height = Utils.GetInput<double>(" ➡️ Enter the height: ");

        double result = ((lowerBase+upperBase)*height)/2;

        ShowResult(Message.trapezoid, result);
    }

    /// <summary>
    /// Calculates and displays the area of a parallelogram.
    /// </summary>
    /// <remarks>
    /// Prompts the user for the base length and height, then calculates the area using
    /// the formula: Area = base × height
    /// </remarks>
    public static void Parallelogram()
    {
        double baseLength = Utils.GetInput<double>("\n ➡️ Enter the base length: ");
        double height = Utils.GetInput<double>(" ➡️ Enter the height: ");

        double result = baseLength * height;

        ShowResult(Message.parallelogram, result);
    }

    /// <summary>
    /// Calculates and displays the area of a circle.
    /// </summary>
    /// <remarks>
    /// Prompts the user for the radius, then calculates the area using
    /// the formula: Area = π × radius²
    /// </remarks>
    public static void Circle()
    {
        double radius = Utils.GetInput<double>("\n ➡️ Enter the radius: ");

        double result = Math.PI * Math.Pow(radius, 2);

        ShowResult(Message.circle, result);
    }

    /// <summary>
    /// Calculates and displays the area of a rhombus.
    /// </summary>
    /// <remarks>
    /// Prompts the user for the first and second diagonal lengths, then calculates the area using
    /// the formula: Area = (first diagonal × second diagonal) / 2
    /// </remarks>
    public static void Rhombus()
    {
        double firstDiagonal = Utils.GetInput<double>("\n ➡️ Enter the first diagonal: ");
        double secondDiagonal = Utils.GetInput<double>(" ➡️ Enter the second diagonal: ");

        double result = firstDiagonal * secondDiagonal / 2;

        ShowResult(Message.rhombus, result);
    }

    /// <summary>
    /// Displays the calculated area result with a formatted message.
    /// </summary>
    /// <param name="message">The message enum value that contains the shape description.</param>
    /// <param name="result">The calculated area value to display.</param>
    /// <remarks>
    /// Formats and displays the result using the description from the Message enum
    /// attribute and the calculated result value in green color.
    /// </remarks>
    public static void ShowResult(Message message, double result)
    {
        Utils.WriteColored($"\n ✅ {message.GetDescription()} is {result}", ConsoleColor.Green);
    }
}