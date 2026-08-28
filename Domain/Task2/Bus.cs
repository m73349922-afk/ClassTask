namespace Domain.Task2;

public class Bus : IMoveLeft
{
    private string color = "";
    private double speed;
    private string model = "";
    public Bus(string Color, double Speed, string Model)
    {
        color = Color;
        speed = Speed;
        model = Model;
    }
    public string MoveLeft()
    {
        return "Bus move to left";
    }

    public string MoveRight()
    {
        return "Bus move to right";
    }

}
