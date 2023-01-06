namespace ExerciseSet01;
class Person
{
    string name;
    int age;

    public Person(string v1, int v2)
    {
        this.name = v1;
        this.age = v2;
    }

    public void printDetails()
    {
        Console.WriteLine("name = {0}", this.name);
        Console.WriteLine("age = {0}", this.age);
    }
}