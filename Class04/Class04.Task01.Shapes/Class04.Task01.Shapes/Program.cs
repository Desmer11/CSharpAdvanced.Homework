using Class04.Task01.Shapes;



Rectangle rectangle = new Rectangle()
{
    id = "Rectangle",
    SideA = 5,
    SideB = 20

};
Console.WriteLine("\nRectangle: ");
rectangle.PrintInfo();
rectangle.GetPerimeter();
rectangle.GetArea();

Circle circle = new Circle()
{
    id = "Circle",
    Radius = 25
};
Console.WriteLine("\nCircle: ");
circle.PrintInfo();
circle.GetPerimeter();
circle.GetArea();