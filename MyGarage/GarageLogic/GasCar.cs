class GasCar : Car, IGasVehicle
{
    
    public eGasType GasType
    {
        get { return eGasType.Octan95; }
    }

    public float GetCurrentGasAmount
    {
        get { return EnergyLeftPercents; }
    }

    public float GetMaxGasAmount
    {
        get { return 45f; }
    }

    void IGasVehicle.Fuel(float i_GasAmountToAdd, eGasType i_GasType)
    {

    }
}

public enum eGasType
{
    Soler,
    Octan95,
    Octan96,
    Octan98
}