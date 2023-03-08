using System;

namespace Exercice_01
{
    internal class Program
    {
        /*
            Exercice n° 01 : Afficher la somme de deux nombres.
         */
        static void Main(string[] _)
        {
            int a, b;
            Console.WriteLine("Ecrire a : ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ecrire b : ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Résultat de a + b : {a + b}");
        }
    }
}