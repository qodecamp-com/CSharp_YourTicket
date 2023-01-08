namespace PropertiesAndMethods;

public class RandomNumberGenerator
{
    private Random _random;

    public RandomNumberGenerator()
    {
        _random = new Random();
    }

    public int GenerateRandomNumber()
    {
        return _random.Next(1, 101);
    }
}
