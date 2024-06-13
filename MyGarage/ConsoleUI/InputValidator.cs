


class InputValidator
{

    public static int GetValidMenuChoice()
    {
        string userChoice = Console.ReadLine();
        while (!IsValidMenuChoice(userChoice))
        {
            System.Console.WriteLine("Invalid input. Please try again.");
            userChoice = Console.ReadLine();
        }
        return int.Parse(userChoice);
    }

    public static bool IsValidMenuChoice(string userChoice)
    {
        bool isValidChoise = false;

        try {
            int choice = int.Parse(userChoice);
            if (choice >= 1 && choice <= 8)
            {
                isValidChoise = true;
            }
        }
        catch (Exception)
        {
            isValidChoise = false;
        }

        return isValidChoise;
    }
}