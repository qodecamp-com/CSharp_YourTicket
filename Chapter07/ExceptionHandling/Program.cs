using System.Collections;

namespace ExceptionHandling;
class Program
{
    static void Main(string[] args)
    {
        /// By default, the program runs the solution to Question 1
        /// To execute solutions to other questions, please uncomment the method you wish to execute.
        /// Save the program, rebuild and run the program from the cmd line

        //Question 1
        SumOfIntegers();

        //Question 2
        //FileReader();

        //Question 3
        //DivisionOfIntegers();

        //Question 4
        //NameReader();

        //Question 5
        //ComputeDayOfWeek();
    }

    private static void ComputeDayOfWeek()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Enter a number (1-7): ");
                int num = int.Parse(Console.ReadLine());
                DayOfWeekCalculator calculator = new DayOfWeekCalculator();
                string day = calculator.GetDayOfWeek(num);
                Console.WriteLine("The corresponding day is: " + day);
                break;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Error: Please enter a number between 1 and 7.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                break;
            }
        }
    }

    private static void NameReader()
    {
        while (true)
        {
            Console.WriteLine("Enter a file name: ");
            string fileName = Console.ReadLine();

            try
            {
                List<string> names = new List<string>();
                StreamReader reader = new StreamReader(fileName);
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    names.Add(line);
                }
                reader.Close();
                Console.WriteLine("Names read from file: ");
                foreach (string name in names)
                {
                    Console.WriteLine(name);
                }
                break;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found. Creating a new file and writing names to it.");
                Console.WriteLine("Enter the names to be written to the file, separated by a comma: ");
                string namesInput = Console.ReadLine();
                string[] namesArray = namesInput.Split(',');
                StreamWriter writer = new StreamWriter(fileName);
                foreach (string name in namesArray)
                {
                    writer.WriteLine(name);
                }
                writer.Close();
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                break;
            }
        }
    }

    private static void DivisionOfIntegers()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Enter the first number: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the second number: ");
                int num2 = int.Parse(Console.ReadLine());

                int result = num1 / num2;
                Console.WriteLine("Result: " + result);
                break;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot divide by zero. Please try again.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                break;
            }
        }
    }

    private static void SumOfIntegers()
    {
        // Create an instance of the IntegerReader class
        IntegerReader reader = new IntegerReader();

        // Read integers from the file and add them to the ArrayList
        //Be sure to create a file called AA.txt in your Desktop folder and 
        //add some integers - one integer on each line
        //try it with all valid inputs first
        //then, change one of the lines and provide it a string value like apples or bananas
        //and try to run the program again.
        reader.ReadIntegers("./integers.txt");

        // Get the ArrayList of integers
        ArrayList integerList = reader.GetIntegerList();

        // Print the sum to the console
        int sum = 0;

        foreach (int integer in integerList)
        {
            sum += integer;
            Console.WriteLine("Sum = {0}", sum);
        }
    }

    private static void FileReader()
    {
        while (true)
        {
            Console.WriteLine("Enter a file name: ");
            string? fileName = Console.ReadLine();
            try
            {
                StreamReader reader = new StreamReader(fileName);
                string fileContents = reader.ReadToEnd();
                Console.WriteLine(fileContents);
                reader.Close();
                break;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found. Please enter a new file name.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading file: " + ex.Message);
                break;
            }
        }
    }

}
