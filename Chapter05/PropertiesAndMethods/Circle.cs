namespace PropertiesAndMethods;

/// <summary>
/// Create a Circle class with a property for Radius. 
/// Add a method called GetCircumference() that calculates and returns 
/// the circumference of the circle. Add a method called GetArea() 
/// that calculates and returns the area of the circle. 
/// Create an object of the Circle class and call the GetCircumference() and 
/// GetArea() methods to see if they work correctly.
/// </summary>
class Circle
{
    //declare the private fields
    private float _radius;
    private const float _PI = 3.14f;

    //define the properties
    public float Radius
    {
        get
        {
            return _radius;
        }

        set
        {
            _radius = value;
        }
    }

    public static float PI => _PI;

    public Circle(float radius)
    {
        this.Radius = radius;
    }

    public float GetCircumference()
    {
        return 2 * PI * this.Radius;
    }

    public float GetArea()
    {
        return PI * this.Radius * this.Radius;
    }
}