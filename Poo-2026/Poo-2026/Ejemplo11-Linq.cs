using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using static Poo_2026.Ejemplo10Dictionary;

namespace Poo_2026
{
    public class Ejemplo11_Linq
    {
        //int[] numeros = { 1, 2, 3, 4 };//array de enteros
        int[] numeros = Enumerable.Range(1, 5).ToArray(); //otra forma de crear un array de enteros del 1 al 4

       Provincias[] provincias = new Provincias[]
        {
            new Provincias(){ Cod = "01", NombreProv = "Buenos Aires", CantidadHabitantes = 156000 },
            new Provincias(){ Cod = "02", NombreProv = "Cordoba", CantidadHabitantes = 10000 },
            new Provincias(){ Cod = "03", NombreProv = "Corrientes", CantidadHabitantes = 1560 },
            new Provincias(){ Cod = "04", NombreProv = "Entre Ríos", CantidadHabitantes = 9000 }
        };

        public Ejemplo11_Linq()
        {
            //sintaxis de mtd
            var numMayorA_3 = numeros.Where(r => r > 3);

            //sintaxisDeQuery
            //var numPares = (from n in numeros
            // where n % 2 == 0
            //select n).ToList();

            /* var provMenosHab_10000 = provincias.Where
                 (p => p.CantidadHabitantes < 10000).ToList();*/

            //ejecucionDiferida
            /*var numerosPares = numeros.Where(n =>
            {
                Console.WriteLine($"Evaluando si el numero es par: {n}");
                return n % 2 == 0;
            });//.ToList();
            Console.WriteLine();
            foreach (var item in numerosPares)
            {
                Console.WriteLine($"Numero par: {item}");
            }
            Console.WriteLine();*/

            //consulta compleja
            /*var provConsulta = provincias.Where
                 (p => p.CantidadHabitantes < 14500
                 && p.NombreProv.Substring(0,1)== "C").ToList();*/
            var provPrimera = provincias.First();
            var provPrimeras = provincias.FirstOrDefault();

            /*var provConsulta = provincias.Where
                 (p => p.CantidadHabitantes < 14500
                 && p.NombreProv.Substring(0, 1) == "C").FirstOrDefault();*/
            var provConsultar = provincias.Where
                 (p => p.CantidadHabitantes < 14500
                 && p.NombreProv.Substring(0, 1) == "C")
                 .OrderBy(p => p.NombreProv)
                 .ToList()
                 .FirstOrDefault();



        }
    }
}
