namespace ExerciseSet02;
class Program
{
    static void Main(string[] args)
    {
        DisplayOneToTenUsingForLoop();
        //DisplayOneToTenUsingWhileLoop();
        //DisplayOneToTenUsingDoWhileLoop();
        //CountUpToUserProvidedNumberUsingForLoop();
        //CountUpToUserProvidedNumberUsingWhileLoop();
        //CountUpToUserProvidedNumberUsingDoWhileLoop();
    }

    private static void DisplayOneToTenUsingForLoop()
    {
        /*
        Write a program that uses a for loop to count from 1 to 10 
        and display the numbers to the console.
        */
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i + 1);
        }
    }

    private static void DisplayOneToTenUsingWhileLoop()
    {
        /*
        Write a program that uses a while loop to count from 1 to 10 
        and display the numbers to the console.
        */
        int i = 0;
        while (i < 10)
        {
            Console.WriteLine(i + 1);
            i++;
        }
    }

    private static void DisplayOneToTenUsingDoWhileLoop()
    {
        /*
        Write a program that uses a do-while loop to count from 1 to 10 
        and display the numbers to the console.
        */
        int i = 0;
        do
        {
            Console.WriteLine(i + 1);
            i++;
        } while (i < 10);
    }

    private static void CountUpToUserProvidedNumberUsingForLoop()
    {
        /*
        Write a program that asks the user to enter a number, and then 
        uses a for loop to count from 1 to that number and display the numbers to the console.
        */
        Console.WriteLine("Enter a number from 0 to 100: ");
        string? numberString = Console.ReadLine();
        if (null != numberString)
        {
            int number = int.Parse(numberString);
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(i + 1);
            }
        }
    }

    private static void CountUpToUserProvidedNumberUsingWhileLoop()
    {
        /*
        Write a program that asks the user to enter a number, and then 
        uses a while loop to count from 1 to that number and display the numbers to the console.
        */
        Console.WriteLine("Enter a number from 0 to 100: ");
        string? numberString = Console.ReadLine();
        if (null != numberString)
        {
            int number = int.Parse(numberString);
            int i = 0;
            while (i < number)
            {
                Console.WriteLine(i + 1);
                i++;
            }
        }
    }

    private static void CountUpToUserProvidedNumberUsingDoWhileLoop()
    {
        /*
        Write a program that asks the user to enter a number, and then 
        uses a while loop to count from 1 to that number and display the numbers to the console.
        */
        Console.WriteLine("Enter a number from 0 to 100: ");
        string? numberString = Console.ReadLine();
        if (null != numberString)
        {
            int number = int.Parse(numberString);
            int i = 0;
            do
            {
                Console.WriteLine(i + 1);
                i++;
            } while (i < number);
        }
    }
}
