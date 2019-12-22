using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone_Decorator.Clases
{
    public class Auto
    {
        public Auto(string Detalle)
        {
            this.Detalle = Detalle;
        }
        public string Detalle { get; set; }

    }
}
