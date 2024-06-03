public class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, DateTime date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date.ToString("d")}\nTime: {_time}\nAddress: {_address.GetFullAddress()}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"Event Type: {GetType().Name}\nTitle: {_title}\nDate: {_date.ToString("d")}";
    }

    public string Title => _title;
    public string Description => _description;
    public DateTime Date => _date;
    public string Time => _time;
    public Address Address => _address;
}
