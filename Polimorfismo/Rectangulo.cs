namespace FundamentosPOO.Polimorfismo
{
    public class Rectangulo : IFiguraGeometrica
    {
        private double ancho;
        private double alto;

        public Rectangulo(double ancho, double alto)
        {
            this.ancho = ancho;
            this.alto = alto;
        }

        public double CalcularArea()
        {
            return ancho * alto;
        }
    }
}
