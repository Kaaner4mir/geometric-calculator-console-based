using System.ComponentModel;

public enum Message
{
    [Description("The perimeter of the square")]
    square,

    [Description("The perimeter of the rectangle")]
    rectangle,

    [Description("The perimeter of the circle")]
    circle,

    [Description("The perimeter of the parallelogram")]
    parallelogram,

    [Description("The perimeter of the regular polygon")]
    regularPolygon,
}

/// <summary>
/// Provides methods for calculating the perimeter of various geometric shapes.
/// </summary>
class Perimeter
{
    /// <summary>
    /// Displays the perimeter calculation menu and processes user selection to perform the appropriate perimeter calculation.
    /// </summary>
    /// <remarks>
    /// Clears the console, displays the perimeter menu, and routes the user's selection to the
    /// corresponding perimeter calculation method. Handles exceptions and displays error messages.
    /// </remarks>
    public static void PerimeterOperations()
    {
        try
        {
            Console.Clear();
            Menu.PerimeterMenu();

            short inputVal = Utils.GetInput<short>("\n 👉 Please enter the operation you wish to perform numerically: ");

            switch (inputVal)
            {
                case 1: Square(); break;
                case 2: Rectangle(); break;
                case 3: Circle(); break;
                case 4: Parallelogram(); break;
                case 5: RegularPolygon(); break;
                default: Utils.WriteColored("\n ❓ You have made an invalid transaction!",ConsoleColor.Red); break;
            }
        }
        catch (Exception ex)
        {
            Utils.WriteColored($"\n ⛔ An error has occurred in perimeter operations: {ex.Message}", ConsoleColor.Red);
        }
    }

    /// <summary>
    /// Calculates and displays the perimeter of a square.
    /// </summary>
    /// <remarks>
    /// Prompts the user for the side length, then calculates the perimeter using
    /// the formula: Perimeter = 4 × side
    /// </remarks>
    public static void Square()
    {
        double length = Utils.GetInput<double>("\n ➡️ Enter the side length: ");

        double result = 4 * length;

        ShowResult(Message.square, result);
    }

    /// <summary>
    /// Calculates and displays the perimeter of a rectangle.
    /// </summary>
    /// <remarks>
    /// Prompts the user for the short side and long side lengths, then calculates the perimeter using
    /// the formula: Perimeter = 2 × (short side + long side)
    /// </remarks>
    public static void Rectangle()
    {
        double shortSide = Utils.GetInput<double>("\n ➡️ Enter the short side: ");
        double longSide = Utils.GetInput<double>(" ➡️ Enter the long side: ");

        double result = 2 * (shortSide + longSide);

        ShowResult(Message.rectangle, result);
    }

    /// <summary>
    /// Calculates and displays the perimeter (circumference) of a circle.
    /// </summary>
    /// <remarks>
    /// Prompts the user for the radius, then calculates the perimeter using
    /// the formula: Perimeter = 2 × π × radius
    /// </remarks>
    public static void Circle()
    {
        double radius = Utils.GetInput<double>("\n ➡️ Enter the radius: ");

        double result = 2 * Math.PI * radius;

        ShowResult(Message.circle, result);
    }

    /// <summary>
    /// Calculates and displays the perimeter of a parallelogram.
    /// </summary>
    /// <remarks>
    /// Prompts the user for the short side and long side lengths, then calculates the perimeter using
    /// the formula: Perimeter = 2 × (short side + long side)
    /// </remarks>
    public static void Parallelogram()
    {
        double shortSide = Utils.GetInput<double>("\n ➡️ Enter the short side: ");
        double longSide = Utils.GetInput<double>(" ➡️ Enter the long side: ");

        double result = 2 * (shortSide + longSide);

        ShowResult(Message.parallelogram, result);
    }

    /// <summary>
    /// Calculates and displays the perimeter of a regular polygon.
    /// </summary>
    /// <remarks>
    /// Prompts the user for the number of sides and side length, then calculates the perimeter using
    /// the formula: Perimeter = number of sides × side length
    /// </remarks>
    public static void RegularPolygon()
    {
        double numberOfSides = Utils.GetInput<double>("\n ➡️ Enter the number of sides: ");
        double sideLength = Utils.GetInput<double>(" ➡️ Enter the side length: ");

        double result = numberOfSides * sideLength;

        ShowResult(Message.regularPolygon, result);
    }

    /// <summary>
    /// Displays the calculated perimeter result with a formatted message.
    /// </summary>
    /// <param name="message">The message enum value that contains the shape description.</param>
    /// <param name="result">The calculated perimeter value to display.</param>
    /// <remarks>
    /// Formats and displays the result using the description from the Message enum
    /// attribute and the calculated result value in green color.
    /// </remarks>
    public static void ShowResult(Message message, double result)
    {
        Utils.WriteColored($"\n ✅ {message.GetDescription()} is {result}", ConsoleColor.Green);
    }
}