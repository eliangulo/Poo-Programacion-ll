using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Poo_2026;

//constructores vd2 
public class Ejemplo3
{
    PracticaConstructores pc = new PracticaConstructores("nuevo nomb");
    PracticaConstructores pcSin = new PracticaConstructores(); 
    PracticaConstructores pcF = new PracticaConstructores("Nuevo", 12);
    PracticaConstructores pcA = new PracticaConstructores( 5,"antiguedad");

    public Ejemplo3()
    {
        Console.WriteLine("constructor con firma string");
        Console.WriteLine(pc.Nombre);
        Console.WriteLine(pc.Edad);
        
        Console.WriteLine("constructor sin firma");
        Console.WriteLine(pcSin.Nombre);
        Console.WriteLine(pcSin.Edad);

        Console.WriteLine("constructor con firma stringe int");
        Console.WriteLine(pcF.Nombre);
        Console.WriteLine(pcF.Edad);

        Console.WriteLine("constructor con firma stringe int");
        Console.WriteLine(pcA.Nombre);
        Console.WriteLine(pcA.Antiguedad);
    }
    public class PracticaConstructores 
    {
        public string Nombre { get; set; } = "nombre por defecto";
        public int Edad { get; set; }
        public int Antiguedad { get; set; }

        //constructor por defecto, se ejecuta al momento de crear un objeto de la clase practica constructores
        //ademas no recibe ningun argumento
        public PracticaConstructores()
        {
            Edad = 20;
            //Nombre = "Duque";
        }
        public PracticaConstructores( string nombre) : this()
        {
            Nombre = nombre;
        }
        public PracticaConstructores(string nombre, int edad) : this()
        {
            Nombre = nombre;
            Edad = edad;
        }
        public PracticaConstructores(int antiguedad, string nombre) : this()
        {
            Nombre = nombre;
            Antiguedad = antiguedad;
        }
    }
}
