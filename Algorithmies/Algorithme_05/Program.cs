namespace Exercice_05
{
    internal class Program
    {
        /*
         * Incrémentater une valeur
         */
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Ecrire a : ");
            a = Convert.ToInt32(Console.ReadLine());

            a++;

            Console.WriteLine($"Contenu de A : {a}");
        }
    }
}