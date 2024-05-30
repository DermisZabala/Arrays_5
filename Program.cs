
using System;

namespace Arrays_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array que recibe un método por parámetro
            int[] valores = new int[14] { 99, 88, 77, 66, 55, 44, 33, 22, 11, 100, 20, 0, 0, 0 };

            tarea(valores);

            foreach(int i in valores)
            {
                Console.WriteLine(i);
            }
            //---------------------------------------------------------------------------------------------------------------
            //array con método return
            int[] valoresM2;
            valoresM2 = usuario();

            Console.WriteLine("\nImprimiendo los valores desde el método Main");

            foreach (int i in valoresM2)
            {
                Console.WriteLine(i);
            }


        }
        //---------------------------------------------------------------------------------------------------------------
        //método que recibe un array por parámetro
        static void tarea(int[] datos)
        {
            int k = 10;
            for(int i = 0; i < datos.Length; i++)
            {
                datos[i] += k;
                k--;
            }
            
        }
        //---------------------------------------------------------------------------------------------------------------
        //método que devuelve un array
        static int[] usuario()
        {
            int p = 0;
            Console.WriteLine("\nIngresa la longitud que desea que tenga el array: ");
            int longitud = Convert.ToInt32(Console.ReadLine());

            int[] datos = new int[longitud];

            
            for(int i = 0; i < datos.Length; i++)
            {
                Console.WriteLine($"Rellene la posición n° {p}");
                int posicion = Convert.ToInt32(Console.ReadLine());
                
                datos[i] = posicion;
                p++;
            }

            return datos;
        }

    }
}
