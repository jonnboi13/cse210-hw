public abstract class Activity
{
    private string _date;
    private int _lengthInMinutes;

    protected Activity(string date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    public string Date => _date;
    public int LengthInMinutes => _lengthInMinutes;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_lengthInMinutes} min)- Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}
