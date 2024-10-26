public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    protected string _isComplete;


    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _isComplete = "false";
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        return "";
    }

    public abstract string GetStringRepresentation();

    public int GetPoints()
    {
        return _points;
    }
    

}