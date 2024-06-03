using System;

public abstract class Activity
{
    private DateTime _date;
    private int _duration; // in minutes

    public Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public abstract double GetDistance(); // in miles or kilometers
    public abstract double GetSpeed(); // in mph or kph
    public abstract double GetPace(); // in minutes per mile or minutes per kilometer

    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {GetType().Name} ({_duration} min) - Distance: {GetDistance():F1} {GetDistanceUnit()}, Speed: {GetSpeed():F1} {GetSpeedUnit()}, Pace: {GetPace():F2} {GetPaceUnit()}";
    }

    protected int Duration => _duration;
    protected DateTime Date => _date;

    protected abstract string GetDistanceUnit();
    protected abstract string GetSpeedUnit();
    protected abstract string GetPaceUnit();
}
