namespace ExerciseSet02;
class Program
{
    static void Main(string[] args)
    {
        //NOTE: I've added all the solutions to the Main program.
        //In the real world, we would write more modular code and it wouldn't look like this code
        //In the real world, we would use the Main program to act like a Driver program
        //Most of the functionality would be wrapped up inside Classes and Methods
        //You will learn about Classes and Methods later.

        /*
        Declare a variable of each data type: bool, char, int, double, string. 
        Initialize each variable with a value of your choosing, 
        then print out the value and type of each variable to the console.
        */
        bool isValid = false;
        char initial = 'R';
        int age = 35;
        double highPrecisionNumber = 19.333444555666777;
        string name = "Andy";

        Console.WriteLine("isValid = {0}", isValid);
        Console.WriteLine("initial = {0}", initial);
        Console.WriteLine("age = {0}", age);
        Console.WriteLine("highPrecisionNumber = {0}", highPrecisionNumber);
        Console.WriteLine("name = {0}", name);

        Console.WriteLine("------------------------");

        /*
        Write a program that prompts the user to enter a number. 
        Then, store the number in a variable of the appropriate data type. 
        Finally, print out the number on the console.
        */
        Console.WriteLine("Enter a number: ");
        string? userProvidedStringInput = Console.ReadLine();
        if (null != userProvidedStringInput)
        {
            int number = int.Parse(userProvidedStringInput);
            Console.WriteLine("The number you entered = {0}", number);
        }

        Console.WriteLine("------------------------");

        /*
        Write a program that prompts the user to enter their name and age. 
        Store the name in a string variable and the age in an int variable. 
        Then, print out a message to the console that says "Hello, [name]! You are [age] years old."
        */

        //not redeclaring name and age as they are already declared above for a previous exercise
        //if they weren't already declared, you must declare them like:
        //string name = "something";
        //int age = 35;
        name = "Bill";
        age = 35;

        Console.WriteLine("Hello, {0}! You are {1} years old.", name, age);

        Console.WriteLine("------------------------");

        /*
        Write a program that declares a double variable called "diameter" and 
        assign it a value of 12.5. Then, declare a second variable called "radius" and 
        assign it the value of the diameter divided by 2. Finally, print out the value of 
        the radius to the console.
        */
        double diameter = 12.5;
        double radius = diameter / 2;
        Console.WriteLine("radius = {0}", radius);
    }
}
