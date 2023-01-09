namespace Arrays;
class Program
{
    static void Main(string[] args)
    {
        //Question 1
        int[] myArray = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Sum of array elements = {0}", CustomArrayToolbox.SumOfArrayElements(myArray));
        Console.WriteLine("");

        //Question 2
        string[] names = { "Brandy", "Andy", "Sandy", "Randy", "Candy" };
        Console.WriteLine("Sorted list of names: ");
        CustomArrayToolbox.SortStringsInAlphabeticalOrder(names);
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine("");

        //Question 3
        int[] numberArray = { 1, 21, 13, 42, 5 };
        int secondHighestNumber = CustomArrayToolbox.FindSecondHighest(numberArray);
        Console.WriteLine("The Second Highest Number is {0}", secondHighestNumber);
        Console.WriteLine("");

        //Question 4
        string palindromeCheck = "Able was I ere I saw Elba";
        bool isPalindrome = CustomArrayToolbox.IsPalindrome(palindromeCheck);
        if (isPalindrome) Console.WriteLine("{0} is a Palindrome", palindromeCheck);
        else Console.WriteLine("{0} is not a Palindrome", palindromeCheck);
        Console.WriteLine("");

        //Question 5
        int[] numberArrayToReverse = { 77, 88, 33, 22, 45 };
        int[] reversedArray = CustomArrayToolbox.ReverseNumberArray(numberArrayToReverse);
        foreach (int i in reversedArray) Console.Write(i + " ");
        Console.WriteLine("");
    }
}
