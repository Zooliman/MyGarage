
public class OwnerDetails {

    private string m_OwnerName;
    private string m_OwnerPhone;

    public OwnerDetails(string i_OwnerName, string i_OwnerPhone)
    {
        m_OwnerName = i_OwnerName;
        m_OwnerPhone = i_OwnerPhone;
    }

    public string OwnerName
    {
        get { return m_OwnerName; }
        set { m_OwnerName = value; }
    }

    public string OwnerPhone
    {
        get { return m_OwnerPhone; }
        set { m_OwnerPhone = value; }
    }

}