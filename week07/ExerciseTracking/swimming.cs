public class Swimming : Activity
{
    private int _laps;
    private const double MilesPerLap = 0.0310686;

    public Swimming(DateTime date, int minutes, int laps)
        : base (date, minutes, "Swimming")
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * MilesPerLap;
    }

    public override double GetSpeed()
    {
        return GetDistance() / GetMinutes() * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }

    public override string GetSummary()
    {
        return 
            $"{GetDate():dd MMM yyyy} Swimming ({GetMinutes()} min), " +
            $"Distance: {GetDistance():0.0} miles, " +
            $"Speed: {GetSpeed():0.0} mph, " +
            $"Pace: {GetPace():0.0} min per mile," +
            $" Laps: {_laps}";
    }

}