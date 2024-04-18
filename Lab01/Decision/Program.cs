using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputTexto;
            System.Console.WriteLine("Ingrese una frase");
            inputTexto = Console.ReadLine();
            if (inputTexto.Length != 0)

            {
          
                System.Console.WriteLine("Menu" +
                    "1- Convertir la frase a mayuscula"+
                    "2- Convertir la frase a minuscula" +
                    "3- Mostrar la cantidad de caracteres de la frase");
                System.Console.WriteLine("Ingrese una opcion");
                
                ConsoleKeyInfo opcion = Console.ReadKey();

                if (opcion.Key == ConsoleKey.D1 )
                {
                    inputTexto = inputTexto.ToUpper();
                    System.Console.WriteLine(inputTexto);
                    Console.ReadKey();
                }
                else if (opcion.Key == ConsoleKey.D2)
                {
                    inputTexto = inputTexto.ToLower();
                    System.Console.WriteLine(inputTexto);
                    Console.ReadKey();

                }
                else if (opcion.Key == ConsoleKey.D3)
                {
                    int cant = inputTexto.Length;
                    System.Console.WriteLine(cant);
                    Console.ReadKey();

                }
                else
                {
                    System.Console.WriteLine("Usted ingresò una opcion no valida");
                    Console.ReadKey();

                }
            }
            else
            {
                System.Console.WriteLine("No ingresaste un texto");
                Console.ReadKey();

            }
        }
    }
}
