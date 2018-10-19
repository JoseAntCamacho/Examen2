using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        delegate int Funcion(int a, int b);

        static int Suma(int a, int b)
        {
            return a + b;
        }

        static int Producto(int a, int b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            var valor1 = 5;
            var valor2 = 4;

            // Con función lambda.
            Funcion funcion = (a, b) => a + b;
            var suma = funcion(valor1, valor2);
            funcion = (a, b) => a * b;
            var producto = funcion(valor1, valor2);
            Console.WriteLine("La suma de los valores {0} y {1} es: {2}", valor1, valor2, suma);
            Console.WriteLine("La multiplicación de los valores {0} y {1} es: {2}", valor1, valor2, producto);

            // Con métodos.
            valor1 = 3;
            valor2 = 9;
            funcion = Suma;
            suma = funcion(valor1, valor2);
            funcion = Producto;
            producto = funcion(valor1, valor2);
            Console.WriteLine("La suma de los valores {0} y {1} es: {2}", valor1, valor2, suma);
            Console.WriteLine("La multiplicación de los valores {0} y {1} es: {2}", valor1, valor2, producto);

            Console.ReadLine();
        }
    }
}
