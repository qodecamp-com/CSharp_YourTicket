namespace ExerciseSet03;
class Program
{
    static void Main(string[] args)
    {
        /*
        Declare a double variable and assign it a value of 3.5. 
        Then, declare an int variable and assign it the value of the double variable, using type conversion. 
        Finally, print out the value of the int variable to the console.
        */

        double doubleNumber = 3.5;
        int number = (int)doubleNumber;
        Console.WriteLine("number = {0}", number);

        Console.WriteLine("---------------------------");

        /*
        Declare a string variable and assign it a value of "4". 
        Then, declare an int variable and assign it the value of the string variable, 
        using type conversion. Finally, print out the value of the int variable to the console.
        */

        string numberString = "4";
        number = int.Parse(numberString);
        Console.WriteLine("number = {0}", number);

        Console.WriteLine("---------------------------");

        /*
        Declare a bool variable and assign it a value of true. 
        Then, declare an int variable and assign it the value of the bool variable, 
        using type conversion. Finally, print out the value of the int variable to the console.
        */

        bool isValid = true;
        number = Convert.ToInt32(isValid);
        Console.WriteLine("number = {0}", number);

        Console.WriteLine("---------------------------");

        /*
        Declare an int variable and assign it a value of 10. 
        Then, declare a double variable and assign it the value of the int variable, 
        using type conversion. Finally, print out the value of the double variable to the console.
        */

        int i = 10;
        doubleNumber = i;
        Console.WriteLine("doubleNumber = {0}", doubleNumber);

        Console.WriteLine("---------------------------");

        /*
        Write a program that prompts the user to enter a number in pounds (lbs). 
        Then, convert the entered value to kilograms (kgs) and print out 
        the result to the console. [Hint: 1 kilogram (kg) = 2.2 pounds/lbs ]
        */
        Console.WriteLine("Enter your weight in pounds/lbs: ");
        string? weight = Console.ReadLine();
        if (null != weight)
        {
            double weightInKgs = (int.Parse(weight)) / 2.2;
            Console.WriteLine("Your weight in Kilograms = {0}", weightInKgs);
        }

    }
}
