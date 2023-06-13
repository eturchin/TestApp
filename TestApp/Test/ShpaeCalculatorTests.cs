using GeometryLibrary;

namespace Test;

public class ShapeCalculatorTests
{
    [Fact]
    public void CalculateCircleArea_ValidRadius_ReturnsCorrectArea()
    {
        // Arrange
        var radius = 5.0;
        var expectedArea = Math.PI * Math.Pow(radius, 2);

        // Act
        var actualArea = ShapeCalculator.CalculateCircleArea(radius);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void CalculateCircleArea_ZeroRadius_ThrowsArgumentException()
    {
        // Arrange
        var radius = 0.0;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => ShapeCalculator.CalculateCircleArea(radius));
    }

    [Fact]
    public void CalculateCircleArea_NegativeRadius_ThrowsArgumentException()
    {
        // Arrange
        var radius = -5.0;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => ShapeCalculator.CalculateCircleArea(radius));
    }

    [Fact]
    public void CalculateTriangleArea_ValidSides_ReturnsCorrectArea()
    {
        // Arrange
        var sideA = 3.0;
        var sideB = 4.0;
        var sideC = 5.0;
        var expectedArea = 6.0;

        // Act
        var actualArea = ShapeCalculator.CalculateTriangleArea(sideA, sideB, sideC);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Theory]
    [InlineData(0, 4, 5)]
    [InlineData(3, -2, 5)]
    [InlineData(3, 4, 0)]
    public void CalculateTriangleArea_InvalidSides_ThrowsArgumentException(double sideA, double sideB, double sideC)
    {
        // Arrange, Act & Assert
        Assert.Throws<ArgumentException>(() => ShapeCalculator.CalculateTriangleArea(sideA, sideB, sideC));
    }

    [Fact]
    public void IsRightTriangle_ValidInput_ReturnsTrue()
    {
        // Arrange
        var sideA = 3.0;
        var sideB = 4.0;
        var sideC = 5.0;

        // Act
        var result = ShapeCalculator.IsRightTriangle(sideA, sideB, sideC);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsRightTriangle_NotRightTriangle_ReturnsFalse()
    {
        // Arrange
        var sideA = 5.0;
        var sideB = 6.0;
        var sideC = 10.0;

        // Act
        var result = ShapeCalculator.IsRightTriangle(sideA, sideB, sideC);

        // Assert
        Assert.False(result);
    }

    [Theory]
    [InlineData(5.0, 12.0, 13.0)]
    [InlineData(8.0, 15.0, 17.0)]
    [InlineData(9.0, 40.0, 41.0)]
    public void IsRightTriangle_ValidRightTriangles_ReturnsTrue(double sideA, double sideB, double sideC)
    {
        // Act
        var result = ShapeCalculator.IsRightTriangle(sideA, sideB, sideC);

        // Assert
        Assert.True(result);
    }
}