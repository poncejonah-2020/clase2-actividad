using System;
using System.Collections.Generic;

namespace act_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de los arrrays
            string[] colores = { "MAGENTA", "RED", "WHITE", "BLUE", "CYAN" };
            string[] coloresRemove = { "RED", "WHITE", "BLUE" };

            //Declaracion de listas
            List<string> color = new List<string>();
            List<string> colorRemov = new List<string>();

            //Carga de la Lista color
            for(int i=0; i<colores.Length;i++)
            {
                color.Add(colores[i]);
            }
            
            Console.WriteLine("Lista original");
            foreach(string elemento in color)
            {
                Console.WriteLine(elemento);
            }
            Console.WriteLine("\n");

            //Carga de la Lista colorRemov
            for (int x = 0; x < coloresRemove.Length; x++)
            {
                colorRemov.Add(coloresRemove[x]);
            }

            Console.WriteLine("Lista Remove");
            foreach (string elemento1 in colorRemov)
            {
                Console.WriteLine(elemento1);
            }
            Console.WriteLine("\n");

            //Eliminando elementos
            for (int i=0; i<color.Count;i++)
            {
                for(int x=0; x<colorRemov.Count;x++)
                {
                    if (color[i] == colorRemov[x])
                    {
                        color.RemoveAt(i);
                    }
                }
            }

            //Lista final
            Console.WriteLine("Lista resultante");
            foreach(string elemento2 in color)
            {
                Console.WriteLine(elemento2);
            }
        }   
    }
}


