using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutosG.Interfaz;

namespace AutosG.Clase
{
    public  class Airbag: DecoradorAuto
    {
       
            public Airbag(IAuto auto) : base(auto)
            {

            }
            public override string getDescripcion()
            {
                return this.auto.getDescripcion() + " Airbag\n";

            }

        }
    }
