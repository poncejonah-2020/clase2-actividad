using System;
using System.Collections.Generic;
using System.Text;

namespace act_3
{
    class Frase
    {
        public static void cargaDeListas(string[] text, List<string> palabra, List<string> palabraRem, List<int> contar)
        {
            
            for (int i = 0; i < text.Length; i++)
            {
                int repeticiones = 0;
                for (int x = i; x < text.Length; x++)
                {
                    if (text[i] == text[x])
                    {
                        repeticiones++;
                    }
                }
                palabra.Add(text[i]);
                contar.Add(repeticiones);
                if (repeticiones > 1)
                {
                    palabraRem.Add(text[i]);
                }

            }
        }

        public static void EliminarRepetidos(List<string> palabra, List<string> palabraRem, List<int>contar)
        {
            for (int n = 0; n < palabraRem.Count; n++)
            {
                Boolean band = true;
                for (int m = 0; m < palabra.Count; m++)
                {

                    if (palabra[m] == palabraRem[n])
                    {
                        if (band == true)
                        {
                            band = false;
                        }
                        else
                        {
                            palabra.RemoveAt(m);
                            contar.RemoveAt(m);
                        }
                    }

                }
            }
        }

        public static void imprimir (List<string> palabra, List<int>contar)
        {
            //Mostrar por pantalla el resultado
            Console.WriteLine("Palabras y sus repeticiones:\n");
            int cantPalabras = palabra.Count;
            for (int z = 0; z < palabra.Count; z++)
            {
                Console.WriteLine(palabra[z] + ": " + contar[z]);
            }
            Console.WriteLine("\n ");
            Console.WriteLine("la cantidad de palabras es: " + cantPalabras);
        }
    }
}
