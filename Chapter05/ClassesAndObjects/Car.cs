namespace ClassesAndObjects;

class Car
{
    string _make;
    string _model;
    int _year;

    public Car(string make, string model, int year)
    {
        this._make = make;
        this._model = model;
        this._year = year;
    }

    public void StartEngine()
    {
        Console.WriteLine("Engine Starting...");
    }
}