using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Singletone_Decorator.Interfaces;

namespace Singletone_Decorator.Clases
{
    public class Cavalier : ICavalier
    {
        public string getDescripcion()
        {
            return "4 llantas \n2 luces amarillas\n";
        }
    }
}
