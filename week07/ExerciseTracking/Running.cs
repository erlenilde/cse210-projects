public class Running : Activity
{
    private double _distance;

    public Running(string date, double length, double distance) : base (date, length)
    {
        _distance = distance;
    } 

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / GetLength() * 60;
    }

    public override double GetPace()
    {
        return GetLength() / _distance;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetLength()}min) - Distance {GetDistance()}km, speed {GetSpeed()}km/h, Pace: {GetPace()}min per km ";
    }
    
}