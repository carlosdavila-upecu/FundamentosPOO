namespace FundamentosPOO.Herencia
{
    public class MainHerencia
    {
        public static void Main(string[] args)
        {
            var perro = new Perro("Firulais");
            perro.MostrarNombre();

            perro.nombre = "Max";
            perro.MostrarNombre();

            perro.SoyUnAnimal();
            Console.ReadLine();
        }
    }
}
