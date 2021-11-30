using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Callfunciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BibliotecaDeFunciones.Operaciones ob1 = new BibliotecaDeFunciones.Operaciones();
            double x1 = ob1.suma(6.98, 100.00);
            double fac = ob1.factorial(5);
            Console.WriteLine($"La suma es {x1}");
            Console.WriteLine($"El factorial del numero 5 es {fac}");
            Console.WriteLine("Precione <Enter> para finalizar.....");
            Console.ReadLine();
        }
    }
}
