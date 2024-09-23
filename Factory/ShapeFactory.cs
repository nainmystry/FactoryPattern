using FactoryPattern.Interfaces;

public class ShapeFactory
{
    public IShape GetShape(string input)
    {
        switch (input)
        {
            case"CIRCLE":
                return new Circle();
            case"SQUARE":
                return new Square();
            default:
                return null;
        }
    }
}