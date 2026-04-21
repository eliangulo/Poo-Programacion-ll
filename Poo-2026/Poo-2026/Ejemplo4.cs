using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Poo_2026
{
    //constructores vd2 primer parte
    public class Ejemplo4
    {
        PracticaMetodo pm = new PracticaMetodo(" Es mayor o menor de edad");
        PracticaMetodo pmConEdad = new PracticaMetodo("Damaris",16);



        public Ejemplo4()
        {
            Console.WriteLine("Entro al construtor"); 
            Console.WriteLine("Es mayor de edad? ");
            Console.WriteLine(pmConEdad.Nombre);
            Console.WriteLine(pmConEdad.Edad);
            Console.WriteLine(pmConEdad.EsMayorEdad());
            Console.WriteLine("----------------");
            Console.WriteLine(pmConEdad.EsMayorEdad(18));
        }
        public class PracticaMetodo
        {
            #region Propiedades 
            public string Nombre { get; set; } = "nombre por defecto";
            public int Edad { get; set; }
            public int Antiguedad { get; set; }
            #endregion

            #region Constructores
            public PracticaMetodo()
            {
                Edad = 18;
                //Nombre = "Duque";
            }
            public PracticaMetodo(string nombre) : this()
            {
                Nombre = nombre;
            }
            public PracticaMetodo(string nombre, int edad) : this()
            {
                Nombre = nombre;
                Edad = edad;
            }
            public PracticaMetodo(int antiguedad, string nombre) : this()
            {
                Nombre = nombre;
                Antiguedad = antiguedad;
            }
            #endregion

            #region Metodos
            public void RestarAntiguedadad()
            {
                Antiguedad --;
            }
            public bool EsMayorEdad()
            {
                return Edad >= 18;
            }
            public string EsMayorEdad(int edadComparar)
            {
                if (Edad >= edadComparar)
                {
                    return($"Es mayor o igual de edad a {edadComparar}");
                }
                else
                {
                    return($"Es menor de edad a {edadComparar}");
                }
            }
            #endregion
        }
    }
}