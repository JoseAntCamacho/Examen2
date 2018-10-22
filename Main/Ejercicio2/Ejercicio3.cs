using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Ejercicio3
    {
        //ANTIPATRONES. TE HAS MONTADO TÚ SOLICO LA PELÍCULA. SI LOS NÚMEROS SON NEGATIVOS TAMBIÉN HA DE FUNCIONAR.
        //NO SE HACEN LAS COMPROBACIONES. ADEMÁS, TODOS ESTOS MÉTODOS NO SIRVEN DE NADA.
        
        public static IEnumerable<int> Pares(int from, int to)
        {
            if (to < from || from < 0)  
            {
                throw new ArgumentException("Los argumentos no son correctos");

            }
            else
            {
                for (var i = from; i <= to; i++)
                {
                    if (i % 2 == 0) { yield return i; }
                }
            }
        }
        public static IEnumerable<int> MayoresDe10(int from, int to)
        {
            if (to < from || to <= 10 || from < 0)
            {
                throw new ArgumentException("Los argumentos no son correctos.");
            }
            else
            {
                if (from <= 10)
                {
                    for (var i = 11; i <= to; i++)
                    {
                        yield return i;
                    }
                }
                else
                {
                    for (var i = from; i <= to; i++)
                    {
                        yield return i;
                    }
                }

            }
        }
        public static IEnumerable<int> MenoresDe10(int from, int to)
        {
            if (to < from || from >= 10 || from < 0)
            {
                throw new ArgumentException("Los argumentos no son correctos");
            }
            else
            {
                if (to <= 10)
                {
                    for (var i = from; i <= to; i++)
                    {
                        yield return i;
                    }
                }
                else
                {
                    for (var i = from; i <= 10; i++)
                    {
                        yield return i;
                    }
                }
            }
        }

        // ESTE ES EL MÉTODO ÚNICO QUE HABRÍA QUE CONSTRUIR Y PONER UNA LAMBDA EN EL PREDICATE.3

        public static IEnumerable<int> Iterator(int from, int to, Func<int, bool> predicate)
        {
            if (null == predicate)
            {
                throw new ArgumentNullException("El predicado es nulo");
            }
            for(var i = from; i < to; i++)
            {
                if (predicate(i))
                {
                    yield return i;
                }
            }
        }

        static void Main(string[] args)
        {
            try
            {
                var items = Pares(20, 30);
                foreach (var item in items)
                {
                    Console.WriteLine(item);
                }

                var pares = Iterator(20, 30, (c) => c % 2 == 0);
                var mayores = Iterator(5, 25, (c) => c > 10);

                //si ahora le ponemos el .Max(c=>c) nos devuelve el máximo.
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
