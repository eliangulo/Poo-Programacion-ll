using System;
using System.Collections.Generic;
using System.Text;

namespace Poo_2026;

//tenemos una clase static con un metodo static.
//Si mi clase es static y mi mtdo no, entonces tengo un error.
//tengo la clase no staic y dos mtdos, uno static y otro no static, entonces puedo usar ambos tipos de mtdos sin problemas.

public class Ejemplo6
{
    /*public static void PruebaStatic()
    { 
        Console.WriteLine("Ejemplo numero 6 mtdo static");
    }*/

    public void MetodoConError()
    {
        int res = 0;
        int a = 1;
        try
        {
            res = a / 0;
        }
        catch (Exception e)
        {
            var mensaje = Util.MensajeError("el mensaje de error", e, true, true);
            Console.WriteLine(mensaje);
        }


    }
    public void CalcularEdad()
    {
         Console.WriteLine(Util.CalcularEdad(new DateTime(1995, 2, 21)));
         Console.WriteLine("------------------");
         var fecha = new DateTime(2000, 5, 2);
         Console.WriteLine($"Edad con extension:{fecha.CalcularEdad()}");
         Console.WriteLine("------------------");

    }
}
public static class Util
{
   public static void Imprimir(string texto) //mtdo para el ej8
    {
        Console.WriteLine(texto);
    }

    public static string MensajeError(string mensaje="",
                                      Exception? e = null,
                                      bool conTrace = false,
                                      bool conInner = false)
    {
        var msg = mensaje;
        
        if(e != null)
        {
            if (msg != "")
            {
                msg = msg + "\r\n";
            }
            msg = $"{msg}{e.Message}";

            if (conTrace)
            {
                msg = $"{msg} \r\n{e.StackTrace}";
            }
            if (conInner && e.InnerException != null)
            {
                msg = $"{msg} \r\n Inner: {e.InnerException.Message}";
            }
        }
        return msg;
    }
    public static int CalcularEdad(this DateTime fechaNacimiento,
                                      DateTime? fecha = null)
    {
        var fechaCalculo = (fecha ?? DateTime.UtcNow).Date;
        var nacimiento = fechaNacimiento.ToUniversalTime().Date;
        var edad = fechaCalculo.Year - fechaNacimiento.Year;
        if (fechaNacimiento > fechaCalculo.AddYears(-edad)) edad--;
        return edad;
    }

}
