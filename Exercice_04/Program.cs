namespace Exercice_04
{
/*
 *  Sur base de l'exercice précédent, développer une calculatrice avec les opérations de base.
 * (addition, soustraction division,  multiplication.
 *
 *  Au lancement de l'application, un menu doit s'afficher et l'utilisateur doit choisir quel type
 *  d'opération il doit effectuer.
 *
 *  Rappel : La division par 0 est impossible, il faut donc afficher un message d'erreur.
 *  Afficher un message d'erreur si l'utilisateur n'introduit pas un nombre entier.
 *
 *  On propose à l'utilisateur de recommancer tant qu'il n'introduit pas des valeurs entières
 */

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue sur votre calculatrice");
            Console.WriteLine("--------------------------------\n");

            var menu = ShowMenu();

            switch (menu)
            {
                case MenuEnum.Addition:
                    Addition();
                    break;
                case MenuEnum.Substraction:
                    Substraction();
                    break;
                case MenuEnum.Division:
                    break;
                case MenuEnum.Multiplication:
                    Multiplication();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private static MenuEnum ShowMenu()
        {
            int menu;
            bool isParse;

            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Soustraction");
            Console.WriteLine("3. Division");
            Console.WriteLine("4. Multiplication\n");

            do
            {
                Console.Write("Votre choix : ");
                isParse = int.TryParse(Console.ReadLine()!, out menu);

                if (!isParse)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t!! Vous n'avez pas introduit un entier");
                    Console.ForegroundColor = ConsoleColor.White;
                }

            } while (!isParse || menu is < 0 or > 4);

            return (MenuEnum)menu;
        }

        private static void Addition()
        {
            int a, b;

            a = ConsoleReadInteger();
            b = ConsoleReadInteger();

            Console.WriteLine($"Votre addition de {a} + {b} = {a + b}");
        }

        private static void Substraction()
        {
            int a, b;

            a = ConsoleReadInteger();
            b = ConsoleReadInteger();

            Console.WriteLine($"Votre division de {a} - {b} = {a - b}");
        }

        private static void Multiplication()
        {
            int a, b;

            a = ConsoleReadInteger();
            b = ConsoleReadInteger();

            Console.WriteLine($"Votre division de {a} * {b} = {a * b}");
        }

        private static int ConsoleReadInteger()
        {
            bool isParse;
            int a;

            do
            {
                Console.Write("Veuillez introduire un nombre : ");
                isParse = int.TryParse(Console.ReadLine(), out a);

                if (!isParse)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t!! Vous n'avez pas introduit un entier");
                    Console.ForegroundColor = ConsoleColor.White;

                }
            } while (!isParse);

            return a;
        }
    }
}