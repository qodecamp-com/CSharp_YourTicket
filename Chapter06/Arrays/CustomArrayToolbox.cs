namespace Arrays;

class CustomArrayToolbox
{
    public static int SumOfArrayElements(int[] inputArray)
    {
        //initialize the sum to zero
        int sumOfArray = 0;

        //loop through the elements adding it to the sum
        foreach (int i in inputArray)
        {
            sumOfArray += i;
        }

        //return the sum
        return sumOfArray;
    }

    public static void SortStringsInAlphabeticalOrder(string[] inputArray)
    {
        //in place sort the input array
        Array.Sort(inputArray);
    }

    public static int FindSecondHighest(int[] inputArray)
    {
        //in place sort the inputArray
        Array.Sort(inputArray);

        //return the second last element
        return inputArray[inputArray.Length - 2];
    }

    public static bool IsPalindrome(string inputString)
    {
        //convert all characters in the string to lowercase
        string lowerCaseString = inputString.ToLower();

        //create an index pointing the first character
        int first = 0;

        //create an index pointing to the last character
        int last = lowerCaseString.Length - 1;

        //run a loop until first and last are equal
        //the idea here is to compare the first and last elements
        //then, we check the second and the second last element and so on
        while (first != last)
        {
            //as long as they are equal, keep checking the next set of corresponding elements
            if (lowerCaseString[first] == lowerCaseString[last])
            {
                first++;
                last--;
            }
            else
            {
                //the comparison failed - meaning it's NOT a palindrome
                return false;
            }
        }

        //if we reached here that means all the comparisons are done
        //it is a palindrome
        return true;
    }

    public static int[] ReverseNumberArray(int[] inputArray)
    {
        //create a new result array that is the same length as the original array
        int[] result = new int[inputArray.Length];

        //set an index to the last element of the result array
        int last = result.Length - 1;

        //starting from the first element on the inputArray,
        //add the elements to the last index of the result array
        foreach (int i in inputArray)
        {
            result[last] = i;

            //after each assignment, decrement the last index
            last--;
        }

        //the result array will hold the reversed set of numbers from the inputArray
        return result;
    }
}