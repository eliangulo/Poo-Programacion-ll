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
        ProvinciaCiudad[] provCiudad = new ProvinciaCiudad[]
        {
            new ProvinciaCiudad(){ Cod = "01", NombreProv = "Buenos Aires", CantidadHabitantes = 156000,
                                   ciudades = ["Capital Federal", "La Plata"]
            },
            new ProvinciaCiudad(){ Cod = "02", NombreProv = "Cordoba", CantidadHabitantes = 10000,
                                   ciudades = ["Cordoba Capital", "Villa Carlos Paz"]
            },
            new ProvinciaCiudad(){ Cod = "03", NombreProv = "Corrientes", CantidadHabitantes = 1560,
                                   ciudades = ["Corrientes Capital", "Goya"]
            },
            new ProvinciaCiudad(){ Cod = "04", NombreProv = "Entre Ríos", CantidadHabitantes = 9000,
                                   ciudades = ["Parana", "Gualeguaychú"]
            }
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

            //continuacion vdo

            var numerosOrdenados = numeros.OrderByDescending(n => n).ToList();

            //select
            var nombreProv = provincias.Select(p => p.NombreProv).ToList();
            //de prov traigo un nuevo objeto que va a tener 2 propiedades 
            var nombreCodProv = provincias.Select
            (p => new
            {
                codigo = p.Cod,
                nombre = p.NombreProv
            }).ToList();
            //select con calculos
            var numerosAlCuadrado = numeros.Select(n => n * n).ToList();
            //select con indice y ordenamiento 
            var provIndice = provincias
                .Select((provincias, indice) => new
                {
                    Indice = indice,
                    Nombre = provincias.NombreProv
                    //prov = provincias - me trae el objeto completo
                });

            var provOrden =
                (provincias
                .Select((provincias, inidce) => new
                {
                    Orden = inidce + 1,
                    Nombre = provincias.NombreProv
                })
                ).OrderByDescending(o => o.Orden).ToList();

            var ciudades = provCiudad
                .Select(p => p.ciudades).ToList();
            //solo las q tienen arreglos
            var ciudadesMany = provCiudad
                .SelectMany(p => p.ciudades).ToList();

            //prod cartesiano ej= es la union de 2 coleciones provincia y ciudad

            int[] arreglo = { 1, 2, 3, 4 };

            var productoCarteciano = provincias
                .SelectMany(p => arreglo, (provincia, numero) => new
                {
                    Provincia = provincia,
                    Numero = numero
                });
            foreach (var item in productoCarteciano)
            {
                Console.WriteLine
                    (
                    $"Provincia: {item.Provincia.NombreProv} - Numero: {item.Numero}"
                    );
            }
            //Devolviendo Escalar
            Console.WriteLine("---------");
            Console.WriteLine($"cantidad de elementos q tiene numero {numeros.Count()}");
            Console.WriteLine($"cantidad de prov {provincias.Count()}");
            Console.WriteLine($"cantidad de prov {provincias.Count(p => p.NombreProv.Substring(0,1) == "C")}");

            //NUMEROS GRANDES LONG  {numeros.LongCount()}
            //sum {numeros.Sum()}
            Console.WriteLine($"suma de numeros {numeros.Sum()}");
            Console.WriteLine($"minimo de num {numeros.Min()}");
            Console.WriteLine($"maximo de num {numeros.Max()}");
            Console.WriteLine($"promedio de los num {numeros.Average()}");
            Console.WriteLine($"cantidad de hab {provincias.Sum(p => p.CantidadHabitantes)}");
            Console.WriteLine($"cantidad de hab maxima {provincias.Max(p => p.CantidadHabitantes)}");
            Console.WriteLine($"cantidad de hab minima {provincias.Min(p => p.CantidadHabitantes)}");
            Console.WriteLine($"cantidad de hab minima {provincias.MinBy(p => p.CantidadHabitantes)!.NombreProv}");
            Console.WriteLine($"el porcentaje de habitantes es {provincias.Average(p => p.CantidadHabitantes)}");

        }
    }
    public class ProvinciaCiudad : Provincias
    {
        public string[] ciudades { get; set; } = [];

    }
}
