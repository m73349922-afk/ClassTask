namespace Domain.Task2;

public class Car : IMoveLeft
{
    private string color = "";
    private double speed;
    private string model = "";
    public Car(string Color, double Speed, string Model)
    {
        color = Color;
        speed = Speed;
        model = Model;
    }
    public string MoveLeft()
    {
        return "Car move to left";
    }

    public string MoveRight()
    {
        return "Car move to right";
    }

}
