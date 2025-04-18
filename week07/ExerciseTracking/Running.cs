public class Running : Activity
{
    private float _distance;

    public Running(string date, float length, float distance) : base (date, length)
    {
        _distance = distance;
    } 

    public override float GetDistance()
    {
        return _distance;
    }

    public override float GetSpeed()
    {
        return _distance / GetLength() * 60;
    }

    public override float GetPace()
    {
        return GetLength() / _distance;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetLength()}min) - Distance {GetDistance()}km, speed {GetSpeed()}km/h, Pace: {GetPace()}min per km ";
    }
    
}