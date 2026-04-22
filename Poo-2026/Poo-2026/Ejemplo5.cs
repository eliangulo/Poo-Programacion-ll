using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Poo_2026;
    
public class Ejemplo5
{
    #region Constructores
    //public Ejemplo5()//constructor

    /* PersonaBD pBD = new PersonaBD(); //inicializacion de la clase PersonaBD
     pBD.ObtenerPersona(1);
     Console.WriteLine("---------------------------");
     PersonaLista pLista = new PersonaLista(); //inicializacion de la clase PersonaLista
     pLista.ObtenerPersona(1);
     Console.WriteLine("---------------------------");*/

    #endregion
    public void EjecutarBuscaePersona(IBuscarPersona bp, int id)
    {
        bp.ObtenerPersona(id);
    }
    public IBuscarPersona EjecutarBuscaePersona(TipoBusqueda tipo)
    {
        switch (tipo)
        {
            case TipoBusqueda.BaseDato:
                return new PersonaBD();
            case TipoBusqueda.Lista:
                return new PersonaLista();
            default:
                throw new ArgumentException("Tipo de busqueda no valido");
        }
    }
}
public class PersonaBD : IBuscarPersona
{
    #region Metodos
    public void ObtenerPersona(int id)
    {
        Console.WriteLine($"Obteniendo persona ID = {id} desde la BD...");
    }
    #endregion
}
public class PersonaLista : IBuscarPersona
{
    #region Metodos
    public void ObtenerPersona(int id)
    {
       Console.WriteLine($"Obteniendo persona id = {id} desde una Lista..");
    }
    #endregion
}
#region Interfaces
public interface IBuscarPersona
{
    void ObtenerPersona(int id);
}
#endregion
public enum TipoBusqueda
{
    BaseDato,
    Lista
}

