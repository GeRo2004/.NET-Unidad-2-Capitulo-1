﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteracion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantIteraciones = 5;
            string[] arreglo = new string[cantIteraciones];

            for (int i = 0; i < cantIteraciones; i++)
            {
                System.Console.WriteLine("Ingrese una palabra");
                arreglo[i] = System.Console.ReadLine();
            }

            for (int i = cantIteraciones-1; i >= 0; i--)
            {
                System.Console.WriteLine(arreglo[i]);
               
                
            }
            Console.ReadKey();

        }
    }
}
