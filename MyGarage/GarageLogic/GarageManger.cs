using System.Text;

public class GarageManager
{
    private List<Vehicle> m_VehiclesInGarage;

    public GarageManager()
    {
        m_VehiclesInGarage = new List<Vehicle>();
    }

    public void InsertVehicle(Vehicle i_VehicleToInsert)
    {
        try
        {
            m_VehiclesInGarage.Add(i_VehicleToInsert);
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
        }
        m_VehiclesInGarage.Add(i_VehicleToInsert);
    }

    public bool IsVehicleInGarage(string licensePlate)
    {
        bool isVehicleInGarage = false;

        foreach (Vehicle vehicle in m_VehiclesInGarage)
        {
            if (vehicle.Equals(licensePlate))
            {
                isVehicleInGarage = true;
                vehicle.VehicleStatus = Vehicle.eVehicleStatus.InFix;
                break;
            }
        }
        return isVehicleInGarage;
    }
}