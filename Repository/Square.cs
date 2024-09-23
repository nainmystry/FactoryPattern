using FactoryPattern.Interfaces;

public class Square : IShape
{
    public void Display()
    {
        Console.WriteLine("I'm square");
    }
}