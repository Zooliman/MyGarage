abstract class Motorcycle : Vehicle
{
    private eLicenseType m_licenseType;
    private int m_EngineVolume;

    public enum eLicenseType
    {
        A,
        A1,
        AA,
        B1
    }
}