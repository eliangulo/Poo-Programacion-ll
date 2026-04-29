using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using static Poo_2026.Ejemplo8.Utilidades;

namespace Poo_2026;


public class Ejemplo8
{
    int[] numeros = { 1, 2, 3, 4, 5 }; //arreglo
    int[] cantidad = { };
    string[] palabras = { "programacion", "visual", "c#", "metodos" }; //arreglo
    DateTime[] fechas = { new DateTime(2020, 1, 1), new DateTime(2021, 2, 15), new DateTime(2022, 3, 30) }; //arreglo
    string[] nombres = { };
    public Ejemplo8()
    {
        #region mtd y clasee genericos
        ////Util.Imprimir($"Cantidad de numeros: {Utilidades.CantidadElementos(numeros)}");
        ////Util.Imprimir($"Cantidad de palabras: {Utilidades.CantidadElementos(palabras)}");
        ////Util.Imprimir($"Cantidad de fechas: {Utilidades.CantidadElementos(fechas)}");
        //Util.Imprimir($"Cantidad de numeros: {Utilidades.CantidadElementos<int>(numeros)}");
        //Util.Imprimir($"Cantidad de palabras: {Utilidades.CantidadElementos<string>(palabras)}");
        //Util.Imprimir($"Cantidad de fechas: {Utilidades.CantidadElementos<DateTime>(fechas)}");
        //UtilidadesArreglos<int> utililInt = new UtilidadesArreglos<int>();
        //Util.Imprimir($"Primer elemento de numeros: {utililInt.PrimerElemento(numeros)}");
        //Util.Imprimir($"Primer elemento de sin numeros: {utililInt.PrimerElemento(cantidad)}");

        //UtilidadesArreglos<String> utililString = new UtilidadesArreglos<String>();
        //Util.Imprimir($"Primer elemento de palabras: {utililString.PrimerElemento(palabras)}");
        //Util.Imprimir($"Primer elemento de sin palabras: {utililString.PrimerElemento(nombres)}");

        //UtilidadesArreglos<DateTime> utililDateTime = new UtilidadesArreglos<DateTime>();
        //Util.Imprimir($"Primer elemento de dias: {utililDateTime.PrimerElemento(fechas)}");

        //UtilidadesArreglos<DateTime> utililFecha = new UtilidadesArreglos<DateTime>();
        //Util.Imprimir(
        //    $"ultimo elemento de dias: {utililFecha.ultimoElemento(fechas)}");
        #endregion

        #region Control de restricciones
        UtilidadesArreglos<Vehiculo> utililVehiculo = new UtilidadesArreglos<Vehiculo>();
        UtilidadesArreglos<Auto> utililAuto = new UtilidadesArreglos<Auto>();
        #endregion
    }
    public static class Utilidades
    {
        //public static int CantidadElementos(int[] arreglo)
        //{
        //    return arreglo.Length;
        //}
        //public static int CantidadElementos(string[] arreglo)
        //{
        //    return arreglo.Length;
        //}
        //public static int CantidadElementos(DateTime[] arreglo)
        //{
        //    return arreglo.Length;
        //}

        //mtd generico
        public static int CantidadElementos<T>(T[] arreglo)
        {
            return arreglo.Length;
        }

        //clase generica
        //struct, class. new(), notnull, unmanaged, enum, delegate
        public class UtilidadesArreglos<T> where T : Vehiculo, new()
        {
            public T PrimerElemento(T[] arreglo)
            {
                if (arreglo.Length > 0)
                {
                    return arreglo[0];
                }
                else
                {
                    return default(T); // Devuelve el valor predeterminado para el tipo T
                }
            }
            public T ultimoElemento(T[] arreglo)
            {
                if (arreglo.Length > 0)
                {
                    return arreglo[arreglo.Length - 1];
                }
                else
                {
                    return default(T); // Devuelve el valor predeterminado para el tipo T
                }
            }

        }
    }
    //se puede instanciar porque auto hereda de vehiculo
    public class Vehiculo
    {

    }
    public class Auto : Vehiculo
    {
        private string Marca;
        public Auto(string marca)
        {
                
        }
        public Auto()
        {
            
        }
    }
}
