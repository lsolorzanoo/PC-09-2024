using System;

namespace Parcial_ll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[100];
            int[] notas = new int[100];
            for (int i = 0; i < 10; i++)

            {
                Console.WriteLine("ingrese el nombre del primer alumno");
                nombres[i] = Console.ReadLine();
                notas[i] = i;

                bool notacorrecta = false;
                while (!notacorrecta)
                {
                    Console.Write($"Ingrese la nota de {nombres[i]} (entre 0 y 100): ");
                    string nota1

                        }

        }
    }
}
