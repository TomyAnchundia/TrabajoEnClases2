using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone_Decorator.Clases
{
    public sealed class Singletone
    {
        private static Singletone instancia = null;

        protected Singletone()
        {
        }

        private Auto producto;
        public Auto Producto
        {
            get { return producto; }
            set { producto = value; }
        }

        public static Singletone Instancia
        {
            get
            {
                if (instancia == null)
                {
                    Console.WriteLine("Se agrego");
                    instancia = new Singletone();
                }
                return instancia;
            }
        }

    }
}
