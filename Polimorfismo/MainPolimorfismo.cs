namespace FundamentosPOO.Polimorfismo
{
    public class MainPolimorfismo
    {
        public static void Main(string[] args)
        {
            var rectangulo = new Rectangulo(1.5, 5);
            var triangulo = new Triangulo(2.5, 8);

            MostrarArea(rectangulo);
            MostrarArea(triangulo);

            Console.ReadLine();
        }

        private static void MostrarArea(IFiguraGeometrica figuraGeometrica) => 
            Console.WriteLine($"Area de la figura: {figuraGeometrica.CalcularArea}");
    }
}
