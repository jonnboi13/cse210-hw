public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int lengthInMinutes, double speed)
        : base(date, lengthInMinutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * LengthInMinutes) / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return $"{Date} Cycling ({LengthInMinutes} min)- Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}
