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

            foreach(var item in itemsANoB)
            {
                Console.WriteLine(item);
            }           

            var items = from a1 in a join b1 in b on a1 equals b1 select a1;

            foreach(var i in items)
            {
                Console.WriteLine(i);
            }
            
            Console.ReadLine();

            // la secuencia SQL sería:
            // Select * from a Left join b on a.Id = b.Id where b.Id is null
        }
    }
}*/

namespace Ejercicio3
{
    class Program
    {
        public static List<int> Pares(List<int> l)
        {
            var lista = new List<int>();
            foreach(var a in l){
                if (a % 2 == 0)
                {
                    lista.Add(a);
                }
            }
            return lista;
        }

        public static List<int> MayoresDe10(List<int> l)
        {
            var lista = new List<int>();
            foreach(var a in l)
            {
                if (a > 10)
                {
                    lista.Add(a);
                }
            }
            return lista;
        }

        static void Main(string[] args)
        {
            List<int> lista = new List<int>
            {
                1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19
            };
            foreach(var a in Pares(lista))
            {
                Console.Write(a + ", ");
            }
            Console.WriteLine(" ");
            foreach (var a in MayoresDe10(lista))
            {
                Console.Write(a + ", ");
            }
            Console.WriteLine(" ");
            Console.ReadLine();
        }
    }
}


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
