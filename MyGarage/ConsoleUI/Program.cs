
public class Program
{
    public static void Main()
    {
        bool isRunning = true;
        Dictionary<object, string> userInputs = new Dictionary<object, string>();

        GarageManager garageManager = new GarageManager();
        DisplayWelcomeMessage();


        while (isRunning)
        {
            string userChoice = Console.ReadLine();
            int userChoiceInt = int.Parse(userChoice); // This will throw an exception if the user input is not a number

            if (userChoiceInt == 1)
            {
                // Ask for vehicle license plate
                string licensePlate = InputValidator.GetLicensePlate();
                userInputs.Add("licensePlate", licensePlate);

                // Check if the vehicle is already in the garage
                if (garageManager.IsVehicleInGarage(licensePlate))
                {
                    System.Console.WriteLine("Vehicle is already in the garage!");
                    System.Console.WriteLine("Vehicle status changed to 'InFix'");
                }
                else
                {
                    // Ask for vehicle type to insert, then ask for vehicle status (Gas amount / Battery time left, Wheel's air pressure, Color & Number of doors (if car), License type (if motorcycle), Cargo volume (if truck), etc.)

                    // Insert the vehicle to the garage
                    // Dictionary<object, string> newVehicleDetails = InputValidator.GetVehicleDetails();
                }
            }
            else
            {
                isRunning = false;
            }
        
        }

        System.Console.WriteLine("Goodbye!");

    }

    // Check

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