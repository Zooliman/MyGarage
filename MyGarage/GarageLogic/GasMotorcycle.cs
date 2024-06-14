class GasMotorcycle : Motorcycle, IGasVehicle
{
    public eGasType GasType
    {
        get { return eGasType.Octan98; }
    }

    public float GetCurrentGasAmount
    {
        get { return EnergyLeftPercents; }
    }

    public float GetMaxGasAmount
    {
        get { return 5.5f; }
    }

    void IGasVehicle.Fuel(float i_GasAmountToAdd, eGasType i_GasType)
    {

    }

}