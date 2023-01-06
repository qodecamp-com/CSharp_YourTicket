namespace ExerciseSet01;
class Program
{
    //NOTE: You'll study methods/functions later in the book
    //but this is a good time to introduce this concept in code
    //As I had mentioned before, we'll use the Main method to drive the code
    //Solutions to each question in this exercise set has been converted to a method
    //simply uncomment the method/question you'd like to execute to see the result for a particular question
    //IMPORTANT: Only uncomment one method in Main at a time for best results
    static void Main(string[] args)
    {
        PositiveOrNegative(); //as you can see this runs the solution to the first question of the exercise
        //VowelOrConsonant();
        //AgeGroup();
        //CelciusToFahrenheit();
        //OddOrEven();
    }

    private static void PositiveOrNegative()
    {
        /*
        Write a program that asks the user to enter a number, 
        and then displays a message indicating whether the number is positive, negative, or zero.
        */
        Console.WriteLine("Enter a number (positive or negative): ");
        string? numberString = Console.ReadLine();

        if (null != numberString)
        {
            int number = int.Parse(numberString);
            if (number < 0)
            {
                Console.WriteLine("Number is negative");
            }
            else if (number > 0)
            {
                Console.WriteLine("Number is postive");
            }
            else
            {
                Console.WriteLine("Number is ZERO");
            }
        }
    }

    private static void VowelOrConsonant()
    {
        /*
        Write a program that asks the user to enter a letter of the alphabet, 
        and then displays a message indicating whether the letter is a vowel or a consonant.
        */

        Console.WriteLine("Enter an alphabet (in small caps): ");
        string? alphabetString = Console.ReadLine();

        if (null != alphabetString)
        {
            //extract the char
            char alphabet = alphabetString[0];

            if (alphabet == 'a' || alphabet == 'e' || alphabet == 'i' || alphabet == 'o' || alphabet == 'u')
            {
                Console.WriteLine("You entered a vowel");
            }
            else
            {
                Console.WriteLine("You entered a consonant");
            }
        }
    }

    private static void AgeGroup()
    {
        /*
        Write a program that asks the user to enter their age, 
        and then displays a message indicating whether the user is 
        an adult (age 18 or older), a teenager (age 13 to 17), 
        or a child (age 12 or younger).
        */

        Console.WriteLine("Enter your age: ");
        string? ageString = Console.ReadLine();

        if (null != ageString)
        {
            int age = int.Parse(ageString);

            if (age < 0)
            {
                Console.WriteLine("Invalid age entered!");
                return;
            }

            if (age < 12)
            {
                Console.WriteLine("You are a child!");
            }
            else if (age >= 12 && age < 18)
            {
                Console.WriteLine("You are a teenager!");
            }
            else if (age >= 18)
            {
                Console.WriteLine("You are an adult!");
            }
        }
    }

    private static void CelciusToFahrenheit()
    {
        /*
        Write a program that asks the user to enter a temperature in degrees Celsius, 
        and then displays the equivalent temperature in degrees Fahrenheit.
        */

        //NOTE: The formula to convert Celcius to Fahrenheit is F = C * 9/5 + 32

        Console.WriteLine("Enter the temperature in Celcius (use whole numbers only): ");
        string? C = Console.ReadLine();

        if (null != C)
        {
            int celcius = int.Parse(C);
            double F = (celcius * 9 / 5) + 32;

            Console.WriteLine("The temperature in Fahrenheit is {0}", F);
        }
    }

    private static void OddOrEven()
    {
        /*
        Write a program that asks the user to enter a number, 
        and then displays a message indicating whether the number is odd or even.
        */

        Console.WriteLine("Enter a number: ");
        string? numberString = Console.ReadLine();

        if (null != numberString)
        {
            int number = int.Parse(numberString);
            if (number % 2 == 0)
            {
                Console.WriteLine("Even Number!");
            }
            else
            {
                Console.WriteLine("Odd Number!");
            }
        }
    }

}
