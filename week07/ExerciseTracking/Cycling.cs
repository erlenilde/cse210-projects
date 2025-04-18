public class Cycling : Activity
{
    private float _speed;

    public Cycling(string date, float length, float speed) : base(date, length)
    {
        _speed = speed;
    }

    public override float GetDistance()
    {
        return _speed * GetLength() / 60;
    }

    public override float GetSpeed()
    {
        return _speed;
    }

    public override float GetPace()
    {
        return GetLength() / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({GetLength()}min) - Distance {GetDistance()}km, speed {GetSpeed()}km/h, Pace: {GetPace()}min per km ";
    }
}