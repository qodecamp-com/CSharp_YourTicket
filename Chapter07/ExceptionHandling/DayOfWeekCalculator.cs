namespace ExceptionHandling;

public class DayOfWeekCalculator
{
    public string GetDayOfWeek(int num)
    {
        string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        if (num < 1 || num > 7)
        {
            throw new ArgumentOutOfRangeException();
        }
        return daysOfWeek[num - 1];
    }
}