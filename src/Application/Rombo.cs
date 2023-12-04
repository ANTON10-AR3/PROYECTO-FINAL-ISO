namespace Application;

public static class Rombo
{
    public static double CalcularPerimetro(double lado)
    {
        return lado * 4;
    }
    public static double CalcularArea(Double diagonal_m, double diagonal_M)
    {
        double area = diagonal_M * diagonal_m / 2.0;
        return area;
    }
}