using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_8
{
    class Program
    {
        static void matriz()
        {
            String[] nombre = new String[]
            {
                "Anderson","Brandon", "Yeimi", "Fatimz", "Vivian"
            };
            
            foreach (string n in nombre)
            {
                Console.WriteLine("nombre = " + n);
            }
            int[] notas = new int[]
            {
            51, 80, 96, 76, 61
            };
            string direc = nombre = new string[] 
            int promedio = 0;
            foreach (int n in notas)
            {
                promedio = promedio + n;
            }
            promedio = promedio / notas.Length;
            Console.WriteLine("El promedio es igual a "+promedio);
            int mayor = 0;
            for (int i = 0; i <notas.Length; i++)
            {
                Console.WriteLine(notas[i]);
                if (notas[i] > mayor)
                {
                    mayor = notas[i] = notas[i];
                }
               

            }
            Console.WriteLine("La nota mayor es {0} y la notas es de {1}", mayor, direc );
       
            Console.ReadKey();

        }


        static void Main(string[] args)
        {
            matriz();
        }
    }

    
    }
  

