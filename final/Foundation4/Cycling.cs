public class Cycling : Activity
{
    private double _speed; // in mph or kph

    public Cycling(DateTime date, int duration, double speed)
        : base(date, duration)
    {
        _speed = speed;
    }

    public override double GetDistance() => (Duration * _speed) / 60;

    public override double GetSpeed() => _speed;

    public override double GetPace() => 60 / _speed;

    protected override string GetDistanceUnit() => "miles"; // or "kilometers"

    protected override string GetSpeedUnit() => "mph"; // or "kph"

    protected override string GetPaceUnit() => "min per mile"; // or "min per km"
}
