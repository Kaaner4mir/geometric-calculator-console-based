using System.ComponentModel;

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

        [Description("The area of the trapeziod")]
        trapezoid,

        [Description("The area of the parallelogram")]
        parallelogram,

        [Description("The area of the circle")]
        circle,

        [Description("The area of the rhombus")]
        rhombus,

    }

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
                case 5:Paralellogram();break;
                case 6:Circle();break;
                case 7:Rhombus();break;
                default: Utils.WriteColored("\n ❓ You have made an invalid transaction!", ConsoleColor.Red); break;
            }
        }
        catch (Exception ex)
        {
            Utils.WriteColored($"\n ⛔ An error has occurred in perimeter operations: {ex.Message}", ConsoleColor.Red);
        }
    }

    public static void Triangle()
    {
        double baseLenght = Utils.GetInput<double>("\n ➡️ Enter the base lenght: ");
        double height = Utils.GetInput<double>(" ➡️ Enter the height: ");

        double result = (baseLenght * height) / 2;

        ShowResult(Message.triangle, result);
    }

    public static void Square()
    {
        double sideLenght = Utils.GetInput<double>("\n ➡️ Enter the side lenght: ");

        double result = sideLenght * sideLenght;

        ShowResult(Message.square, result);
    }

    public static void Rectangle()
    {
        double shortSide = Utils.GetInput<double>("\n ➡️ Enter the short side: ");
        double longSide = Utils.GetInput<double>(" ➡️ Enter the long side: ");

        double result =shortSide * longSide;

        ShowResult(Message.rectangle, result);
    }

    public static void Trapezoid()
    {
        double lowerBase = Utils.GetInput<double>("\n ➡️ Enter the lower base: ");
        double upperBase = Utils.GetInput<double>(" ➡️ Enter the upper base: ");
        double height = Utils.GetInput<double>(" ➡️ Enter the height: ");

        double result = ((lowerBase+upperBase)*height)/2;

        ShowResult(Message.trapezoid, result);
    }

    public static void Paralellogram()
    {
        double lowerBase = Utils.GetInput<double>("\n ➡️ Enter the lower base: ");
        double upperBase = Utils.GetInput<double>(" ➡️ Enter the upper base: ");
        double height = Utils.GetInput<double>(" ➡️ Enter the height: ");

        double result = ((lowerBase + upperBase) * height) / 2;

        ShowResult(Message.parallelogram, result);
    }

    public static void Circle()
    {
        double radius = Utils.GetInput<double>("\n ➡️ Enter the radius: ");

        double result = Math.PI * Math.Pow(radius, 2);

        ShowResult(Message.circle, result);
    }

    public static void Rhombus()
    {
        double firstDiagonal = Utils.GetInput<double>("\n ➡️ Enter the first diagonal: ");
        double secondDiagonal = Utils.GetInput<double>(" ➡️ Enter the second diagonal: ");

        double result = firstDiagonal * secondDiagonal / 2;

        ShowResult(Message.rhombus, result);
    }

    public static void ShowResult(Message message, double result)
    {
        Utils.WriteColored($"\n ✅ {message.GetDescription()} is {result}", ConsoleColor.Green);
    }
}