namespace ExerciseSet03;
class Program
{
    static void Main(string[] args)
    {
        GradeCheck();
        //VowelOrConsonant();
        //PositiveNegativeOrZero();
        //NumberOfDaysInAGivenMonth();
        //WeekDayCheck();
        //LeapYearCheck();
    }

    private static void GradeCheck()
    {
        /*
        Write a program that declares a char variable called "grade" and assigns 
        it a letter grade (A, B, C, D, or F). Then, use a switch statement to 
        print out a message to the console based on the value of the grade. 
        For example, if the grade is an A, the message should say "Excellent job!"
        */
        char grade = 'A'; //change this to see different results
        switch (grade)
        {
            case 'A':
                Console.WriteLine("A Grade - Excellent!");
                break;
            case 'B':
                Console.WriteLine("B Grade - Good!");
                break;
            case 'C':
                Console.WriteLine("C Grade - Average!");
                break;
            case 'D':
                Console.WriteLine("D Grade - Not good!");
                break;
            case 'F':
                Console.WriteLine("F Grade - Fail!");
                break;
            default:
                Console.WriteLine("Invalid Grade!");
                break;
        }
    }

    private static void VowelOrConsonant()
    {
        /*
        Write a program that asks the user to enter a letter of the alphabet, 
        and then displays a message indicating whether the letter is a vowel or a consonant.
        */
        Console.WriteLine("Enter a single character (in small caps): ");
        string? alphabetString = Console.ReadLine();
        if (null != alphabetString)
        {
            if (alphabetString.Length > 1)
            {
                Console.WriteLine("Invalid input!");
                return;
            }

            char alphabet = alphabetString[0];
            switch (alphabet)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("You entered a vowel!");
                    break;
                default:
                    Console.WriteLine("You entered a consonant!");
                    break;
            }
        }
    }

    private static void PositiveNegativeOrZero()
    {
        /*
        Write a program that asks the user to enter a number, 
        and then displays a message indicating whether the number is positive, negative, or zero.
        */
        Console.WriteLine("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        switch (num)
        {
            case int n when n > 0:
                Console.WriteLine("The number is positive.");
                break;
            case int n when n < 0:
                Console.WriteLine("The number is negative.");
                break;
            default:
                Console.WriteLine("The number is zero.");
                break;
        }
    }

    private static void NumberOfDaysInAGivenMonth()
    {
        /*
        Write a program that asks the user to enter a month of the year (as a number), 
        and then displays the number of days in that month.    
        */
        Console.WriteLine("Enter a month (as a number): ");
        int month = Convert.ToInt32(Console.ReadLine());

        int days;
        switch (month)
        {
            case 2:
                days = 28;
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                days = 30;
                break;
            default:
                days = 31;
                break;
        }

        Console.WriteLine("The number of days in this month is: " + days);
    }

    private static void WeekDayCheck()
    {
        /*
        Write a program that asks the user to enter a day of the week, 
        and then displays a message indicating whether it is a weekday or a weekend.
        */
        Console.WriteLine("Enter a day of the week: ");
        string? dayString = Console.ReadLine();

        if (null != dayString)
        {
            string day = dayString.ToLower();
            switch (day)
            {
                case "saturday":
                case "sunday":
                    Console.WriteLine("It's the weekend!");
                    break;
                default:
                    Console.WriteLine("It's a weekday.");
                    break;
            }
        }
    }

    private static void LeapYearCheck()
    {
        /*
        Write a program that asks the user to enter a year, and then 
        displays a message indicating whether the year is a leap year or not.
        */
        Console.WriteLine("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        bool isLeapYear;
        switch (year % 4)
        {
            case 0:
                //check google one how to find out if a year is a leap year
                //that should help clear up this logic below
                isLeapYear = (year % 100 != 0 || year % 400 == 0);
                break;
            default:
                isLeapYear = false;
                break;
        }

        if (isLeapYear)
        {
            Console.WriteLine(year + " is a leap year.");
        }
        else
        {
            Console.WriteLine(year + " is not a leap year.");
        }
    }
}
