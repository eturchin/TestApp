namespace GeometryLibrary;

public static class ShapeCalculator
{
    public static double CalculateCircleArea(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Радиус должен быть положительным числом.");
        }

        var result = Math.PI * Math.Pow(radius, 2);

        return result;
    }

    public static double CalculateTriangleArea(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
        {
            throw new ArgumentException("Длины сторон должны быть положительными числами.");
        }

        Console.WriteLine(IsRightTriangle(sideA, sideB, sideC)
            ? "Треугольник является прямоугольным."
            : "Треугольник не является прямоугольным.");

        var s = (sideA + sideB + sideC) / 2;
        var result = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));

        return result;
    }

    public static bool IsRightTriangle(double sideA, double sideB, double sideC)
    {
        var sides = new[] { sideA, sideB, sideC };
        Array.Sort(sides);

        var a = sides[0];
        var b = sides[1];
        var c = sides[2];
        var result = Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2);

        return result;
    }
}