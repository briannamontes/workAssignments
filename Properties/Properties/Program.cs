public class Rectangle
{
    public int Width { get; set;  }
    public int Height { get; set; }

    public int Area
    {
        get
        {
            return Width * Height;

        }
    }
}

class program
{
    static void Main(string[] args)
    {
        Rectangle aRectangleObject = new Rectangle();

        // set properties
        aRectangleObject.Height = 10;
        aRectangleObject.Width = 5;

        //Calls the get accessor, returns 50
        Console.WriteLine("Area = {0}", aRectangleObject.Area);

        //error, no set accessor found, we cant assign area
       // aRectangleObject.Area = 20;
    }
}