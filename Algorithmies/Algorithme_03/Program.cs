using System;

namespace Exercice_03
{
    internal class Program
    {
        /*
            Exercice 03 : Inverser le contenu de 2 variables (avec une variable temporaire).
         */
        static void Main(string[] _)
        {
            int a, b, tmp;
            Console.WriteLine("Ecrire a : ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ecrire b : ");
            b = Convert.ToInt32(Console.ReadLine());

            tmp = a;
            a = b;
            b = tmp;

            Console.WriteLine($"Contenu de A : {a}");
            Console.WriteLine($"Contenu de B : {b}");
        }
    }
}