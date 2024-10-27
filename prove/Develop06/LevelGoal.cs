public class LevelGoal : Goal
{
    private int _currentLevel;
    private int _maxLevel;
    private int _pointsPerLevel;

    public LevelGoal(string name, string description, int pointsPerLevel, int maxLevel) 
        : base(name, description, pointsPerLevel)
    {
        _pointsPerLevel = pointsPerLevel;
        _maxLevel = maxLevel;
        _currentLevel = 1;
    }

    public override void RecordEvent()
    {
        if (_currentLevel <= _maxLevel)
        {
            Console.WriteLine($"Completed level {_currentLevel} of '{_shortName}'!");
            _points += _pointsPerLevel;
            _currentLevel++;
            if (_currentLevel > _maxLevel)
            {
                Console.WriteLine($"Congratulations! You completed all levels for '{_shortName}'!");
            }
        }
        else
        {
            Console.WriteLine($"'{_shortName}' is already fully completed.");
        }
    }

    public override bool IsComplete()
    {
        return _currentLevel > _maxLevel;
    }

    public override string GetDetailsString()
    {
        return $"{_shortName}: {_description} - {_pointsPerLevel} - {_currentLevel}";
    }
    public override string GetStringRepresentation()
    {
        return $"{_shortName} (Level {_currentLevel}/{_maxLevel}) - {_description}";
    }
    
}