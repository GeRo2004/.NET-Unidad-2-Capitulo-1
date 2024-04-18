namespace ParaPensar
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Ejercicio1()
            {
                Console.WriteLine("Dame un numero");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dame otro numero");
                int b = Convert.ToInt32(Console.ReadLine());
                int resultado = a + b;

                Console.WriteLine("El resultado de la suma de " + a + " y " + b + " es " + resultado);
            }

            static void Ejercicio2()
            {
                Console.WriteLine("Dame un año");
                int año = Convert.ToInt32(Console.ReadLine());
                if(año % 4 == 0 && (año % 100 != 0 || año % 400 == 0))
                {
                    Console.WriteLine("Es bisiesto");
                }
                else
                {
                    Console.WriteLine("No es bisiesto");
                }
            }

            static void Ejercicio3()
            {
                int anterior = 1;

                Console.WriteLine("Ingrese el valor hasta donde desea calcular la suma de la sucesion");
                int valor = Convert.ToInt32(Console.ReadLine());
                int sumaFibo = 1;
                for(int i = 0; i < valor; i++)
                {
                    Console.WriteLine(sumaFibo);
                    if(i == 0)
                    {
                        sumaFibo++;
                    }
                    sumaFibo = anterior + sumaFibo;
                    anterior = sumaFibo;
                    
                }
                Console.WriteLine("suma: " +  sumaFibo);
            }

            Ejercicio3();



        }
    }
}
