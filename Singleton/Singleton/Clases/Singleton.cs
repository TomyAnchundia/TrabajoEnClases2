using Singleton.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Singleton
    {
        private static Singleton instancia = null;
        protected Singleton()
        {
        }

        private Iva iva;
        public Iva Iva
        {
            get { return iva; }
            set { iva = value; }


        }
        public static Singleton Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Singleton();

                }
                return instancia;
            }
        }

    }
}
