using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            var a = new int[] { 1, 2, 3 };
            var b = new int[] { 1, 2 };

            var itemsANoB = a.Where(c => !b.Contains(c)).ToList();
            var itemsANoB2 = a.Except(b).ToList();

            Console.WriteLine("Prueba con el método Contains()");

            foreach (var item in itemsANoB)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Prueba con el método Except()");

            foreach (var item in itemsANoB2)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();


            //var result = a.GroupJoin(b, c => c, d => d, (c, d) => new {c,d}).Where(e=>e.d is null);           

            // la secuencia SQL sería:
            // Select * from a Left join b on a.Id = b.Id where b.Id is null
        }
    }
}
