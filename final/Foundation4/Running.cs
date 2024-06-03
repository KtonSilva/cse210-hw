public class Running : Activity
{
    private double _distance; // in miles or kilometers

    public Running(DateTime date, int duration, double distance)
        : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;

    public override double GetSpeed() => (GetDistance() / Duration) * 60;

    public override double GetPace() => Duration / GetDistance();

    protected override string GetDistanceUnit() => "miles"; // or "kilometers"

    protected override string GetSpeedUnit() => "mph"; // or "kph"

    protected override string GetPaceUnit() => "min per mile"; // or "min per km"
}
