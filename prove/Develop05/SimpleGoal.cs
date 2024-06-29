public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        if (_isComplete == true)
        {
            Console.WriteLine("Goal already completed");
            return 0;
        }
        else
        {
            _isComplete = true;
            return _points;
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStatus()
    {
        return _isComplete ? "[X]" : "[ ]";
    }

    public override string Serialize()
    {
        return $"{GetType().Name},{_name},{_description},{_points},{_isComplete}";
    }

    public override void Deserialize(string[] data)
    {
        _name = data[1];
        _description = data[2];
        _points = int.Parse(data[3]);
        _isComplete = bool.Parse(data[4]);
    }
}
