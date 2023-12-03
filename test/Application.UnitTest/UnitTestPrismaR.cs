namespace Application.UnitTest;

public class UnitTestPrismaR
{
    [Theory]
    [InlineData(16, 4, 64)]
    [InlineData(25, 6, 150)]
    [InlineData(50, 8, 400)]
    [InlineData(70, 12, 840)]
    [InlineData(100, 15, 1500)]
    public void TestVolumen(double area, double altura, double volumen)
    {
        // Arrange – Set up


        // Act – Perform
        double resultado = PrismaR.CalcularVolumen(area, altura);
        
        // Assert – Verify
        Assert.Equal(resultado, volumen);
    }
}