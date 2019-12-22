using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutosG.Clase;
using AutosG.Interfaz;

namespace AutosG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FUNCIONALIDADES Y ACCESORIOS DE UN AUTO");
            Auto basico = new Auto();
            Radio autoConRadio = new Radio(basico);
            SensorDeRetro autoConSensorDeRetro = new SensorDeRetro(autoConRadio);
            Airbag autoConAirbag = new Airbag(autoConSensorDeRetro);
            Faldon autoConFaldon = new Faldon(autoConAirbag);



            Console.WriteLine(autoConFaldon.getDescripcion());
            Console.ReadKey();

        }
    }
}
