using System.ComponentModel;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        string checkbox = IsComplete() ? "[X]" : "[ ]";
        return $"{checkbox} {_shortName} ({_description})";
    }
   
    public abstract string GetStringRepresentation();

    public string GetName()
    {
        return _shortName;
    } 
    public string GetDescription()
    {
        return _description;
    } 
    public int GetPoints()
    {
        return _points;
    } 
}