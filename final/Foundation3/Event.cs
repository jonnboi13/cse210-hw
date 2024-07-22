public abstract class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    protected Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.GetDetails()}";
    }

    public abstract string GetFullDetails();

    public abstract string GetShortDescription();
}
