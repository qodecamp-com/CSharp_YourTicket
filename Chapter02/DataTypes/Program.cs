namespace DataTypes;
class Program
{
    static void Main(string[] args)
    {
        //declare some variables
        int x;
        string name;

        //this line is commented because it will produce a compilation error 
        //as we are trying to access variables that haven't been assigned values
        //Console.WriteLine("x = {0}, and name = {1}", x, name);

        //let's assign some values and print them
        x = 10;
        name = "David";
        Console.WriteLine("x = {0}, and name = {1}", x, name);

        //let's declare variables of various data types
        bool isSunnyToday = true;
        byte oneByte = 1;
        char oneCharacter = 'a';
        decimal decimalNumber = 9.99999M;
        double doubleNumber = 15.888999777666;
        float floatingPointNumber = 1.0112233F;
        long longNumber = 999999999999999999;
        sbyte shortByte = 12;

        //let's print them out and see what we get on the console
        Console.WriteLine("Is it Sunny Today? -- {0}", isSunnyToday);
        Console.WriteLine("oneByte = {0}", oneByte);
        Console.WriteLine("oneCharater = {0}", oneCharacter);
        Console.WriteLine("decimalNumber = {0}", decimalNumber);
        Console.WriteLine("doubleNumber = {0}", doubleNumber);
        Console.WriteLine("floatingPointNumber = {0}", floatingPointNumber);
        Console.WriteLine("longNumber = {0}", longNumber);
        Console.WriteLine("shortByte = {0}", shortByte);
    }
}
