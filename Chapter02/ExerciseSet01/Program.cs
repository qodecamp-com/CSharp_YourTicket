namespace ExerciseSet01;
class Program
{
    static void Main(string[] args)
    {
        /*
        Declare a string variable called "name" and assign it your own name. 
        Then, print out the value of the variable to the console.
        */
        string name = "Andy";
        Console.WriteLine("name = {0}", name);

        /*
        Declare an integer variable called "age" and assign it your own age. 
        Then, print out the value of the variable to the console.
        */
        int age = 35;
        Console.WriteLine("age = {0}", age);

        /*
        Declare a double variable called "temperature" and assign it a value of 98.6. 
        Then, print out the value of the variable to the console.
        */
        double temperature = 98.6;
        Console.WriteLine("temperature = {0}", temperature);

        /*
        Declare a boolean variable called "isRaining" and assign it a value of true or false 
        based on the current weather. Then, print out the value of the variable to the console.
        */
        bool isRaining = false;
        Console.WriteLine("isRaining = {0}", isRaining);

        /*
        Declare a char variable called "initial" and assign it the first letter of your name. 
        Then, print out the value of the variable to the console.
        */
        char initial = 'A';
        Console.WriteLine("initial = {0}", initial);

        /*
        Declare a variable of a custom type that you create yourself. 
        For example, you could create a "Person" type with variables for "name" and "age". 
        Then, create an instance of your custom type and assign values to its variables. 
        Finally, print out the values of the variables to the console.

        NOTE: Refer to Person.cs for the definition of a custom type called "Person"
        */
        Person andy = new Person("Andy", 35);
        andy.printDetails();
    }
}


