


public class Rectangle : Shape
{
    private double _width;
    private double _heigh;

    public Rectangle(string color, double width, double heigh) : base(color)
    {
        _width = width;
        _heigh = heigh;
    }

    public override double GetArea()
    {
        return _width * _heigh;
    }
}