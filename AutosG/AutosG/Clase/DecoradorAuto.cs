using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutosG.Interfaz;


namespace AutosG.Clase
{
    public abstract class DecoradorAuto :IAuto
    {
        protected IAuto auto;
        public DecoradorAuto (IAuto auto) { this.auto = auto; }

        public abstract string getDescripcion();
    }
}
