using System.ComponentModel;

/// <summary>
/// Provides methods for calculating the volume of various 3D geometric shapes.
/// </summary>
class Volume
{
    public enum Message
    {
        [Description("The volume of the cube")]
        cube,

        [Description("The volume of the cuboid")]
        cuboid,

        [Description("The volume of the cylinder")]
        cylinder,

        [Description("The volume of the cone")]
        cone,

        [Description("The volume of the sphere")]
        sphere,

        [Description("The volume of the square pyramid")]
        squarePyramid,

        [Description("The volume of the triangular prism")]
        triangularPrism,

        [Description("The volume of the hemisphere")]
        hemisphere,

        [Description("The volume of the regular pyramid")]
        regularPyramid,
    }

    /// <summary>
    /// Displays the volume calculation menu and processes user selection to perform the appropriate volume calculation.
    /// </summary>
    /// <remarks>
    /// Clears the console, displays the volume menu, and routes the user's selection to the
    /// corresponding volume calculation method. Handles exceptions and displays error messages.
    /// </remarks>
    public static void VolumeOperations()
    {
        try
        {
            Console.Clear();
            Menu.VolumeMenu();

            short inputVal = Utils.GetInput<short>("\n 👉 Please enter the operation you wish to perform numerically: ");

            switch (inputVal)
            {
                case 1: Cube(); break;
                case 2: Cuboid(); break;
                case 3: Cylinder(); break;
                case 4: Cone(); break;
                case 5: Sphere(); break;
                case 6: SquarePyramid(); break;
                case 7: TriangularPrism(); break;
                case 8: Hemisphere(); break;
                case 9: RegularPyramid(); break;

                default: Utils.WriteColored("\n ❓ You have made an invalid transaction!", ConsoleColor.Red); break;
            }
        }
        catch (Exception ex)
        {
            Utils.WriteColored($"\n ⛔ An error has occurred in volume operations: {ex.Message}", ConsoleColor.Red);
        }
    }

    /// <summary>
    /// Calculates and displays the volume of a cube.
    /// </summary>
    /// <remarks>
    /// Prompts the user for the side length, then calculates the volume using
    /// the formula: Volume = side³
    /// </remarks>
    public static void Cube()
    {
        double sideLength = Utils.GetInput<double>("\n ➡️ Enter the side length: ");

        double result = sideLength * sideLength * sideLength;

        ShowResult(Message.cube, result);
    }

    /// <summary>
    /// Calculates and displays the volume of a cuboid (rectangular prism).
    /// </summary>
    /// <remarks>
    /// Prompts the user for the length, width, and height, then calculates the volume using
    /// the formula: Volume = length × width × height
    /// </remarks>
    public static void Cuboid()
    {
        double length = Utils.GetInput<double>("\n ➡️ Enter the length: ");
        double width = Utils.GetInput<double>(" ➡️ Enter the width: ");
        double height = Utils.GetInput<double>(" ➡️ Enter the height: ");

        double result = length * width * height;

        ShowResult(Message.cuboid, result);
    }

    /// <summary>
    /// Calculates and displays the volume of a cylinder.
    /// </summary>
    /// <remarks>
    /// Prompts the user for the radius and height, then calculates the volume using
    /// the formula: Volume = π × radius² × height
    /// </remarks>
    public static void Cylinder()
    {
        double radius = Utils.GetInput<double>("\n ➡️ Enter the radius: ");
        double height = Utils.GetInput<double>(" ➡️ Enter the height: ");

        double result = Math.PI * Math.Pow(radius, 2) * height;

        ShowResult(Message.cylinder, result);
    }

    /// <summary>
    /// Calculates and displays the volume of a cone.
    /// </summary>
    /// <remarks>
    /// Prompts the user for the radius and height, then calculates the volume using
    /// the formula: Volume = (π × radius² × height) / 3
    /// </remarks>
    public static void Cone()
    {
        double radius = Utils.GetInput<double>("\n ➡️ Enter the radius: ");
        double height = Utils.GetInput<double>(" ➡️ Enter the height: ");

        double result = (Math.PI * Math.Pow(radius, 2) * height) / 3;

        ShowResult(Message.cone, result);
    }

    /// <summary>
    /// Calculates and displays the volume of a sphere.
    /// </summary>
    /// <remarks>
    /// Prompts the user for the radius, then calculates the volume using
    /// the formula: Volume = (4 × π × radius³) / 3
    /// </remarks>
    public static void Sphere()
    {
        double radius = Utils.GetInput<double>("\n ➡️ Enter the radius: ");

        double result = (4 * Math.PI * Math.Pow(radius, 3)) / 3;

        ShowResult(Message.sphere, result);
    }

    /// <summary>
    /// Calculates and displays the volume of a square pyramid.
    /// </summary>
    /// <remarks>
    /// Prompts the user for the side length and height, then calculates the volume using
    /// the formula: Volume = (side² × height) / 3
    /// </remarks>
    public static void SquarePyramid()
    {
        double sideLength = Utils.GetInput<double>("\n ➡️ Enter the side length: ");
        double height = Utils.GetInput<double>(" ➡️ Enter the height: ");

        double result = (sideLength * sideLength * height) / 3;

        ShowResult(Message.squarePyramid, result);
    }

    /// <summary>
    /// Calculates and displays the volume of a triangular prism.
    /// </summary>
    /// <remarks>
    /// Prompts the user for the base area and height, then calculates the volume using
    /// the formula: Volume = base area × height
    /// </remarks>
    public static void TriangularPrism()
    {
        double baseArea = Utils.GetInput<double>("\n ➡️ Enter the base area: ");
        double height = Utils.GetInput<double>(" ➡️ Enter the height: ");

        double result = baseArea * height;

        ShowResult(Message.triangularPrism, result);
    }

    /// <summary>
    /// Calculates and displays the volume of a hemisphere (half sphere).
    /// </summary>
    /// <remarks>
    /// Prompts the user for the radius, then calculates the volume using
    /// the formula: Volume = (2 × π × radius³) / 3
    /// </remarks>
    public static void Hemisphere()
    {
        double radius = Utils.GetInput<double>("\n ➡️ Enter the radius: ");

        double result = (2 * Math.PI * Math.Pow(radius, 3)) / 3;

        ShowResult(Message.hemisphere, result);
    }

    /// <summary>
    /// Calculates and displays the volume of a regular pyramid.
    /// </summary>
    /// <remarks>
    /// Prompts the user for the base area and height, then calculates the volume using
    /// the formula: Volume = (base area × height) / 3
    /// </remarks>
    public static void RegularPyramid()
    {
        double baseArea = Utils.GetInput<double>("\n ➡️ Enter the base area: ");
        double height = Utils.GetInput<double>(" ➡️ Enter the height: ");

        double result = (baseArea * height) / 3;

        ShowResult(Message.regularPyramid, result);
    }

    /// <summary>
    /// Displays the calculated volume result with a formatted message.
    /// </summary>
    /// <param name="message">The message enum value that contains the shape description.</param>
    /// <param name="result">The calculated volume value to display.</param>
    /// <remarks>
    /// Formats and displays the result using the description from the Message enum
    /// attribute and the calculated result value in green color.
    /// </remarks>
    public static void ShowResult(Message message, double result)
    {
        Utils.WriteColored($"\n ✅ {message.GetDescription()} is {result}", ConsoleColor.Green);
    }
}