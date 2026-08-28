namespace Domain;

public abstract class Shape
{
    private string description = "";
    public abstract double CalculatorArea();
    public virtual string PrintDescription()
    {
        return description;
    }
}
