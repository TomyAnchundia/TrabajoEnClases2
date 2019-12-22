using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Singletone_Decorator.Interfaces;

namespace Singletone_Decorator.Clases
{
    public abstract class DecoradorCavalier : ICavalier
    {
        protected ICavalier cavalier;

        public DecoradorCavalier(ICavalier cavalier)
        {
            this.cavalier = cavalier;
        }

        public abstract string getDescripcion();
    }
}
