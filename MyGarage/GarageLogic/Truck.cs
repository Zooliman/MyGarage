public class Truck : GasVehicle
{
    private bool m_HasDangerousMaterials;
    private float m_CargoVolume;

    public Truck()
    {
        MaxGasAmount = 120f;
        GasType = eGasType.Soler;
    }
    public bool HasDangerousMaterials
    {
        get { return m_HasDangerousMaterials; }
        set { m_HasDangerousMaterials = value;}
    }

    public float CargoVolume
    {
        get { return m_CargoVolume; }
        set { m_CargoVolume = value;}
    }

}