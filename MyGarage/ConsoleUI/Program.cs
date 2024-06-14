

public class Program
{
    private static GarageManager s_GarageManager = new();

    public static void Main()
    {

        // s_GarageManager.addVehicleToGarage();
        DisplayMainMenu();
        try
        {
            int userChoiceFromMenu = InputValidator.getUserSelectionFromMenu(1, 8);
        
            // int userFuncionalityChoice = InputValidator.getUserSelectionFromMenu(1);
            // if (userFuncionalityChoice == 1)
            // {
            //     InsertNewVehicle();
            // }
            
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
            Console.WriteLine("Goodbye!");
        }
    }

    private static void InsertNewVehicle()
    {
        Dictionary<string, object> vehicleDetails = new Dictionary<string, object>();

        // Ask for vehicle license plate
        string licensePlate = InputValidator.GetDetailsAboutVehicle("License Plate");

        // Check if the vehicle is already in the garage
        if (s_GarageManager.IsVehicleInGarage(licensePlate))
        {
            Console.WriteLine("Vehicle is already in the garage!");
            Console.WriteLine("Vehicle status changed to 'InFix'");
            s_GarageManager.VehicelsInGarage[licensePlate].VehicleStatus = GarageManager.eVehicleStatus.InFix;
        }
        else
        {
            Console.WriteLine("Vehicle is new!");
            DisplayVehicleOptions();

            string vehicleType = InputValidator.getUserSelectionFromMenu(1, 5).ToString();
            vehicleDetails.Add("VehicleType", vehicleType);

            // Ask for owner name and phone number
            string ownerName = InputValidator.GetDetailsAboutVehicle("Owner Name");
            vehicleDetails.Add("OwnerName", ownerName);

            string ownerPhoneNumber = InputValidator.GetDetailsAboutVehicle("Owner Phone Number");
            vehicleDetails.Add("OwnerPhoneNumber", ownerPhoneNumber);

            // Ask for vehicle details
            string vehicleCurrentEnergy = InputValidator.GetDetailsAboutVehicle("Energy");
            vehicleDetails.Add("CurrentEnergy", vehicleCurrentEnergy);

            string vehicleCurrentAirPressure = InputValidator.GetDetailsAboutVehicle("Air Pressure");
            vehicleDetails.Add("CurrentAirPressure", vehicleCurrentAirPressure);

            if (vehicleType == "1" || vehicleType == "2") // ElectricCar or GasCar
            {
                string vehicleColor = InputValidator.GetDetailsAboutVehicle("Color");
                vehicleDetails.Add("Color", vehicleColor);

                string vehicleNumOfDoors = InputValidator.GetDetailsAboutVehicle("Number of doors");
                vehicleDetails.Add("NumOfDoors", vehicleNumOfDoors);
            }
            else if (vehicleType == "3" || vehicleType == "4") // ElectricMotorcycle or GasMotorcycle
            {
                string vehicleLicenseType = InputValidator.GetDetailsAboutVehicle("License Type");
                vehicleDetails.Add("LicenseType", vehicleLicenseType);

                string vehicleEngineVolume = InputValidator.GetDetailsAboutVehicle("Engine Volume");
                vehicleDetails.Add("EngineVolume", vehicleEngineVolume);
            }
            else if (vehicleType == "5") // Truck
            {
                string vehicleCarryingCapacity = InputValidator.GetDetailsAboutVehicle("Carrying Capacity");
                vehicleDetails.Add("CarryingCapacity", vehicleCarryingCapacity);

                string isCarryingDangerousMaterials = InputValidator.IsCarryingDangerousMaterials();
                vehicleDetails.Add("IsCarryingDangerousMaterials", isCarryingDangerousMaterials);
            }
            

            try
            {
                ValidateVehicleDetails(vehicleDetails);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }

private static void ValidateVehicleDetails(Dictionary<string, object> i_VehicleDetails)
{
    foreach (KeyValuePair<string, object> detail in i_VehicleDetails)
    {
        switch (detail.Key)
        {
            case "VehicleType":
                // Need to convert it to a GarageManager.eVehicleTypes
                break;
            case "OwnerName":
                // Need to check if it's a valid name
                break;
            case "OwnerPhoneNumber":
                // Need to check if it's a valid phone number
                break;
            case "CurrentEnergy":
                // Need to check if it's a valid energy value
                break;

            default:
                break;
        }
    }
}

private static void printVehicleDetails(Dictionary<string, string> vehicleDetails)
{
    Console.Clear();
    Console.WriteLine("Vehicle details:");
    foreach (KeyValuePair<string, string> detail in vehicleDetails)
    {
        Console.WriteLine(detail.Key + ": " + detail.Value);
    }
}

public static void DisplayMainMenu()
        {
            Console.Clear();
            Console.WriteLine(

@"####################################################
Hello and welcome to the garage!
####################################################
Choose an action from the following list:
####################################################
(1) - Insert a new vehicle to the garage
(2) - Display a list of license plates in the garage
(3) - Change a vehicle's status
(4) - Inflate a vehicle's wheels to maximum
(5) - Refuel a vehicle
(6) - Charge an electric vehicle
(7) - Display a vehicle's full details
(8) - Exit the garage
####################################################
");
        }

public static void DisplayVehicleOptions()
{

    Console.Clear();
    Console.WriteLine(
@"Enter the vehicle type:
(1) - Gas car 
(2) - Electric car 
(3) - Motorcycle on gas
(4) - Electric Motorcycle
(5) - Truck");

}

        private static void AskForVehicleStatus()
        {
            Console.Clear();
            Console.WriteLine("");
        }

}