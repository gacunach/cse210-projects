public class SimpleGoal : Goal
{

    private bool _isComplete;
    public SimpleGoal(string name, string description, int points) : base (name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete == true;
    }
    public override string GetDetailsString()
    {
        return $"{_shortName}: {_description} - {_points} points (Complete: {_isComplete})";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal: {_shortName}, {_description}, {_points}, {_isComplete}";
    }
    
}