namespace FundamentosPOO.Abstraccion
{
    public class Cuadrado : FiguraGeometrica
    {
        private double lado;

        public Cuadrado(double lado)
        {
            this.lado = lado;
        }

        public override double ObtenerArea()
        {
            return lado * lado;
        }
    }
}
