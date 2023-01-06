namespace Exercises_Functions;
class Program
{

    /// <summary>
    /// Write a function that takes two integers as parameters and returns 
    /// the sum of the two numbers. 
    /// Call the function from your main program and display the result.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    public static int sumOfTwoNumbers(int a, int b)
    {
        return a + b;
    }

    /// <summary>
    /// Write a function that takes a string as a parameter and returns 
    /// the string with all vowels removed. 
    /// Call the function from your main program and display the result.
    /// </summary>
    /// <param name="inputString"></param>
    /// <returns></returns>
    public static string removeVowels(string inputString)
    {
        string outputString = "";

        foreach (char ch in inputString)
        {
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                continue;
            }
            else
            {
                outputString += ch;
            }
        }

        return outputString;
    }

    /// <summary>
    /// Write a function that takes three integers as parameters and 
    /// returns the largest of the three numbers. 
    /// Call the function from your main program and display the result.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="c"></param>
    /// <returns></returns>
    public static int LargestOfThreeNumbers(int a, int b, int c)
    {
        if (a > b)
        {
            if (a > c) return a;
            else return c;
        }
        else // b is greater than a
        {
            if (b > c) return b;
            else return b;
        }
    }

    /// <summary>
    /// Write a function that takes a double as a parameter and 
    /// returns the square root of the number. 
    /// Call the function from your main program and display the result.
    /// </summary>
    /// <param name="inputNumber"></param>
    /// <param name="outputNumber"></param>
    /// <returns></returns>
    public static double SquareRoot(double inputNumber)
    {
        return Math.Sqrt(inputNumber);
    }

    /// <summary>
    /// Write a function that takes a string as a parameter and 
    /// returns the string in all uppercase. 
    /// Call the function from your main program and display the result.
    /// </summary>
    /// <param name="inputString"></param>
    /// <returns></returns>
    public static string AllCaps(string inputString)
    {
        return inputString.ToUpper();
    }

    static void Main(string[] args)
    {
        //Question 1
        int x = 10;
        int y = 20;
        int z = sumOfTwoNumbers(x, y);
        Console.WriteLine("Sum = {0}", z);

        //Question 2
        string removeVowelsFromThisString = "Learning CSharp!";
        string withVowelsRemoved = removeVowels(removeVowelsFromThisString);
        Console.WriteLine(withVowelsRemoved);

        //Question 3
        int num1 = 5;
        int num2 = 25;
        int num3 = 10;
        int largestNumber = LargestOfThreeNumbers(num1, num2, num3);
        Console.WriteLine("Largest Number = {0}", largestNumber);

        //Question 4
        double inputNumber = 26.0;
        double sqrtNumber = SquareRoot(inputNumber);
        Console.WriteLine("Square root = {0}", sqrtNumber);

        //Question 5
        string inputString = "Learning CSharp!";
        string allCapsOutput = AllCaps(inputString);
        Console.WriteLine(allCapsOutput);
    }
}
