

public class Program
{
    private static GarageManager s_GarageManager = new();

    public static void Main()
    {

        s_GarageManager.addVehicleToGarage();

        DisplayMainMenu();
        try
        {
            int userChoiceFromMenu = InputValidator.getUserSelectionFromMenu(1, 8);
        
            switch (userChoiceFromMenu)
            {
                case 1:
                    InsertNewVehicle();
                    break;
                case 2:
                    DisplayFilterOptions();
                    DisplayCurrentLicensePlates();
                    break;
                case 3:
                    ChangeVehicleState();
                    break;
                
                default:
                    break;
            }

            
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
            s_GarageManager.VehicelsInGarage[licensePlate].VehicleStatus = Vehicle.eVehicleStatus.InFix;
        }
        else
        {
            Console.WriteLine("Vehicle is new!");
            DisplayVehicleOptions();

            string vehicleType = InputValidator.getUserSelectionFromMenu(1, 5).ToString();
            vehicleDetails.Add("VehicleType", vehicleType);

            string ownerName = InputValidator.GetDetailsAboutVehicle("Owner Name");
            vehicleDetails.Add("OwnerName", ownerName);

            string ownerPhoneNumber = InputValidator.GetDetailsAboutVehicle("Owner Phone Number");
            vehicleDetails.Add("OwnerPhoneNumber", ownerPhoneNumber);

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
                Dictionary<string, object> validatedVehicleDetails = InputValidator.ValidateAndGetVehicleDetails(vehicleDetails); 
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message + "Please enter a number!");
            }
            catch (ValueOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }

// private static void printVehicleDetails(Dictionary<string, string> vehicleDetails)
// {
//     Console.Clear();
//     Console.WriteLine("Vehicle details:");
//     foreach (KeyValuePair<string, string> detail in vehicleDetails)
//     {
//         Console.WriteLine(detail.Key + ": " + detail.Value);
//     }
// }

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

        public static bool isVehicleInGarage(string i_LicensePlate)
        {
            bool isVehicleInGarage = false;
            if (s_GarageManager.IsVehicleInGarage(i_LicensePlate))
            {
                isVehicleInGarage = true;
            }
            else
            {
                throw new ArgumentException(string.Format("Vehicle with license plate {0} is not in the garage!", i_LicensePlate));
            }
            return isVehicleInGarage;
        }

        private static void DisplayCurrentLicensePlates()
        {
            Vehicle.eVehicleStatus status = Vehicle.eVehicleStatus.InFix;
            List<string> licenseIDS = new List<string>();

            int filterOption = InputValidator.getUserSelectionFromMenu(1, 4);

            if (filterOption == 1) //display all the vehicles in the garage
            {
                licenseIDS = s_GarageManager.VehicelsInGarage.Keys.ToList();
            }
            else
            {
                if (filterOption == 2) //infix
                {
                    status = Vehicle.eVehicleStatus.InFix;
                }

                else if (filterOption == 3) //fixed
                {
                    status = Vehicle.eVehicleStatus.Fixed;
                }
                else //paid
                {
                    status = Vehicle.eVehicleStatus.Paid;
                }

                List<Vehicle> v = s_GarageManager.VehicelsInGarage.Values.Where(vehicle => vehicle.VehicleStatus == status).ToList();
                foreach (Vehicle vehicle in v)
                {
                    licenseIDS.Add(vehicle.LicenseID);
                }

            }

            if (licenseIDS.Count == 0)
            {
                Console.WriteLine("There are no {0} vehicles in the garage right now.", status);
            }
            else
            {
                int carNumber = 1;
                foreach (string licenseID in licenseIDS)
                {
                    Console.WriteLine("{0}. {1}", carNumber++, licenseID);
                }
            }
        }


        private static void ChangeVehicleState()
        {
            Vehicle.eVehicleStatus status = Vehicle.eVehicleStatus.InFix;
        
            string licensePlate = InputValidator.GetExistingVehicleLicensePlate();
            DisplayVehicleStates();
            int vehicleState = InputValidator.getUserSelectionFromMenu(1, 3);

            switch (vehicleState)
            {
                case 1:
                    status = Vehicle.eVehicleStatus.InFix;
                    break;

                case 2:
                    status = Vehicle.eVehicleStatus.Fixed;
                    break;

                case 3:
                    status = Vehicle.eVehicleStatus.Paid;
                    break;
            }

            s_GarageManager.VehicelsInGarage[licensePlate].VehicleStatus = status;
        }

        private static void DisplayFilterOptions()
        {
            Console.Clear();
            Console.WriteLine(
@"Choose which license plates do you want to see:
(1) - All vehicles
(2) - InFix vehicles 
(3) - Fixed vehicles
(4) - Paid vehicles
");
        }
        public static void DisplayVehicleStates()
        {
            Console.Clear();
            Console.WriteLine(
@"Enter the new vehicle's state:  
(1) - InFix 
(2) - Fixed 
(3) - Paid
");
        }

}