class ElectricMotorcycle : Motorcycle, IElectricVehicle
{
    public ElectricMotorcycle()
    {

    }

    public float GetRemainingBatteryHours
    {
        get { return EnergyLeftPercents; }
    }

    public float GetMaxBatteryTime
    {
        get { return 2.5f; }
    }

    void IElectricVehicle.ChargeBattery(float i_AmountOfHoursToCharge)
    {

    }
}