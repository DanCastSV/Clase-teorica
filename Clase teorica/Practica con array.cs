using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_teorica
{
    class Practica_con_array
    {
        static void Main()
        {

            
            string[] estudiantes = { "Diego", "Pedro", "Harolina", "Dariana", "Hugo", "Jennifer", "Maria", "Sonia", "Kenia", "Francisco" };

            int length = estudiantes.Length;

            //Ordena el array de manera ascendente
            Array.Sort(estudiantes);

            
            /* muestra la solución
             * ya de manera ordenada
             */
            Console.WriteLine("Array ordenado:\n");
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(estudiantes[i]);
            }
            Console.ReadKey();
        }

    }
}
