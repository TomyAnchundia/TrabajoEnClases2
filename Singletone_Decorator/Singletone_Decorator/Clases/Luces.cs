using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Singletone_Decorator.Interfaces;

namespace Singletone_Decorator.Clases
{
    public class Luces : DecoradorCavalier
    {
        public Luces(ICavalier cavalier) : base(cavalier)
        {
        }

        public override string getDescripcion()
        {
            return this.cavalier.getDescripcion() + "Luces blancas\n";
        }
    }
}
