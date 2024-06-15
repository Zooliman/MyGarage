public class GasVehicle : Vehicle
{
    private float m_GasLeft;
    private float m_MaxGasAmount;
    private eGasType m_GasType;

    public GasVehicle()
    {
        if (this is GasMotorcycle)
        {
            m_MaxGasAmount = 5.5f;
            m_GasType = eGasType.Octan98;
        }
        else if (this is GasCar)
        {
            m_MaxGasAmount = 45f;
            m_GasType = eGasType.Octan95;
        }
        else if (this is Truck)
        {
            m_MaxGasAmount = 120f;
            m_GasType = eGasType.Soler;
        }
    }


    public eGasType GasType
    {
        get { return m_GasType; }
        set { m_GasType = value; }
    }

    public float GasLeft
    {
        get { return m_GasLeft; }
    }

    public float MaxGasAmount
    {
        get { return m_MaxGasAmount; }
    }

    public void Fuel(float i_GasAmountToAdd, eGasType i_GasType)
    {
        if (i_GasType == GasType)
        {
            if (i_GasAmountToAdd + m_GasLeft <= m_MaxGasAmount)
            {
                m_GasLeft += i_GasAmountToAdd;
            }
            else
            {
                throw new ValueOutOfRangeException(0, m_MaxGasAmount - m_GasLeft);
            }
        }
        else
        {
            throw new ArgumentException("Wrong gas type");
        }
    }
    
    public enum eGasType
    {
        Soler,
        Octan95,
        Octan96,
        Octan98
    }
}
