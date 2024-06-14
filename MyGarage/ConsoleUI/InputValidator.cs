

class InputValidator
{
    // private const int MENU_CHOICES = 8;

    internal static int getUserSelectionFromMenu(int i_MinValue, int i_MaxValue)
    {
        bool isValidType = false;
        int userSelection = 0;

        while (!isValidType)
        {
            try
            {
                string userInput = Console.ReadLine();
                userSelection = int.Parse(userInput);
                isValidType = checkForValidInput(userSelection, i_MinValue, i_MaxValue);
            }
            catch (FormatException ex)
            {
                System.Console.WriteLine("Please enter a number!" + ex.Message);
            }
            catch (ValueOutOfRangeException ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            finally
            {
                isValidType = true;
            }
            
        }

    return userSelection;
}

    private static bool checkForValidInput(int i_UserSelection, int i_MinValue, int i_MaxValue)
    {
        bool isValidType = false;
        if (i_UserSelection > i_MinValue && i_UserSelection < i_MaxValue)
        {
            isValidType = true;
        }
        else
        {
            throw new ValueOutOfRangeException(i_MinValue, i_MaxValue);
        }

        return isValidType;
    }

    public static string GetDetailsAboutVehicle(string i_DetailsType)
    {
        Console.Clear();
        System.Console.WriteLine("Please enter the vehicle's " + i_DetailsType + ": ");
        return Console.ReadLine();
    }

    public static string IsCarryingDangerousMaterials()
    {
        Console.Clear();
        System.Console.WriteLine("Is the vehicle carrying dangerous materials? (Y/N): ");
        return Console.ReadLine();
    }
}