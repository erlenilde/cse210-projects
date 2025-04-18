public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, float length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    public override float GetDistance()
    {
        return _laps * 50 / 1000;
    }

    public override float GetSpeed()
    {
        return GetDistance() / GetLength() * 60;
    }

    public override float GetPace()
    {
        return GetLength() / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Swimming ({GetLength()}min) - Distance {GetDistance()}km, speed {GetSpeed()}km/h, Pace: {GetPace()}min per km ";
    }
}