using System;
using System.Collections.Generic;
using System.Text;

namespace Poo_2026;

//herencia
public class Ejemplo7
{
    //EntidadBase entidad = new EntidadBase();
    public Ejemplo7()
    {
        //instanciamos la clase base
       // entidad.Id = 10;
      //  Console.WriteLine(entidad.MostrarId());
        //instanciamos la clase derivada
        Producto prod = new Producto();
        prod.NombreProducto = "Memoria Ram";
        //Console.WriteLine("---------------------");
        //Console.WriteLine(prod.MostrarId());
        //Console.WriteLine(prod.MostrarProducto());
        Console.WriteLine("---------------------");
        prod.Id = 20;
        Console.WriteLine(prod.MostrarId());
        Console.WriteLine(prod.MostrarProducto());
        prod.InclementarId();
        //prod.MetodoProtegido(); el unico que puede usarlo es la clase que hereda de la clase base, en este caso la clase producto
    }
}
abstract public class EntidadBase
{
    public int Id { get; set; }
    public string MostrarId()
    {
        return $"El id es: {Id}";
    }
    public virtual int InclementarId()
    {
        Id++;
        return Id;
    }
    protected virtual void MetodoProtegido()
    {
        Console.WriteLine("Este es un método protegido");
    }
    abstract public int ReiniciarId();
}
public class Cliente : EntidadBase
{
    public string? NombreCliente { get; set; }
    public string Mostrarcliente()
    {
        return $"El nombre del cliente es: {NombreCliente} con id: {Id}";
    }
    public override int ReiniciarId()
    {
        Id = 0;
        return Id;
    }
    public override int InclementarId()
    {
        Id++;
        return Id;
    }

} 
public class Producto : EntidadBase
{
    public string? NombreProducto { get; set; }
    public Producto()
    {
        MetodoProtegido();
    }
    public string MostrarProducto()
    {
        return $"El nombre del producto es: {NombreProducto} con id: {Id}";
    }
    public override int ReiniciarId()
    {
        Id = 0;
        return Id;
    }
}


