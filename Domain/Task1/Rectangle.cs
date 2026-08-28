namespace Domain;

public class Rectangle : Shape
{
    private double length;
    private double width;
    public Rectangle(double Length, double Width)
    {
        length = Length;
        width = Width;
    }
    public override double CalculatorArea()
    {
        return length * width;
    }
    public override string PrintDescription()
    {
        return $"Length * Width = {CalculatorArea()}";
    }

}
