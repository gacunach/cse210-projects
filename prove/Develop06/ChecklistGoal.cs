public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) 
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        _points += 50;
        if (_amountCompleted >= _target)
        {
            _points += _bonus;
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{_shortName}: {_description} - {_points} points (Complete: {IsComplete()}) " +
               $"[{_amountCompleted}/{_target} completions, Bonus: {_bonus} points]";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal: {_shortName}, {_description}, {_points}, {_target}, {_bonus}, {_amountCompleted}";
    }
    
}