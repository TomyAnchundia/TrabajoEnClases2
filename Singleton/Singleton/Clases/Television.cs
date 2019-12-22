using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Clases
{
    public class Television
    {
        public Television(string Marca, double Precio, string Modelo, double VTotal)
        {
            this.Marca = Marca;
            this.Precio = Precio;
            this.Modelo = Modelo;
            this.VTotal = VTotal;


        }

        public string Marca { get; set; }
        private double precio;

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public string Modelo { get; set; }
        private double vtotal;

        public double VTotal
        {
            get { return (Precio * Singleton.Instancia.Iva.Valor) + Precio; }
            set { vtotal = value; }
        }
    }
}

