using System;

namespace Actividad_2
{
    class Program
    {
        static void Main(string[] args)
        {
        //    2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:

        //     El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
        //     Informar cuántos grupos están formados por todos números ordenados de mayor a menor.
           
           int conord = 0, n, conn, conI, ord = 0, porImp, MaxPorImp = 0, MaxnumGrup = 0, conOrden;
           bool b;

            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Estas en el grupo Nº " + (x + 1));
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());
                b = false;
                conI = 0;
                conn = 0;
                conOrden = 0;

                    while (n != 0)
                    {
                        conn++;
                        if (n % 2 != 0)
                        {
                            conI++;
                        }
                        if (!b)
                        {
                            ord = n;
                            b = true;
                            conOrden++;
                        }
                        else if(ord => n)
                        {
                            ord = n;
                            conOrden++;
                        }
                        Console.WriteLine("Ingrese un número:");
                        n = int.Parse(Console.ReadLine());
                    }
                    porImp = conI/conn * 100;
                    if(x == 0)
                    {
                        MaxPorImp = porImp;
                        MaxnumGrup = x + 1;
                    }
                    else if (porImp > MaxPorImp)
                    {
                        MaxPorImp = porImp;
                        MaxnumGrup = x + 1;
                    }
                    if (conn == conOrden && conOrden != 1)
                    {
                        conord++;
                    }
            }
            Console.WriteLine("El número de grupo con mayor porcentaje de números impares es: " + MaxnumGrup);
            Console.WriteLine("Hay " + conord + " grupo/s ordenados de mayor a menor");
    
        }
    }
}
