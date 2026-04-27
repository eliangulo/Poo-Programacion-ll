using System;
using System.Collections.Generic;
using System.Text;

namespace Poo_2026;

//herencia
public class Ejemplo7
{
    EntidadBase entidad = new EntidadBase();
    public Ejemplo7()
    {
        //instanciamos la clase base
        entidad.Id = 10;
        Console.WriteLine(entidad.MostrarId());
        //instanciamos la clase derivada
        Producto prod = new Producto();
        prod.NombreProducto = "Memoria Ram";
        Console.WriteLine("---------------------");
        Console.WriteLine(prod.MostrarId());
        Console.WriteLine(prod.MostrarProducto());
        Console.WriteLine("---------------------");
        prod.Id = 20;
        Console.WriteLine(entidad.MostrarId());
        Console.WriteLine(prod.MostrarProducto());
    }

}
public class EntidadBase
{
    public int Id { get; set; }
    public string MostrarId()
    {
        return $"El id es: {Id}";
    }
      
}
public class Producto : EntidadBase
{
    public string? NombreProducto { get; set; }
    public string MostrarProducto()
    {
        return $"El nombre del producto es: {NombreProducto} con id: {Id}";
    }
}


