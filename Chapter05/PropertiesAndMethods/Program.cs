namespace PropertiesAndMethods;
class Program
{
    /// <summary>
    /// Write a method IsEven that takes in an integer 
    /// and returns a boolean indicating whether the number is even.
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    private static bool IsEven(int number)
    {
        if (number % 2 == 0) return true;
        else return false;
    }

    static void Main(string[] args)
    {
        //Question 1
        Rectangle rect1 = new Rectangle(10, 20);
        int area = rect1.GetArea();
        Console.WriteLine("Area of the rectangle: " + area);

        //Question 2
        Circle circle1 = new Circle(5.5f);
        Console.WriteLine("Circumference of the Circle: {0}", circle1.GetCircumference());
        Console.WriteLine("Area of the Circle: {0}", circle1.GetArea());

        //Question 3
        Console.WriteLine("Is 3 even? - {0}", IsEven(3));
        Console.WriteLine("Is 8 even? - {0}", IsEven(8));

        //Question 4
        Student student1 = new Student("Andy", "V");
        Console.WriteLine("Student's full name is {0}", student1.FullName);

        //Question 5
        RandomNumberGenerator rng = new RandomNumberGenerator();
        Console.WriteLine("Random Number between 1 to 100: {0}", rng.GenerateRandomNumber());
    }
}
