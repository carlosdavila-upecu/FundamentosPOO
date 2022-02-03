namespace FundamentosPOO.Abstraccion
{
    public class MainAbstracion
    {
        public static void Main(string[] args)
        {
            var circulo = new Circulo(5);
            Console.WriteLine($"Area del circulo: {circulo.ObtenerArea}");
            var cuadrado = new Cuadrado(2.5);
            Console.WriteLine($"Area del cuadrado: {cuadrado.ObtenerArea}");
        }
    }
}
