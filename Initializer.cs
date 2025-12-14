using System.Text;

class Initializer
{
    public static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

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