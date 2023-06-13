using GeometryLibrary;

namespace TestApp;

internal class Program
{
    private static void Main()
    {
        var circleRadius = 5.0;
        var circleArea = ShapeCalculator.CalculateCircleArea(circleRadius);

        Console.WriteLine($"Площадь круга с радиусом {circleRadius} равна: {circleArea}");

        var sideA = 3.0;
        var sideB = 4.0;
        var sideC = 5.0;
        var triangleArea = ShapeCalculator.CalculateTriangleArea(sideA, sideB, sideC);

        Console.WriteLine($"Площадь треугольника со сторонами {sideA}, {sideB}, {sideC} равна: {triangleArea}");

        Console.ReadLine();
    }
}