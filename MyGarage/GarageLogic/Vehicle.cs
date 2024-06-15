public abstract class Vehicle
{
    private string m_ModelName;
    private string m_LicenseID;
    private float m_EnergyLeftPercentage;
    private Wheel[] m_Wheels;

    private string m_Owner;
    private string m_OwnerPhoneNumber;
    private GarageManager.eVehicleStatus m_VehicleStatus;

    public Vehicle()
    {
    
    }

    public string ModelName
    {
        get { return m_ModelName; }
        set { m_ModelName = value; }
    }

    public string LicenseID
    {
        get { return m_LicenseID; }
        set { m_LicenseID = value; }
    }

    public float EnergyLeftPrecentage
    {
        get { return m_EnergyLeftPercentage; }
        set { m_EnergyLeftPercentage = value; }
    }

    public Wheel[] Wheels
    {
        get { return m_Wheels; }
        set { m_Wheels = value; }
    }

    public string Owner
    {
        get { return m_Owner; }
        set { m_Owner = value; }
    }
    public string OwnerPhoneNumber
    {
        get { return m_OwnerPhoneNumber; }
        set { m_OwnerPhoneNumber = value; }
    }

    public GarageManager.eVehicleStatus VehicleStatus
    {
        get { return m_VehicleStatus; }
        set { m_VehicleStatus = value; }
    }

    public override bool Equals(object obj)
    {
        bool isEqual = false;
        try
        {
            isEqual = m_LicenseID.Equals(((Vehicle)obj).LicenseID);
        }
        catch
        {
            isEqual = false;
        }
        return isEqual;

    }

    public enum eLicenseType
    {
        A,
        A1,
        AA,
        B1
    }
}