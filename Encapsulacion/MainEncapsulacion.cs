namespace FundamentosPOO.Encapsulacion
{
    public class MainEncapsulacion
    {
        public static void Main(string[] args)
        {
            var rectangulo = new Rectangulo();
            rectangulo.RecibirValores();
            rectangulo.MostrarDetalles();
            Console.ReadLine();
        }
    }
}
