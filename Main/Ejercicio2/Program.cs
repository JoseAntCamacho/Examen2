using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Ejercicio2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var a = new int[] {1,2,3};
            var b = new int[] {1,2};

            var itemsANoB = a.Where(c => !b.Contains(c)).ToList();
            var itemsANoB2 = a.Except(b).ToList();

            Console.WriteLine("Prueba con el método Contains()");

            foreach(var item in itemsANoB)
            {
                Console.WriteLine(item);
            }           

            Console.WriteLine("Prueba con el método Except()");
            
            foreach(var item in itemsANoB2)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadLine();

            // la secuencia SQL sería:
            // Select * from a Left join b on a.Id = b.Id where b.Id is null
        }
    }
}*/

/*namespace Ejercicio3
{
    class Program
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
                var items = Pares(20,30);
                foreach (var item in items)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("__________________________");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


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


/*namespace Pruebas
{
    var lstFacturas = new List<Factura>
            {
            new Factura {IdFactura = 1, Importe = 500 },
            new Factura {IdFactura = 2, Importe = 1200 },
            new Factura {IdFactura = 3, Importe = 400 },
            new Factura {IdFactura = 4, Importe = 3500 }
            };

    var lstDescuentos = new List<FacturaDescuento>
            {
                new FacturaDescuento {IdFactura = 2, Descuento = 20 },
                new FacturaDescuento {IdFactura = 4, Descuento = 100 }
            };

    var lstLeftJoin =
        (from fact in lstFacturas
        join desc in lstDescuentos on fact.IdFactura equals desc.IdFactura into FactDesc
        from fd in FactDesc.DefaultIfEmpty()
        select new
        {
            IdFactura = fact.IdFactura,
            ImporteBase = fact.Importe,
            ImporteACobrar = (fd == null) ? fact.Importe : fact.Importe - fd.Descuento
        }
        ).ToList();
         
}*/
