using System;
using System.Collections.Generic;
using System.Text;

namespace Poo_2026
{
    public class Ejemplo9Listas
    {
        //inicialice la lista con valores
        public List<int> listaNumeros { get; set; } = new List<int>()
        {
            10, 20, 30, 40, 50, 60
        };
        public List<string> listaNombre { get; set; } = new List<string>()
        {
            "Ciro", "Carlos", "Mariana", "Gustavo"
        };
        public Ejemplo9Listas()
        {
            #region ListaNumeros
            //Console.WriteLine($"Elemento en la posicin 2 : {listaNumeros[2]}");
            //Console.WriteLine("--------LISTAR----------");
            //foreach(var item in listaNumeros)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("--------AGREGAR-----------");
            //listaNumeros.Add(70);
            //listaNumeros.Add(80);
            //foreach (var item in listaNumeros)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("--------ELIMINAR----------");
            //listaNumeros.Remove(40);
            //listaNumeros.Remove(60);
            //listaNumeros.RemoveAt(0);//posicion
            //listaNumeros.RemoveAt(3);
            //foreach (var item in listaNumeros)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("---------Clear-------------");
            //listaNumeros.Clear();
            //foreach (var item in listaNumeros)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("--------------------------");
            #endregion
            #region ListaNombres
            Console.WriteLine($"Cantidad de elementos : {listaNombre.Count}");
            Console.WriteLine("-----Sin Ordenar------");
            foreach (var item in listaNombre)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----Ordenado Alfabeticamente----");
            listaNombre.Sort();
            foreach (var item in listaNombre)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------Ordenado-------");
            listaNombre.Sort(2, 2, default);
            foreach (var item in listaNombre)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------Desordeno-------");
            listaNombre.Reverse();
            foreach (var item in listaNombre)
            {
                Console.WriteLine(item);
            }
            #endregion
        }

    }
}    
