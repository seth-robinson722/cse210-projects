public class NegativeGoal : Goal
{
    // Recording this goal subtracts points
    public NegativeGoal(string name, string description, int points) : base(name, description, points) { }

    public override int RecordEvent()
    {
        // Return negative points
        return -_points;
    }

    public override bool IsComplete() => false;

    public override string GetDetailsString()
    {
        return $"[!] {_shortName} ({_description}) [Penalty: -{_points}]";
    }

    public override string GetStringRepresentation()
    {
        return $"NegativeGoal:{_shortName},{_description},{_points}";
    }
}