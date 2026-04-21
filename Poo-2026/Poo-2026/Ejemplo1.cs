using System;
using System.Collections.Generic;
using System.Text;

namespace Poo_2026
{
    public class Ejemplo1
    {
        //instanciar la clase CamposYPropiedades
        CamposYPropiedades ej = new CamposYPropiedades();
        public Ejemplo1() //constructor
        {
            ej.Nombre = "Graciela"; //DA VALOR
            Console.WriteLine(ej.Nombre); //CONSOLA
        }
    }
    public class CamposYPropiedades //la propied piodria ser publica pero ya no seria encapsulamiento
    {
        //private string ?nombre;
        public string Nombre { get; set; } = "";
    }
}