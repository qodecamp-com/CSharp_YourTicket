namespace ClassesAndObjects;

class Person
{
    string _name;
    int _age;

    string _gender;

    public Person(string name, int age, string gender)
    {
        this._name = name;
        this._age = age;
        this._gender = gender;
    }

    public void Introduce()
    {
        Console.WriteLine("Hello, {0}", this._name);
    }
}