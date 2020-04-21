using System;
using System.Collections.Generic;

namespace actividad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> persona = new Dictionary<string, string>();

            persona.Add("Juan", "55423412");
            persona.Add("Ernesto", "56985623");
            persona.Add("Mariana", "54787451");


            if (persona.ContainsKey("Juan"))
                Console.WriteLine(persona["Juan"]);
            //string nombre = "Pedro";
            if(persona.TryGetValue("Pedro", out string value))
                Console.WriteLine(value);
            else
                Console.WriteLine("no tiene la llave");


            Console.ReadLine();
            
            



        }
    }
}

