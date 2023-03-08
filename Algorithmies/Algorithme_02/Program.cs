using System;

namespace Exercice_02
{
    internal class Program
    {
        /*
           Exercice n° 02 : Afficher effectuer une sommes de deux nombres mais affecter cette valeur dans une variable.
         */
        static void Main(string[] _)
        {
            int a, b, c;
            Console.WriteLine("Ecrire a : ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ecrire b : ");
            b = Convert.ToInt32(Console.ReadLine());

            c = a + b;
            Console.WriteLine($"Résultat de a + b : {c}");
        }
    }
}