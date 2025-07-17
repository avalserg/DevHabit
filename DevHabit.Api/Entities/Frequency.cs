namespace DevHabit.Api.Entities;

/// <summary>
/// How often we perform the Habit
/// </summary>
public sealed class Frequency
{
    public FrequencyType Type { get; set; }
    public int TimesPerPeriod { get; set; }
}
