namespace TypeConversion;
class Program
{
    static void Main(string[] args)
    {
        int x = 10;
        long y = x;

        Console.WriteLine("Implicit Type Conversion in action...");
        Console.WriteLine("x = {0}, and y={1}", x, y);

        long a = 10;
        //cannot use implicit conversion to cast a long to an int - this is not allowed
        //int b = a;

        //we have to use explicit casting/type conversion
        int b = (int)a;  // this works
        Console.WriteLine("Explicit Type Conversion in action...");
        Console.WriteLine("a = {0}, and b={1}", a, b);

        //finally here's an example that produces an unexpected result
        long c = 20000000000;
        float d = c;
        Console.WriteLine(d); //d and e will have different values due to data loss
        int e = (int)d;
        Console.WriteLine(e);
    }
}
