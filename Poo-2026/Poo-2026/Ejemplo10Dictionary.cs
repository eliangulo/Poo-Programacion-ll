using System;
using System.Collections.Generic;
using System.Text;

namespace Poo_2026
{
    public class Ejemplo10Dictionary
    {
        public Dictionary<string, Provincia> Provincias { get; set; } =
            new Dictionary<string, Provincia>()
            {

            };

        public Ejemplo10Dictionary()
        {
            Provincia p1 = new Provincia()
            { Cod = "01", NombreProv = "Buenos Aires", CantidadHabitantes = 15600000 };
            Provincia p2 = new Provincia()
            { Cod = "02", NombreProv = "Cordoba", CantidadHabitantes = 3560000 };
            string clave1 = Guid.NewGuid().ToString();
            string clave2 = Guid.NewGuid().ToString();

            Provincias.Add(clave1, p1);
            Provincias.Add(clave2, p2);

            Console.WriteLine($"Cantidad de elementos {Provincias.Count.ToString()}");
            Console.WriteLine($"Nombre de la provincia con clave 2 : {Provincias[clave2].NombreProv} ");

            foreach (var item in Provincias)
            {
                Console.WriteLine($"{item.Key}-{item.Value.Cod} - {item.Value.NombreProv} - {item.Value.CantidadHabitantes.ToString()}");

            }

        }
        public class Provincia
        {
            public string Cod { get; set; }
            public string NombreProv { get; set; }
            public string claveTel { get; set; }
            public int CantidadHabitantes { get; set; }
            public override string ToString()
            {
                return $"Cod: {Cod}, Nombre: {NombreProv}, Habitantes: {CantidadHabitantes}, Clave Tel: {claveTel}";
            }
        }

    }
}
