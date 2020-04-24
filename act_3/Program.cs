using System;
using System.Collections.Generic;

namespace act_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaro mi variable de almacenamiento de la frase que ingrese el usurario
            string frase = "";
            Console.WriteLine("Ingrese la frase: \n");

            //Almaceno la frase ingresada
            frase = Console.ReadLine();

            //Guardo la frase en un array de String
            //toUpper: convierte todo a minuscula
            //Split: delimita la palabra por " "(espacio)
            string[] texto= frase.ToUpper().Split(" ");

            //Lista final de palabras
            List<string> palabras = new List<string>();

            //Lista de palabras a eliminar
            List<string> palabrasRemov = new List<string>();

            //Lista contador de repeticiones
            List<int> contarPalabras = new List<int>();

            Frase.cargaDeListas(texto, palabras, palabrasRemov, contarPalabras);

            Frase.EliminarRepetidos(palabras, palabrasRemov, contarPalabras);

            Frase.imprimir(palabras, contarPalabras);


        }
    }
}
