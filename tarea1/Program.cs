using System;

namespace tarea1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int resultado;
 
            do
            {
 
                Console.Write("Escriba un numero positivo:");
                numero1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Escriba otro numero positivo:");
                numero2 = Convert.ToInt32(Console.ReadLine());
                resultado = numero1 + numero2;
                    if (numero1 <= 0 || numero2 <= 0)

                        Console.WriteLine("error, intente de nuevo el coditgo");
                    else
                    {
                       Console.WriteLine("El resultado es {0}", resultado); 
                    }
                    break;
            }while(numero1 != 0 || numero2 != 0);

                    Console.WriteLine("Haga click para salir del programa...");         
        }
    }
}