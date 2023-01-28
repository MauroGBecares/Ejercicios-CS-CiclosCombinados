using System;

namespace Actividad_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. 
            // El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.
            // int n, con;

            // Console.WriteLine("Ingrese un número:");
            // n = int.Parse(Console.ReadLine());

            // while (n >= 0)
            // {
            //     con = 0;
            //         while (n > 0)
            //         {
            //             con++;
            //             Console.WriteLine("Ingrese un número:");
            //             n = int.Parse(Console.ReadLine());
            //         }
            //     Console.WriteLine("En esta lista hay " + con + " cantidad de números");
            //     Console.WriteLine("-------------------------------------------------");
            //     Console.WriteLine("Ingrese un numero positivo para continuar o negativo para finalizar la carga");
            //     n = int.Parse(Console.ReadLine());
                
                // OTRA MANERA
                int n, con;
                do
                {
                    con = 0;
                    Console.WriteLine("Ingrese un número:");
                    n = int.Parse(Console.ReadLine());
                    while (n > 0)
                    {
                        con++;
                        Console.WriteLine("Ingrese un número:");
                        n = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("La cantidad de numeros que hay en el grupo es: " + con);
                }while(n >= 0);
            }
        }
    }

