namespace FundamentosPOO.Encapsulacion
{
    public class Rectangulo
    {
        public double alto { get; set; }
        private double ancho;

        public void RecibirValores()
        {
            Console.WriteLine("Ingresar alto: ");
            alto = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresar ancho: ");
            ancho = Convert.ToDouble(Console.ReadLine());
        }

        private double ObtenerArea() => alto * ancho;

        public void MostrarDetalles()
        {
            Console.WriteLine($"Alto: {alto}");
            Console.WriteLine($"Ancho: {alto}");
            Console.WriteLine($"Area: {ObtenerArea}");
        }
    }
}
