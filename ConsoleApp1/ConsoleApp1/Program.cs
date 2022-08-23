using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Resta de dos números");
                Console.WriteLine("[3] Division de dos números");
                Console.WriteLine("[4] Multiplicacion de dos números");
                Console.WriteLine("[5] Imprimir los 10 primeros numeros primos");
                Console.WriteLine("[6] Imprimir la raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[7] Conversion de temperatura F a C"  );
                Console.WriteLine("[8] Conversion de temperatura C a F");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer número");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.ReadKey();
                        break;
                   
                    case "2":
                        Console.WriteLine("Ingrese el primer número");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La resta de {0} y {1} es {2}", c, d, Resta(c, d));
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el primer número");
                        int j = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int k = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La division de {0} y {1} es {2}", j, k, Division(j, k));
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el primer número");
                        int h = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int i = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La Multiplicacion de {0} y {1} es {2}", h, i, Multiplicacion(h, i));
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Calculando...");
                        NPrimos();
                        Console.ReadKey();
                        break;

                    case "6":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.WriteLine("Ingrese el primer número");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                       
                        Console.WriteLine("La conversion de Farenheit a Celsius de {0} es {1} ", num2, FaC(num2));
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.WriteLine("Ingrese el primer número");
                        int num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La conversion de  Celsius a Farenheit de {0} es {1}", num, CaF(num));
                        Console.ReadKey();
                        break;


                }
                
            } while (!opcion.Equals("0"));

        }

        static int Suma(int a, int b)
        {
            return a + b;
        }
        static int Resta(int c, int d)
        {
            return c - d;
        }
        static int Multiplicacion(int h, int i)
        {
            return h * i;
        }
        static int Division(int j, int k)
        {
            return j / k;
        }
        static int CaF(int num)
        {
            return  ((9 * num) / 5) + 32;
        }
        static int FaC(int num2)
        {
            return (5 * (num2 - 32)) / 9;
        }


        //Procedimiento que imprime la raíz cuadrada de los 10 primeros números
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raíz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
            }
        }
        static void NPrimos()
            
        {
            int num = 2, di = 0;
            while (num < 11)
            {
                for(int i = 1;i <= num; i++)
                {
                    if(num%i == 0)
                    {
                        di++;
                    }
                    if (di > 2)
                    {
                        break;
                    }
                }
                if (di == 2)
                {
                    Console.Write("Es primo  {0} ",num);
                }
                di = 0;
                num++;
            }
           
        }

    }

}
