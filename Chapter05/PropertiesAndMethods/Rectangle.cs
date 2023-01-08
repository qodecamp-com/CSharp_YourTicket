namespace PropertiesAndMethods;

/// <summary>
/// Create a Rectangle class with properties for Length and Width. 
/// Add a method called GetArea() that calculates and returns the area of the rectangle. 
/// Create an object of the Rectangle class and call the GetArea() method to see if it works correctly.
/// </summary>
class Rectangle
{
    int _length;
    int _width;

    //define the properties
    public int Length
    {
        get
        {
            return _length;
        }

        set
        {
            _length = value;
        }
    }

    public int Width { get => _width; set => _width = value; }

    public Rectangle(int length, int width)
    {
        this.Length = length;
        this.Width = width;
    }

    public int GetArea()
    {
        return this.Length * this.Width;
    }
}