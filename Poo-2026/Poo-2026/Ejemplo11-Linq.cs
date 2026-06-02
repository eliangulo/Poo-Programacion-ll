using System;
using System.Collections.Generic;
using System.Text;
using static Poo_2026.Ejemplo10Dictionary;

namespace Poo_2026
{
    public class Ejemplo11_Linq
    {
        //int[] numeros = { 1, 2, 3, 4 };//array de enteros
        int[] numeros = Enumerable.Range(1, 4).ToArray(); //otra forma de crear un array de enteros del 1 al 4
        Provincia[] provincias = new Provincia[]
        {
            new Provincia() { Cod = "01", NombreProv = "Buenos Aires", CantidadHabitantes = 15600000, claveTel = "011" },
            new Provincia() { Cod = "02", NombreProv = "Cordoba", CantidadHabitantes = 3560000, claveTel = "011" },
            new Provincia() { Cod = "03", NombreProv = "Santa Fe", CantidadHabitantes = 3500000, claveTel = "011" },
            new Provincia() { Cod = "04", NombreProv = "Mendoza", CantidadHabitantes = 2000000, claveTel = "011" }
        };

        public Ejemplo11_Linq()
        {
            //if (numeros.Length > 0) Console.WriteLine($"Par");

            //{
            //    Console.WriteLine($"El primer numero es {numeros[0]}");
            //}
            // //sintaxis de metodos
            //var numeroMayorA_3 = numeros.Where(x => x > 3).ToArray();
            // //sintaxis de queries
            // var numerosPares = (from n in numeros
            //                    where n % 2 == 0
            //                    select n).ToList();
            //var provinciaMenosDe_10000 =
            //    provincias.Where(p => p.CantidadHabitantes < 10000).ToList();
            //    
            //EJECUCION DIFERIDA
            var numPares = numeros.Where(n =>
            {
                Console.WriteLine($"Evaluando el numero {n}");
                return n % 2 == 0;
            });
            
           
        }
    }
}
