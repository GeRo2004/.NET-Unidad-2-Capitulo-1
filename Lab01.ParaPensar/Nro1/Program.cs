using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nro1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nro1;
            int nro2;
            System.Console.WriteLine("Ingrese un numero");
            string opc = System.Console.ReadLine();
            nro1 = int.Parse(opc);
            System.Console.WriteLine("Ingrese otro numero");
            string opc2 = System.Console.ReadLine();
            nro2 = int.Parse(opc2);
            int suma= nro1 + nro2;
            System.Console.WriteLine("El resultado de la suma de " + nro1 + " y " + nro2+" es "+suma+" .");
            Console.ReadKey();
        


        }
    }
}
