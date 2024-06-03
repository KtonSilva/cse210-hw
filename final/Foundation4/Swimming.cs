public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int duration, int laps)
        : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance() => (_laps * 50) / 1000.0 * 0.62; // in miles, or without * 0.62 for kilometers

    public override double GetSpeed() => (GetDistance() / Duration) * 60;

    public override double GetPace() => Duration / GetDistance();

    protected override string GetDistanceUnit() => "miles"; // or "kilometers"

    protected override string GetSpeedUnit() => "mph"; // or "kph"

    protected override string GetPaceUnit() => "min per mile"; // or "min per km"
}
