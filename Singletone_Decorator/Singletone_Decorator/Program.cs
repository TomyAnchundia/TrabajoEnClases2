using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Singletone_Decorator.Clases;
using Singletone_Decorator.Interfaces;

namespace Singletone_Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            // Se tiene un local que vende autos, y con el tiempo va agregando nuevos modelos,
            // y a la vez se agrega nuevas caracteristicas a los autos
            #endregion

            Singletone.Instancia.Producto = new Auto("Chevrolet Cavalier");
            Console.WriteLine(Singletone.Instancia.Producto.Detalle);

            Cavalier simple = new Cavalier();
            Llanta cavalierMasUnaLlanta = new Llanta(simple);
            Luces cavalierMasLuz = new Luces(cavalierMasUnaLlanta);

            Console.WriteLine(cavalierMasLuz.getDescripcion());
            Console.ReadKey();


        }
    }
}
