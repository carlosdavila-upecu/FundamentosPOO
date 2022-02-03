namespace FundamentosPOO.Abstraccion
{
    public class Circulo : FiguraGeometrica
    {
        private double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public override double ObtenerArea()
        {
            return 3.14 * radio * radio;
        }
    }
}
