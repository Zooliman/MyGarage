class GasCar : Car, IGasVehicle
{
     // Max hours
    public eGasType GasType
    {
        get { return eGasType.Octan95; }
    }

    public float GetCurrentGasAmount
    {
        get { return EnergyLeft; }
    }

    public float GetMaxGasAmount
    {
        get { return 45f; }
    }

    void IGasVehicle.Fuel(float i_GasAmountToAdd, eGasType i_GasType)
    {

    }


}