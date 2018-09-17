using System;
using System.Collections;

namespace Cola
{
    public class Program
    {
        public static void Main()

        {
            String palabra;  // se declara la variable string
            Queue miCola = new Queue();  // Genera la variable miCola y a la inicia como nueva Cola.
            miCola.Enqueue("hola");  // ingreso la primera palabra
            miCola.Enqueue("Soy");  //ingreso la segunda palabra
            miCola.Enqueue("yo");  // ingreso la tercera palabra
            for(byte i = 0; i<3;i++)   // creamos un for para que itere cada una de las palabras hasta el final
            {
                palabra = (String) miCola.Dequeue(); // le asignamos el valor actual de la cola y el comando Dequeue para que haga la salida(saca la palabra).
                Console.WriteLine(palabra); // se manda a que salga  en la consola palabra.
            }
            Console.ReadKey();

        }
    }
}
