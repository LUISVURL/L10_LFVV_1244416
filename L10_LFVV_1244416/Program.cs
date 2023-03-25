using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace L10_LFVV_1244416
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Write("\tMenú\n\n1. Suma\n2. Multiplicación\n3. Raíz Cuadrada\n4. Porcentaje de un número ingresado\n5. Salir\n\nIngrese número de la opción: ");
            switch (Console.ReadLine())
            {
                case "1":
                    Suma();
                    Menu();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("\tMultiplicación\n");
                    int mult1;
                    int mult2;
                    MULTI1:
                    try
                    {
                        Console.Write("Ingrese primer número entero a multiplicar: ");
                        mult1=int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("ERROR: El valor ingresado no es un número entero\n");
                        goto MULTI1;
                    }
                    Console.WriteLine();
                    MULTI2:
                    try
                    {
                        Console.Write("Ingrese segundo número entero a multiplicar: ");
                        mult2 = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("ERROR: El valor ingresado no es un número entero\n");
                        goto MULTI2;
                    }
                    Console.WriteLine("\nEl resultado de la multiplicación es: " + Multiplicacion(mult1,mult2));
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("\tRaíz Cuadrada\n");
                    double R1;
                RAIZ:
                    try
                    {
                        Console.Write("Ingrese un número: ");
                        R1 = double.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("ERROR: El valor ingresado no es válido\n");
                        goto RAIZ;
                    }
                    Console.WriteLine("\nLa raíz cuadrada de " + R1 + " es: " + Raiz(R1));
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case "4":
                    Porcentaje();
                    Menu();
                    break;
                case "5":
                    Salir();
                    break;
                default:
                    Console.WriteLine("\nERROR: Opción no válida");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
            }
            Console.ReadKey();
        }

        static void Suma()
        {
            Console.Clear();
            int N = 0;
            int Suma = 0;
            Console.WriteLine("\tSuma\n");
            for (int x = 0; x < 3;)
            {
                INGRESARSUMA:
                try
                {
                    Console.Write("Ingrese un número entero para sumar: ");
                    N = int.Parse(Console.ReadLine());
                    Suma = Suma + N;
                    x++;

                }
                catch
                {
                    Console.WriteLine("ERROR: El valor ingresado no es un número entero\n");
                    goto INGRESARSUMA;
                }
            }
            Console.WriteLine("\nLa suma total es de: "+Suma);
            Console.ReadKey();
            Console.Clear();
        }
        static int Multiplicacion(int a,int b)
        {
            int multiplicacion1 = 0;
            multiplicacion1 = a * b;
            return multiplicacion1;

        }
        static double Raiz (double a)
        {
            double raizop = 0;
            raizop = Math.Round((Math.Sqrt(a)),2);
            return raizop;
        }

        static void Porcentaje()
        {
            double porcentaje = 0, valor1=0,valor2=0;
            Console.Clear();
            Console.WriteLine("\tPorcentaje\n");
            VAL1:
            try
            {
                Console.Write("Ingrese un número: ");
                valor1= double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("ERROR: El valor ingresado no es válido\n");
                goto VAL1;
            }
            Console.WriteLine();
            VAL2:
            try
            {
                Console.Write("Ingrese un el valor del porcentaje que desea encontrar: ");
                valor2 = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("ERROR: El valor ingresado no es válido\n");
                goto VAL2;
            }

            porcentaje = Math.Round((valor1 * (valor2 / 100)),2);

            Console.WriteLine("\nEl "+valor2+"% de "+valor1+" es igual a: "+porcentaje);
            Console.ReadKey();
            Console.Clear();
        }
        public static void Salir()
        {
            Environment.Exit(0);
        }
    }
}
