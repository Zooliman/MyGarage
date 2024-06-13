public interface IElectricVehicle
{
    float GetRemainingBatteryHours
    {
        get;
    }

    float GetMaxBatteryTime 
    { 
        get;
    }

    void ChargeBattery(float i_AmountOfHoursToCharge);
    

}