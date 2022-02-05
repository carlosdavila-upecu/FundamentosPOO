using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosPOO
{
    
    public class Pruebas
    {
        public Factura g;
        public static string nombreCliente = "raquel";

        public void Ejecutar(string cliente)
        {
            g = new Factura();
            g.ObtenerCliente();
            Math.Round(5.5, 2);

            var t = new Factura();

            var nc = new NOtaCredito();
            nc.ObtenerCliente();

            ImprimirCliente(t);
            ImprimirCliente(g);
            ImprimirCliente(nc);
        }

        private void ImprimirCliente(DocumentoCOntable doc)
        {
            Console.WriteLine(doc.ObtenerCliente());
        }
    }

    public class Factura : DocumentoCOntable
    {
        private string NumeroFactura;
        private int precioTotal;
        private int cantidadItems;
        public string CLiente { get; private set; }

        public void AgregarItem(int cantidadDeItems)
        {
            cantidadItems = cantidadItems + cantidadDeItems;
        }

        public override string ObtenerCliente()
        {
            return CLiente;
        }

        public void SetNumeroFactura(string numerofactura)
        {
            NumeroFactura = "001-" + numerofactura;
        }
    }

    public class NOtaCredito : DocumentoCOntable
    {
        public string valor;
        public override string ObtenerCliente()
        {
            return "Jaime";
        }
    }
    public class NotitaCredito : NOtaCredito
    {

    }

    public abstract class DocumentoCOntable
    {
        public abstract string ObtenerCliente();
    }


}
