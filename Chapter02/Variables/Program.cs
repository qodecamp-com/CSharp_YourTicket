namespace Variables;
class Program
{
    static void Main(string[] args)
    {
        //declare some variables
        int age;
        string name;
        bool isValid;

        //assign values to variables
        age = 30;
        name = "John";
        isValid = true;

        //print out the values stored in the variables
        Console.WriteLine("age = {0}", age);
        Console.WriteLine("name = {0}", name);
        Console.WriteLine("isValid = {0}", isValid);

        //you can also print multiple variables in a single print statement
        Console.WriteLine("Your name is {0}, and your age is {1}", name, age);
    }
}
