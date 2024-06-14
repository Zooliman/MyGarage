public class Wheel
{
    private string m_ManufacturerName;
    private float m_CurrentAirPressure;
    private float m_MaxAirPressure;

    public Wheel(string i_ManufacturerName, float i_CurrentAirPressure, float i_MaxAirPressure)
    {
        m_ManufacturerName = i_ManufacturerName;
        m_CurrentAirPressure = i_CurrentAirPressure;
        m_MaxAirPressure = i_MaxAirPressure;
    }

    public string ManufacturerName
    {
        get { return m_ManufacturerName; }
        set { m_ManufacturerName = value; }
    }
    public float CurrentAirPressure
    {
        get { return m_CurrentAirPressure; }
        set { m_CurrentAirPressure = value; }
    }
    public float MaxAirPressure
    {
        get { return m_MaxAirPressure; }
        set { m_MaxAirPressure = value;} // not sure if we need
    }
    public void Inflate(float i_AmountOfAirPressureToAdd)
    {

    }
}