using System.Text;

/// <summary>
/// Initializes and runs the Geometric Calculator application.
/// Sets up UTF-8 encoding and manages the main application loop.
/// </summary>
class Initializer
{
    /// <summary>
    /// The main entry point of the application. Configures console encoding, sets the window title,
    /// and runs the main menu loop until the user chooses to exit.
    /// </summary>
    /// <remarks>
    /// This method sets UTF-8 encoding for proper display of emoji and special characters,
    /// sets the console window title, and continuously displays the main menu, processing user
    /// selections until an exit operation is performed. All exceptions are caught and displayed
    /// with user-friendly error messages.
    /// </remarks>
    public static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        Console.Title = "📐 Geometric Calculator";

        try
        {
            while (true)
            {
                Console.Clear();
                Menu.MainMenu();

                short inputVal = Utils.GetInput<short>("\n 👉 Please enter the operation you wish to perform numerically: ");

                switch (inputVal)
                {
                    case 1: Perimeter.PerimeterOperations(); break;
                    case 2: Area.AreaOperations(); break;
                    case 3: Volume.VolumeOperations(); break;
                    case 4: Exit.ExitOperation(); break;
                    default: Utils.WriteColored("\n ❓ You have made an invalid transaction!"); break;
                }
                Utils.WaitingScreen();
            }
        }
        catch (Exception ex)
        {
            Utils.WriteColored($"\n ⛔ An error has occurred: {ex.Message}", ConsoleColor.Red);
        }

    }
}