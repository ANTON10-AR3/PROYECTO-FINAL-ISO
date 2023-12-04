double perimetro;
double area;
double volumen;

Console.WriteLine("Calculadora de Perímetro y Area del Cuadrado; y Volumen de Prisma de un Rombo");

Console.Write("Dame el lado: ");
double lado = Convert.ToDouble(Console.ReadLine());

Console.Write("Dame la altura: ");
double altura = Convert.ToDouble(Console.ReadLine());

Console.Write("Dame la Diagonal mayor: ");
double diagonal_M = Convert.ToDouble(Console.ReadLine());

Console.Write("Dame la Diagonal menor: ");
double diagonal_m = Convert.ToDouble(Console.ReadLine());

perimetro = Application.Rombo.CalcularPerimetro(lado);
area = Application.Rombo.CalcularArea(diagonal_M, diagonal_m);

volumen = Application.PrismaR.CalcularVolumen(area, altura);

Console.WriteLine();
Console.WriteLine($"Perímetro: {perimetro}cm\nÁrea: {area}cm2\nVolumen {volumen}cm3");