namespace ExerciseSet04;
class Program
{
    static void Main(string[] args)
    {
        DisplayOddNumbersOnlyUsingForLoop();
        //DisplayEvenNumbersOnlyUsingWhileLoop();
        //DisplayNumbersInReverseOrder();
        //CheckIfDivisibleByThree();
        //NumberNotDivisbleByFour();
    }

    private static void DisplayOddNumbersOnlyUsingForLoop()
    {
        /*
        Write a program that uses a for loop to count from 1 to 10, 
        but only displays the odd numbers.
        */
        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0) continue;
            Console.WriteLine(i);
        }
    }

    private static void DisplayEvenNumbersOnlyUsingWhileLoop()
    {
        /*
        Write a program that uses a while loop to count from 1 to 10, 
        but only displays the even numbers.
        */
        int i = 1;
        while (i <= 10)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
                i++;
                continue;
            }
            i++;
        }
    }

    private static void DisplayNumbersInReverseOrder()
    {
        /*
        Write a program that uses a do-while loop to count from 1 to 10, 
        but displays the numbers in reverse order.
        */
        int i = 1;
        do
        {
            Console.WriteLine(10 - i + 1);
            if (i == 10) break;

            i++;
        } while (true);
    }

    private static void CheckIfDivisibleByThree()
    {
        /*
        Write a program that asks the user to enter a number, and then 
        uses a for loop to count from 1 to that number, but only displays 
        the numbers that are divisible by 3.
        */
        Console.WriteLine("Please enter a number from 1 to 100: ");
        string? numberString = Console.ReadLine();
        if (null != numberString)
        {
            int number = int.Parse(numberString);

            for (int i = 1; i < number; i++)
            {
                if (i % 3 != 0)
                {
                    continue;
                }

                Console.WriteLine(i);
            }
        }
    }

    private static void NumberNotDivisbleByFour()
    {
        /*
        Write a program that asks the user to enter a number, and then 
        uses a while loop to count from 1 to that number, but only displays 
        the numbers that are not divisible by 4.
        */
        Console.WriteLine("Please enter a number from 1 to 100: ");
        string? numberString = Console.ReadLine();
        if (null != numberString)
        {
            int number = int.Parse(numberString);

            int i = 1;

            while (i < number)
            {
                if (i % 4 == 0)
                {
                    i++;
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                    i++;
                }
            }
        }
    }

}
