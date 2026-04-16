public abstract class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    // Shared "Getter" for the summary
    public int GetMinutes() => _minutes;
    public string GetDate() => _date;

    // These MUST be overridden in derived classes
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Defined once in the base class to avoid duplication
    public virtual string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_minutes} min): " +
               $"Distance {GetDistance():0.1} miles, Speed {GetSpeed():0.1} mph, " +
               $"Pace: {GetPace():0.1} min per mile";
    }
}