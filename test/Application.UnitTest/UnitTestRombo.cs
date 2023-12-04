namespace Application.UnitTest;

public class UnitTestRombo
{
    [Theory]
    [InlineData(1,4)]
    [InlineData(2,8)]
    [InlineData(3,12)]
    [InlineData(4,16)]
    [InlineData(5,20)]
    public void TestPerimetro(double lado, double perimetro)
    {
        // Arrange – Set up

        // Act – Perform
        double resultado = Rombo.CalcularPerimetro(lado);

        // Assert – Verify
        Assert.Equal(perimetro, resultado);
    }

    [Theory]
    [InlineData(2,2,2)]
    [InlineData(2,4,4)]
    [InlineData(6,10,30)]
    [InlineData(4,16,32)]
    [InlineData(4,25,50)]
    public void TestArea(double diagonal_M, double diagonal_m, double area)
    {
        // Arrange – Set up

        // Act – Perform
        double resultado = Rombo.CalcularArea(diagonal_M, diagonal_m);

        // Assert – Verify
        Assert.Equal(area, resultado);
    }
}