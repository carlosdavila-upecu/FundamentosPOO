namespace FundamentosPOO.Polimorfismo
{
    public class Triangulo : IFiguraGeometrica
    {
        private double ancho;
        private double alto;

        public Triangulo(double ancho, double alto)
        {
            this.ancho = ancho;
            this.alto = alto;
        }

        public double CalcularArea()
        {
            return ancho * alto * 0.5;
        }
    }
}
