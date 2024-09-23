using FactoryPattern.Interfaces;

public class Circle : IShape
{
    public void Display()
    {
        Console.WriteLine("I'm circle");
    }
}