
public class Program
{
    public static void Main()
    {
        bool isRunning = true;

        GarageManager garageManager = new GarageManager();
        DisplayWelcomeMessage();


        while (isRunning)
        {
            int userChoice = InputValidator.GetValidMenuChoice();

            if (userChoice == 1)
            {
                // Ask for vehicle license plate
                
            }
            else
            {
                isRunning = false;
            }
        
        }

        System.Console.WriteLine("Goodbye!");

    }

    private static void DisplayWelcomeMessage()
    {
        Console.Clear();
        System.Console.WriteLine("####################################################");
        System.Console.WriteLine("Hello and welcome to the garage!");
        System.Console.WriteLine("####################################################");
        System.Console.WriteLine("Choose an action from the following list:");
        System.Console.WriteLine("####################################################");
        System.Console.WriteLine("(1) - Insert a new vehicle to the garage");
        System.Console.WriteLine("(2) - Display a list of license plates in the garage");
        System.Console.WriteLine("(3) - Change a vehicle's status");
        System.Console.WriteLine("(4) - Inflate a vehicle's wheels to maximum");
        System.Console.WriteLine("(5) - Refuel a vehicle");
        System.Console.WriteLine("(6) - Charge an electric vehicle");
        System.Console.WriteLine("(7) - Display a vehicle's full details");
        System.Console.WriteLine("(8) - Exit the garage");
        System.Console.WriteLine("####################################################");
    }
}