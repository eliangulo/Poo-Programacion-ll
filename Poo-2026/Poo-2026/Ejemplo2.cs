using System;
using System.Collections.Generic;
using System.Text;

namespace Poo_2026
{
    public class Ejemplo2
    {
        //pasar un argumento por valor
        Tipos tt = new Tipos();
        public Ejemplo2()
        {
            //referencia
             Num n = new Num();
             n.Numero = 5;
            Console.WriteLine($"ANTES de llamar al metodo valor {n.Numero}");
            tt.Referencia(n);
            Console.WriteLine($"ANTES de llamar al metodo valor {n.Numero}");
            
            //valor
            // int x = 5;
            //Console.WriteLine($"ANTES de llamar al metodo valor {x}"); //imprime 5, no se modifica el valor de x
            //tt.Valor(x);
            //Console.WriteLine($"DESPUES de llamar al metodo valor {x}"); //imprime 5, no se modifica el valor de x
        }
    }
    //no tiene ni propidades ni campòs, solo tendra metodos
    public class Tipos
    {
        public void Valor( int x)
        {
            Console.WriteLine($"Al INICIO del metodo valor {x}");
            x = x + 10;
            Console.WriteLine($"Al FINAL del metodo valor {x}"); 
        }
        public void Referencia(Num n)
        {
            Console.WriteLine($"Al INICIO del metodo referencia {n.Numero}");
            n.Numero = n.Numero + 10;
            Console.WriteLine($"Al FINAL del metodo referencia {n.Numero}");
        }
    }
    public class Num
    {
        public int Numero { get; set; }
    }
}
