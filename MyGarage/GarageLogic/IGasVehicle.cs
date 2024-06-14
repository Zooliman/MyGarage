public interface IGasVehicle
{
    eGasType GasType
    {
        get;
    }

    float GetCurrentGasAmount
    {
        get;
    }

    float GetMaxGasAmount
    {
        get;
    }

    void Fuel(float i_GasAmountToAdd, eGasType i_GasType);
    
}
