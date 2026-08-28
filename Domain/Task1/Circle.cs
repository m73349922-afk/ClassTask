namespace Domain;

public class Circle : Shape
{
    private double radius;
    public Circle(double Radius)
    {
        radius = Radius;
    }
    public override double CalculatorArea()
    {
        return 3.14 * radius * radius;
    }
    public override string PrintDescription()
    {
        return $"Radius: {CalculatorArea()}";
    }

}
