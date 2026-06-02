using System;
using System.Collections.Generic;
using System.Text;

namespace Poo_2026
{
    public class Ejemplo9Listas
    {
        public List<int> listaNumeros = new List<int>() { 10, 20, 30, 40};
        public List<string> listaNombres = new List<string>() { "Juan", "Maria", "Pedro", "Ana" };

        public Ejemplo9Listas()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine($"El elemento de la posicion 2 es: {listaNumeros[2]}");

            Console.WriteLine("--------Listado de Elementos--------");
            foreach (var item in listaNumeros)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----Add--------");
            listaNumeros.Add(50);
            listaNumeros.Add(60);
            foreach (var item in listaNumeros)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----Remove-------");
            listaNumeros.RemoveAt(3);//remover con la posicion del elemento
            listaNumeros.Remove(10);
            listaNumeros.Remove(20);
            foreach (var item in listaNumeros)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----Clear-------");
            listaNumeros.Clear();
            foreach (var item in listaNumeros)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----LISTA STRING-------");

            Console.WriteLine("-----Sort(ordenar)-------");
            listaNombres.Sort(); //ordenar alfabeticamente
            foreach (var item in listaNombres)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----Reversa-------");
            listaNombres.Reverse();
            foreach (var item in listaNombres)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------");
            listaNombres.Sort(2,2, default);
            foreach (var item in listaNombres)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----Contar--------");
            Console.WriteLine($"Hay {listaNombres.Count()} elements en esta lista de nombres");
            Console.WriteLine($"Hay {listaNumeros.Count()} elements en esta lista de numeros");
        }
    }
}    
