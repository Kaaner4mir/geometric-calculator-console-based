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

    [Description("The perimeter of the parallelogram")]
    regularPolygon,
}

class Perimeter
{
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

    public static void Square()
    {
        double lenght = Utils.GetInput<double>("\n ➡️ Enter the side lenght: ");

        double result = 4 * lenght;

        ShowResult(Message.square, result);
    }

    public static void Rectangle()
    {
        double shortSide = Utils.GetInput<double>("\n ➡️ Enter the short side: ");
        double longSide = Utils.GetInput<double>(" ➡️ Enter the long side: ");

        double result = 2 * (shortSide + longSide);

        ShowResult(Message.rectangle, result);
    }

    public static void Circle()
    {
        double radius = Utils.GetInput<double>("\n ➡️ Enter the radius: ");

        double result = 2 * Math.PI * radius;

        ShowResult(Message.circle, result);
    }

    public static void Parallelogram()
    {
        double shortSide = Utils.GetInput<double>("\n ➡️ Enter the short side: ");
        double longSide = Utils.GetInput<double>(" ➡️ Enter the long side: ");

        double result = 2 * (shortSide + longSide);

        ShowResult(Message.parallelogram, result);
    }

    public static void RegularPolygon()
    {
        double numberOfSides = Utils.GetInput<double>("\n ➡️ Enter the number of sides: ");
        double sideLenght = Utils.GetInput<double>(" ➡️ Enter the side lenght: ");

        double result = numberOfSides * sideLenght;

        ShowResult(Message.regularPolygon, result);
    }

    public static void ShowResult(Message message, double result)
    {
        Utils.WriteColored($"\n ✅ {message.GetDescription()} is {result}", ConsoleColor.Green);
    }
}