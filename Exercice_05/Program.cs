namespace Exercice_05
{
    /*
     *  Créer un programme 'le nombre magique'
     *  Un nombre aléatoire doit être créer entre 1 et 100
     *  L'utilisateur doit retrouver le nombre en question.
     *  Il n'a que 10 possibilités pour le retrouver.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int minValue = 1;
            int maxValue = 100;

            int lives = 10;

            Console.WriteLine("Bienvenue sur le nombre magique !");
            Console.WriteLine("--------------------------------\n");

            Console.WriteLine($"Vous devez deviner un nombre entre {minValue} et {maxValue}.");
            Console.WriteLine($"Vous disposez de {lives} vies pour y arriver !\n");

            int numberToFind = GenerateNumber(minValue, maxValue);

            bool find = Game(numberToFind, lives);

            CloseMessage(find);
        }

        private static int GenerateNumber(int minValue, int maxValue)
        {
            var random = new Random();
            return random.Next(minValue, maxValue);
        }

        private static bool Game(int numberToFind, int lives)
        {
            bool find = false;

            int number;
            bool isParse;

            do
            {
                Console.Write($"Entrer un nombre ({lives} vie(s) restante(s) ) : ");
                isParse = int.TryParse(Console.ReadLine()!, out number);

                if (isParse)               
                {
                    find = CompareNumber(numberToFind, number);
                    if (!find)
                    {
                        lives--;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t!! Vous n'avez pas introduit un entier");
                    Console.ForegroundColor = ConsoleColor.White;
                }

            } while (lives > 0 && !find);

            return find;
        }

        private static bool CompareNumber(int numberToFind, int inputNumber)
        {
            bool find = true;

            if (inputNumber > numberToFind)
            {
                Console.WriteLine("\tLe nombre magique est plus petit !");
                find = false;
            }
            else if (inputNumber < numberToFind)
            {
                Console.WriteLine("\tLe nombre magique est plus grand !");
                find = false;
            }

            return find;
        }

        private static void CloseMessage(bool find)
        {
            if (find)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nFélicitation ! Vous avez trouvé le nombre magique !");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nPerdu ! Vous n'avez pas perdu le nombre magique !");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}