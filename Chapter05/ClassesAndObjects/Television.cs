namespace ClassesAndObjects;

class Television
{
    string _brand;
    string _model;
    int _volume;

    public Television(string brand, string model, int volume)
    {
        this._brand = brand;
        this._model = model;
        this._volume = volume;
    }

    public void TurnOn()
    {
        Console.WriteLine("TV turning on...");
    }

    public void TurnOff()
    {
        Console.WriteLine("TV turning off...");
    }
}