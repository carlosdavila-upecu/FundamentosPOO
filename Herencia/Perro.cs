namespace FundamentosPOO.Herencia
{
    public class Perro : Animal
    {
        public Perro(string nombre)
        {
            this.nombre = nombre;
        }

        public void MostrarNombre()
        {
            Console.WriteLine($"Mi nombre es: {nombre}");
        }
    }
}
