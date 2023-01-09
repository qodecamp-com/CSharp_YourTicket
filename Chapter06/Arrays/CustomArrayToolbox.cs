namespace Arrays;

class CustomArrayToolbox
{
    public static int SumOfArrayElements(int[] inputArray)
    {
        int sumOfArray = 0;

        foreach (int i in inputArray)
        {
            sumOfArray += i;
        }

        return sumOfArray;
    }

    public static void SortStringsInAlphabeticalOrder(string[] inputArray)
    {
        Array.Sort(inputArray);
    }

    public static int FindSecondHighest(int[] inputArray)
    {
        Array.Sort(inputArray);
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

        while (first != last)
        {
            if (lowerCaseString[first] == lowerCaseString[last])
            {
                first++;
                last--;
            }
            else
            {
                return false;
            }
        }
        return true;
    }

    public static int[] ReverseNumberArray(int[] inputArray)
    {
        int[] result = new int[inputArray.Length];

        int last = result.Length - 1;

        foreach (int i in inputArray)
        {
            result[last] = i;
            last--;
        }

        return result;
    }
}