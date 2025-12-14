/// <summary>
/// Provides functionality for exiting the application with user confirmation.
/// </summary>
class Exit
{
    /// <summary>
    /// Prompts the user to confirm exit and terminates the application if confirmed.
    /// </summary>
    /// <remarks>
    /// Clears the console and asks the user for confirmation (Y/N). If the user enters 'Y',
    /// the application exits with code 0. If 'N' is entered, the method returns to the main menu.
    /// Invalid input displays an error message. All exceptions are caught and displayed.
    /// </remarks>
    public static void ExitOperation()
    {
        try
        {
            Console.Clear();
            string inputVal = Utils.GetInput<string>(" 👉 Are you sure you want to exit (Y/N): ");

            if (inputVal.ToUpper() == "Y")
                Environment.Exit(0);
            else if (inputVal.ToUpper() == "N")
                return;
            else
                Utils.WriteColored("\n ❓ You have made an invalid transaction!", ConsoleColor.Red);
        }
        catch (Exception ex)
        {
            Utils.WriteColored($"\n ⛔ An error has occurred in exit operation: {ex.Message}", ConsoleColor.Red);
        }
    }
}