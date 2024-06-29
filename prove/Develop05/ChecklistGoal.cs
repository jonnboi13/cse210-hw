public class ChecklistGoal : Goal
{
    private int _progress;
    private int _target;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int target, int bonusPoints)
        : base(name, description, points)
    {
        _progress = 0;
        _target = target;
        _bonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        if (_progress < _target)
        {
            _progress++;
            if (_progress == _target) // Check if the goal is now complete
            {
                return _points + _bonusPoints; // Return points with bonus points
            }
            return _points; // Return points without bonus points if not complete
        }

        else
        {
            Console.WriteLine("Goal already completed");
            return 0;
        }

    }

    public override bool IsComplete()
    {
        return _progress >= _target;
    }

    public override string GetStatus()
    {
        return $"Completed {_progress}/{_target} times:";
    }

    public override string Serialize()
    {
        return $"{GetType().Name},{_name},{_description},{_points},{_progress},{_target},{_bonusPoints}";
    }

    public override void Deserialize(string[] data)
    {
        _name = data[1];
        _description = data[2];
        _points = int.Parse(data[3]);
        _progress = int.Parse(data[4]);
        _target = int.Parse(data[5]);
        _bonusPoints = int.Parse(data[6]);
    }
}
