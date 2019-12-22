///using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutosG.Interfaz;


namespace AutosG.Clase
{
    public  class Auto : IAuto
    {
        public string getDescripcion()
        {
            return " Llantas \n Volante \n Puertas \n Ventanas \n Capó \n Frenos \n Aire Condicionado \n Retrovisor \n Asientos \n Herramientas \n Extintor \n ";
        }
    }
}
