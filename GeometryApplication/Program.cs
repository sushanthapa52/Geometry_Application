using GeometryClassLib;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FeatureManagement;


var featureManagement = new Dictionary<string, string>
{
    { "FeatureManagement:Square", "true"},
    { "FeatureManagement:Rectangle", "true"},
    { "FeatureManagement:Triangle", "true"}
};  

IConfigurationRoot configuration = new ConfigurationBuilder().AddInMemoryCollection(featureManagement).Build();

var services = new ServiceCollection();
services.AddFeatureManagement(configuration);
var serviceProvider = services.BuildServiceProvider();

var featureManager = serviceProvider.GetRequiredService<IFeatureManagerSnapshot>();

if (await featureManager.IsEnabledAsync("Square"))
{
    // Provide access to Square
    Console.WriteLine("Enter the side length of the square:");
    double sideLength = double.Parse(Console.ReadLine());

    var square = new Square(sideLength);
    Console.WriteLine($"Area of the square: {square.CalculateArea()}");
    Console.WriteLine($"Perimeter of the square: {square.CalculatePerimeter()}");
}

if (await featureManager.IsEnabledAsync("Triangle"))
{
    // Provide access to Triangle
    Console.WriteLine("Enter the lengths of the three sides of the triangle:");
    double side1, side2, side3;

    // Get input for side1
    Console.Write("Side 1: ");
    double.TryParse(Console.ReadLine(), out side1);

    // Get input for side2
    Console.Write("Side 2: ");
    double.TryParse(Console.ReadLine(), out side2);

    // Get input for side3
    Console.Write("Side 3: ");
    double.TryParse(Console.ReadLine(), out side3);

    var triangle = new Triangle(side1, side2, side3);
    Console.WriteLine($"Area of the triangle: {triangle.CalculateArea()}");
    Console.WriteLine($"Perimeter of the triangle: {triangle.CalculatePerimeter()}");
}


if (await featureManager.IsEnabledAsync("Rectangle"))
{ // Provide access to Rectangle
    Console.WriteLine("Enter the length and width of the rectangle (separated by a space):");

    // Get input for length and width
    Console.Write("Length: ");
    double.TryParse(Console.ReadLine(), out double length);

    Console.Write("Width: ");
    double.TryParse(Console.ReadLine(), out double width);

    // Check if both length and width are valid
    if (length > 0 && width > 0)
    {
        var rectangle = new Rectangle(length, width);
        Console.WriteLine($"Area of the rectangle: {rectangle.CalculateArea()}");
        Console.WriteLine($"Perimeter of the rectangle: {rectangle.CalculatePerimeter()}");
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter valid positive numerical values for length and width.");
    }
}