public abstract class Activity
{
    private string _date;
    private float _length;

    public Activity(string date, float length)
    {
        _date = date;
        _length = length;
    }

    public string GetDate()
    {
        return _date;
    }

    public float GetLength()
    {
        return _length;
    }

    public abstract float GetDistance();
    public abstract float GetSpeed();
    public abstract float GetPace();
    public virtual string GetSummary()
    {
        return "";
    }
}