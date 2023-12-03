namespace Application.IntegrationTest;

public class IntegrationTestApplication
{
    [Theory]
    [InlineData(4, 5, 5, 50)]
    [InlineData(5, 6, 2, 30)]
    [InlineData(7, 10, 7, 245)]
    [InlineData(10, 9, 8, 360)]
    [InlineData(25, 4, 7, 350)]
    public void TestVolumen(double diagonal_m, double diagonal_M, double altura, double volumen)
    {
        // Arrange – Set up
        double area = Rombo.CalcularArea(diagonal_m, diagonal_M);

        // Act – Perform
        double resultado = PrismaR.CalcularVolumen(area, altura);

        // Assert – Verify
        Assert.Equal(resultado, volumen);
    }
}
