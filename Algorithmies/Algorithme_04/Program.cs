using System;

namespace Exercice_04
{
    internal class Program
    {
        /*
            Inverser le contenu de 2 variables (sans variable temporaire).
         */
        static void Main(string[] _)
        {
            int a, b;
            Console.WriteLine("Ecrire a : ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ecrire b : ");
            b = Convert.ToInt32(Console.ReadLine());

            b = a + b;
            
            a = b - a;
            b = b - a;

            Console.WriteLine($"Contenu de A : {a}");
            Console.WriteLine($"Contenu de B : {b}");
        }
    }
}