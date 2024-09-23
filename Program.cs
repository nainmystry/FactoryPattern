// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

ShapeFactory shapeFactory = new ShapeFactory();
var cd = shapeFactory.GetShape("CIRCLE");
cd.Display();