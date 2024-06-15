public class ElectricVehicle : Vehicle
{

    public ElectricVehicle()
    {
        if (this is ElectricMotorcycle)
        {
            MaxBatteryTime = 2.5f;
            Wheels = new Wheel[2];
            Wheels[0] = new Wheel("Michellin", 33f, 33f);
            Wheels[1] = new Wheel("Michellin", 33f, 33f);
        }
        else if (this is ElectricCar)
        {
            MaxBatteryTime = 3.5f;
            Wheels = new Wheel[5];
            for (int i = 0; i < Wheels.Length; i++)
            {
                Wheels[i] = new Wheel(string.Format("Michellin{0}", i), 31f, 31f);
            }
        }
    }
        
    private float m_EnergyLeft;
    private float m_MaxBatteryTime;
    
    public float EnergyLeft
    {
        get { return m_EnergyLeft; }
        set { m_EnergyLeft = value; }
    }

    public float MaxBatteryTime 
    { 
        get { return m_MaxBatteryTime; }
        set { m_MaxBatteryTime = value; }
    }

    public void ChargeBattery(float i_AmountOfHoursToCharge)
    {
        if (i_AmountOfHoursToCharge + m_EnergyLeft <= m_MaxBatteryTime)
        {
            m_EnergyLeft += i_AmountOfHoursToCharge;
        }
        else
        {
            throw new ValueOutOfRangeException(0, m_MaxBatteryTime - m_EnergyLeft);
        }
    }
    

}