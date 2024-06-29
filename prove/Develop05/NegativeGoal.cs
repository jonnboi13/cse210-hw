public class NegativeGoal : Goal
{
    public NegativeGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        return -_points;
    }

    public override bool IsComplete()
    {
        return false; // Negative goals are never complete
    }

    public override string GetStatus()
    {
        return "[Neg]";
    }

    public override string Serialize()
    {
        return $"{GetType().Name},{_name},{_description},{_points}";
    }

    public override void Deserialize(string[] data)
    {
        _name = data[1];
        _description = data[2];
        _points = int.Parse(data[3]);
    }
}
