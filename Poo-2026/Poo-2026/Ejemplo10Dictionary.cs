using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Poo_2026
{
    public class Ejemplo10Dictionary
    {
        public Dictionary<string, Provincias> provincias =
           new Dictionary<string, Provincias>();
        public Ejemplo10Dictionary()
        {
          Provincias p1 = new Provincias();
          {
                p1.Cod = "01";
                p1.NombreProv = "Buenos Aires";
                p1.CantidadHabitantes = 156000;
          }
          string clave1 = Guid.NewGuid().ToString();
          provincias.Add(clave1,p1);
          Provincias p2 = new Provincias();
          {
                p2.Cod = "02";
                p2.NombreProv = "Cordoba";
                p2.CantidadHabitantes = 15600;
          }
          string clave2 = Guid.NewGuid().ToString();
          provincias.Add(clave2,p2);
            Provincias p3 = new Provincias();
          {
                p3.Cod = "03";
                p3.NombreProv = "Corrientes";
                p3.CantidadHabitantes = 1560;
          }
          string clave3 = Guid.NewGuid().ToString();
          provincias.Add(clave3,p3);
          Provincias p4 = new Provincias();
          {
                p4.Cod = "04";
                p4.NombreProv = "Entre Ríos";
                p4.CantidadHabitantes = 9000;
          }
          string clave4 = Guid.NewGuid().ToString();
            provincias.Add(clave4,p4);

          Console.WriteLine("----------------------------");
          Console.WriteLine($"Nombre de la provincia con clave 2: {provincias[clave2].NombreProv}");
          Console.WriteLine("----------------------------");
          Console.WriteLine($"Cantidad de elementos es: {provincias.Count().ToString().ToString()}");
          Console.WriteLine("----------------------------");
          foreach (var item in provincias)
          {
            Console.WriteLine($"{item.Key} - {item.Value.Cod} - " +
                    $"{item.Value.NombreProv} - {item.Value.CantidadHabitantes.ToString()}");
          }
          Console.WriteLine("----------------------------");
          foreach (var item in provincias.Keys)
          {
            Console.WriteLine($"{item}");
          }
          Console.WriteLine("----------------------------");
          foreach (var item in provincias.Values)
          {
            Console.WriteLine($"{item.Cod}-{item.NombreProv}-{item.CantidadHabitantes}");
          }
          Console.WriteLine("----------------------------");
        }
    }
    public class Provincias
    {
        public string Cod { get; set; }
        public string NombreProv { get; set; }
        public int CantidadHabitantes { get; set; }

    }
}
    

      
 