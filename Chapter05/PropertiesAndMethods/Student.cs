namespace PropertiesAndMethods;

class Student
{
    string _firstName, _lastName;

    public Student(string firstName, string lastName)
    {
        this._firstName = firstName;
        this._lastName = lastName;
    }

    public string FullName
    {
        get
        {
            return _firstName + " " + _lastName;
        }
    }
}