using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Ejercicio4
{
    class Ejercicio4
    {
        public static IEnumerable<int> Pares(int from, int to)
        {
            if(to < from || from < 0)
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
                if(from <= 10)
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
            if (to < from || from >=10 || from < 0)
            {
                throw new ArgumentException("Los argumentos no son correctos");
            }
            else
            {
                if(to <= 10)
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
        static void Main(string[] args)
        {            
            try
            {
                var from = 5;
                var to = 15;
                var maxPares = Pares(from,to).Max();
                Console.WriteLine("El máximo de los números pares comprendidos entre {0} y {1} es {2}", 
                                    from, to, maxPares);
                var maxMax10 = MayoresDe10(5, 15).Max();
                Console.WriteLine("El máximo de los números mayores de 10 comprendidos entre {0} y {1} es {2}", 
                                    from, to, maxMax10);
                var maxMin10 = MenoresDe10(5, 15).Max();
                Console.WriteLine("El máximo de los números menores de 10 comprendidos entre {0} y {1} es {2}", 
                                    from, to, maxMin10);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}*/
